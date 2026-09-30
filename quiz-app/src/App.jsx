import { useEffect, useMemo, useState } from "preact/hooks";

const STORAGE_PREFIX = "maturitaQuizSeenCorrectV2";

export function App() {
  const [questionSets, setQuestionSets] = useState([]);
  const [selectedQuestionSet, setSelectedQuestionSet] = useState("default");
  const [topics, setTopics] = useState([]);
  const [questions, setQuestions] = useState([]);
  const [selectedTopics, setSelectedTopics] = useState(new Set());
  const [includeSeen, setIncludeSeen] = useState(false);
  const [seenCorrect, setSeenCorrect] = useState(new Set());
  const [currentQuestionId, setCurrentQuestionId] = useState(null);
  const [displayOrderNonce, setDisplayOrderNonce] = useState(0);
  const [currentAnswer, setCurrentAnswer] = useState(null);
  const [feedback, setFeedback] = useState(null);
  const [answeredCount, setAnsweredCount] = useState(0);

  useEffect(() => {
    bootstrap();
  }, []);

  async function bootstrap() {
    const manifestResponse = await fetch("/question-sets.json");
    const manifest = await manifestResponse.json();
    const defaultSetId = manifest.defaultSetId || manifest.sets[0]?.id || "default";

    setQuestionSets(manifest.sets);
    setSelectedQuestionSet(defaultSetId);
    await loadQuestionSet(manifest.sets, defaultSetId);
  }

  async function loadQuestionSet(sets, setId) {
    const selectedSet = sets.find((set) => set.id === setId) || sets[0];
    if (!selectedSet) {
      return;
    }

    const rawSeen = sessionStorage.getItem(getStorageKey(selectedSet.id));
    if (rawSeen) {
      try {
        const parsed = JSON.parse(rawSeen);
        if (Array.isArray(parsed)) {
          setSeenCorrect(new Set(parsed));
        }
      } catch {
        sessionStorage.removeItem(getStorageKey(selectedSet.id));
      }
    } else {
      setSeenCorrect(new Set());
    }

    const response = await fetch(selectedSet.file);
    const payload = await response.json();
    setTopics(payload.topics);
    setQuestions(payload.questions);
    setSelectedTopics(new Set(payload.topics.map((topic) => topic.id)));
    setCurrentQuestionId(null);
    setCurrentAnswer(null);
    setFeedback(null);
    setAnsweredCount(0);
  }

  async function changeQuestionSet(setId) {
    setSelectedQuestionSet(setId);
    await loadQuestionSet(questionSets, setId);
  }

  const currentPool = useMemo(() => {
    return questions.filter((question) => {
      if (!selectedTopics.has(question.topicId)) {
        return false;
      }
      if (includeSeen) {
        return true;
      }
      return !seenCorrect.has(question.id);
    });
  }, [questions, selectedTopics, includeSeen, seenCorrect]);

  const currentQuestion = useMemo(() => {
    return questions.find((question) => question.id === currentQuestionId) ?? null;
  }, [questions, currentQuestionId]);

  /** Náhodné pořadí zobrazení možností (odpověď se stále ukládá podle původních indexů v JSON). */
  const optionsDisplayOrder = useMemo(() => {
    if (!currentQuestion || currentQuestion.type === "open") {
      return null;
    }
    const n = currentQuestion.options?.length ?? 0;
    if (n < 2) {
      return null;
    }
    return shuffleIndices(n);
  }, [currentQuestionId, displayOrderNonce, currentQuestion?.id, currentQuestion?.type, currentQuestion?.options?.length]);

  useEffect(() => {
    if (feedback) {
      return;
    }

    if (!currentPool.length) {
      setCurrentQuestionId(null);
      setCurrentAnswer(null);
      setFeedback(null);
      return;
    }

    if (!currentQuestionId || !currentPool.some((q) => q.id === currentQuestionId)) {
      pickNextQuestion(currentPool);
    }
  }, [currentPool, currentQuestionId, feedback]);

  function pickNextQuestion(pool = currentPool) {
    if (!pool.length) {
      setCurrentQuestionId(null);
      return;
    }
    const randomIndex = Math.floor(Math.random() * pool.length);
    setDisplayOrderNonce((n) => n + 1);
    setCurrentQuestionId(pool[randomIndex].id);
    setCurrentAnswer(null);
    setFeedback(null);
  }

  function toggleTopic(topicId) {
    setSelectedTopics((previous) => {
      const next = new Set(previous);
      if (next.has(topicId)) {
        next.delete(topicId);
      } else {
        next.add(topicId);
      }
      return next;
    });
  }

  function setAllTopics(enabled) {
    if (enabled) {
      setSelectedTopics(new Set(topics.map((topic) => topic.id)));
      return;
    }
    setSelectedTopics(new Set());
  }

  function onSubmit(event) {
    event.preventDefault();
    if (!currentQuestion) {
      return;
    }

    const result = evaluateQuestion(currentQuestion, currentAnswer);
    setAnsweredCount((count) => count + 1);

    if (result.isCorrect) {
      setSeenCorrect((previous) => {
        const next = new Set(previous);
        next.add(currentQuestion.id);
        sessionStorage.setItem(getStorageKey(selectedQuestionSet), JSON.stringify([...next]));
        return next;
      });
    }

    setFeedback({
      isCorrect: result.isCorrect,
      message: result.message,
      detail: result.detail,
      rightAnswer: getRightAnswerText(currentQuestion),
      userAnswer: getUserAnswerText(currentQuestion, currentAnswer),
      explanation: currentQuestion.explanation,
      reasoning: result.reasoning,
    });
  }

  const selectedQuestionCount = questions.filter((q) =>
    selectedTopics.has(q.topicId)
  ).length;

  return (
    <div className="layout">
      <header className="header card">
        <div>
          <h1>Maturitní teoretický kvíz</h1>
          <p>
            Procvičuj témata po okruzích, opakuj chyby a sleduj pokrok. Otevřené
            otázky jsou pouze jednoslovné.
          </p>
        </div>
      </header>

      <aside className="sidebar card">
        <div className="sidebar-head">
          <h2>Filtr témat</h2>
          <div className="actions">
            <button onClick={() => setAllTopics(true)}>Všechna</button>
            <button className="btn-soft" onClick={() => setAllTopics(false)}>
              Vymazat
            </button>
          </div>
        </div>

        <label className="field">
          <span>Sada otázek</span>
          <select
            className="select-input"
            value={selectedQuestionSet}
            onChange={(event) => changeQuestionSet(event.currentTarget.value)}
          >
            {questionSets.map((set) => (
              <option key={set.id} value={set.id}>
                {set.label}
              </option>
            ))}
          </select>
        </label>

        <label className="switch">
          <input
            type="checkbox"
            checked={includeSeen}
            onChange={(e) => setIncludeSeen(e.target.checked)}
          />
          <span>Zobrazit i správně zodpovězené</span>
        </label>

        <div className="topic-grid">
          {topics.map((topic) => (
            <label className="topic-chip" key={topic.id}>
              <input
                type="checkbox"
                checked={selectedTopics.has(topic.id)}
                onChange={() => toggleTopic(topic.id)}
              />
              <span>{topic.label}</span>
            </label>
          ))}
        </div>
      </aside>

      <section className="stats card">
        <div>
          <small>Otázky ve filtru</small>
          <strong>{selectedQuestionCount}</strong>
        </div>
        <div>
          <small>Zbývá v aktuální relaci</small>
          <strong>{currentPool.length}</strong>
        </div>
        <div>
          <small>Správně v relaci</small>
          <strong>{seenCorrect.size}</strong>
        </div>
        <div>
          <small>Zodpovězeno</small>
          <strong>{answeredCount}</strong>
        </div>
      </section>

      <section className="question card">
        {!currentQuestion && (
          <div className="empty">
            <h2>Žádná otázka k zobrazení</h2>
            <p>
              Vyber aspoň jedno téma nebo zapni volbu pro zobrazení již správně
              zodpovězených otázek.
            </p>
          </div>
        )}

        {currentQuestion && (
          <>
            <div className="question-head">
              <span className="badge">
                {topics.find((item) => item.id === currentQuestion.topicId)?.label ??
                  "Téma"}
              </span>
              <h2>{currentQuestion.prompt}</h2>
            </div>

            <form onSubmit={onSubmit}>
              <AnswerPanel
                question={currentQuestion}
                answer={currentAnswer}
                setAnswer={setCurrentAnswer}
                disabled={Boolean(feedback)}
                feedback={feedback}
                optionsDisplayOrder={optionsDisplayOrder}
              />

              <div className="actions">
                <button disabled={!isAnswerReady(currentQuestion, currentAnswer) || !!feedback}>
                  Vyhodnotit
                </button>
                <button
                  type="button"
                  className="btn-soft"
                  onClick={() => pickNextQuestion()}
                  disabled={!currentPool.length}
                >
                  Další otázka
                </button>
              </div>
            </form>

            {feedback && (
              <div className={`feedback ${feedback.isCorrect ? "ok" : "bad"}`} aria-live="polite">
                <h3>{feedback.isCorrect ? "Správně" : "Nesprávně"}</h3>
                <p>{feedback.message}</p>
                <p>
                  <strong>Tvoje odpověď:</strong> {feedback.userAnswer}
                </p>
                <p>
                  <strong>Správná odpověď:</strong> {feedback.rightAnswer}
                </p>
                {feedback.detail && <p>{feedback.detail}</p>}
                {feedback.reasoning && <p>{feedback.reasoning}</p>}
                <p>{feedback.explanation}</p>
              </div>
            )}
          </>
        )}
      </section>
    </div>
  );
}

function AnswerPanel({ question, answer, setAnswer, disabled, feedback, optionsDisplayOrder }) {
  const showEvaluation = Boolean(feedback);

  if (question.type === "open") {
    const inputClass = `text-input ${
      showEvaluation ? (feedback.isCorrect ? "text-input-ok" : "text-input-bad") : ""
    }`;
    return (
      <div className="answer-block">
        <input
          className={inputClass}
          type="text"
          placeholder={question.answerHint || "Jednoslovná odpověď"}
          value={answer ?? ""}
          onInput={(e) => setAnswer(e.currentTarget.value)}
          disabled={disabled}
        />
      </div>
    );
  }

  const order =
    Array.isArray(optionsDisplayOrder) && optionsDisplayOrder.length === question.options.length
      ? optionsDisplayOrder
      : question.options.map((_, i) => i);

  if (question.type === "single_select") {
    const correctSet = new Set(question.correctAnswers);
    return (
      <div className="answer-block">
        {order.map((originalIndex) => (
          <label
            key={`${question.id}-${originalIndex}`}
            className={getOptionClassName({
              showEvaluation,
              correctSet,
              selected: answer === originalIndex,
              index: originalIndex,
            })}
          >
            <input
              type="radio"
              name={`q-${question.id}`}
              checked={answer === originalIndex}
              onChange={() => setAnswer(originalIndex)}
              disabled={disabled}
            />
            <span>{question.options[originalIndex]}</span>
          </label>
        ))}
      </div>
    );
  }

  const selected = new Set(Array.isArray(answer) ? answer : []);
  const correctSet = new Set(question.correctAnswers);
  return (
    <div className="answer-block">
      {order.map((originalIndex) => (
        <label
          key={`${question.id}-${originalIndex}`}
          className={getOptionClassName({
            showEvaluation,
            correctSet,
            selected: selected.has(originalIndex),
            index: originalIndex,
          })}
        >
          <input
            type="checkbox"
            checked={selected.has(originalIndex)}
            disabled={disabled}
            onChange={() => {
              const next = new Set(selected);
              if (next.has(originalIndex)) {
                next.delete(originalIndex);
              } else {
                next.add(originalIndex);
              }
              setAnswer([...next]);
            }}
          />
          <span>{question.options[originalIndex]}</span>
        </label>
      ))}
    </div>
  );
}

function evaluateQuestion(question, answer) {
  const meta = question.feedback ?? {};
  if (question.type === "open") {
    const normalized = normalizeWord(answer || "");
    const validAnswers = question.acceptedAnswers.map((item) => normalizeWord(item));
    const isCorrect = validAnswers.includes(normalized);
    return {
      isCorrect,
      message: isCorrect
        ? "Jednoslovná odpověď je správná."
        : "Tahle jednoslovná odpověď neodpovídá očekávanému pojmu.",
      detail: isCorrect
        ? "Odpověď odpovídá akceptovanému pojmu."
        : "Odpověď se neshoduje s očekávaným pojmem ani jeho variantou zápisu.",
      reasoning: isCorrect ? meta.whyCorrect : meta.definition || meta.whyCorrect,
    };
  }

  if (question.type === "single_select") {
    const isCorrect =
      typeof answer === "number" &&
      question.correctAnswers.length === 1 &&
      question.correctAnswers[0] === answer;
    const selectedText =
      typeof answer === "number" ? question.options[answer] : "bez výběru";
    const correctText = question.options[question.correctAnswers[0]];
    const reasonFromMeta = sanitizeReasoning(
      meta.whyCorrect ||
        (isCorrect
          ? `Zvolená možnost „${selectedText}“ odpovídá definici pojmu.`
          : `Zvolená možnost „${selectedText}“ neodpovídá definici; správně je „${correctText}“.`),
      question.explanation
    );
    return {
      isCorrect,
      message: isCorrect
        ? "Vybral/a jsi správnou možnost."
        : "Vybraná možnost není správná.",
      detail: isCorrect
        ? `Možnost „${selectedText}“ odpovídá zadané definici nebo tvrzení.`
        : `Možnost „${selectedText}“ neodpovídá zadání; správně je „${correctText}“.`,
      reasoning:
        reasonFromMeta ||
        buildSingleReasonFromOptionMap(question, typeof answer === "number" ? answer : null),
    };
  }

  const selected = new Set(Array.isArray(answer) ? answer : []);
  const correct = new Set(question.correctAnswers);
  const isCorrect =
    selected.size === correct.size &&
    [...selected].every((index) => correct.has(index));
  const reasonFromMeta = sanitizeReasoning(meta.whyCorrect, question.explanation);
  return {
    isCorrect,
    message: isCorrect
      ? "Vybral/a jsi správnou kombinaci možností."
      : "Kombinace možností není správná.",
    detail: buildMultiFeedbackDetail(question, selected, correct),
    reasoning: reasonFromMeta || buildMultiReasonFromOptionMap(question, selected, correct),
  };
}

function isAnswerReady(question, answer) {
  if (question.type === "open") {
    return typeof answer === "string" && answer.trim().length > 0;
  }
  if (question.type === "single_select") {
    return typeof answer === "number";
  }
  return Array.isArray(answer) && answer.length > 0;
}

function normalizeWord(value) {
  return String(value)
    .normalize("NFD")
    .replace(/\p{Diacritic}/gu, "")
    .toLowerCase()
    .replace(/[^a-z0-9]/g, "");
}

function getRightAnswerText(question) {
  if (question.type === "open") {
    return question.acceptedAnswers.join(", ");
  }
  const options = question.correctAnswers.map((index) => question.options[index]);
  return options.join(" | ");
}

function getUserAnswerText(question, answer) {
  if (question.type === "open") {
    return typeof answer === "string" && answer.trim().length
      ? answer.trim()
      : "bez odpovědi";
  }

  if (question.type === "single_select") {
    if (typeof answer !== "number") {
      return "bez výběru";
    }
    return question.options[answer];
  }

  if (!Array.isArray(answer) || answer.length === 0) {
    return "bez výběru";
  }
  return answer.map((index) => question.options[index]).join(" | ");
}

function getOptionClassName({ showEvaluation, correctSet, selected, index }) {
  if (!showEvaluation) {
    return "option-row";
  }

  if (correctSet.has(index)) {
    return "option-row option-correct";
  }

  if (selected && !correctSet.has(index)) {
    return "option-row option-wrong";
  }

  return "option-row option-neutral";
}

function buildMultiFeedbackDetail(question, selected, correct) {
  const targetIsMyth = /mýt|chybn/i.test(question.prompt);
  const selectedIndexes = [...selected];
  const selectedCorrect = selectedIndexes.filter((index) => correct.has(index));
  const selectedWrong = selectedIndexes.filter((index) => !correct.has(index));
  const missingCorrect = [...correct].filter((index) => !selected.has(index));

  const parts = [];
  if (selectedCorrect.length) {
    parts.push(
      `Správně vybrané možnosti: ${selectedCorrect
        .map((index) => `„${question.options[index]}“`)
        .join(", ")}.`
    );
  }
  if (selectedWrong.length) {
    parts.push(
      `Nesprávně vybrané možnosti: ${selectedWrong
        .map((index) => `„${question.options[index]}“`)
        .join(", ")} (jsou to ${targetIsMyth ? "pravdivá tvrzení" : "mýty/chybná tvrzení"}).`
    );
  }
  if (missingCorrect.length) {
    parts.push(
      `Chyběly ti možnosti: ${missingCorrect
        .map((index) => `„${question.options[index]}“`)
        .join(", ")} (to jsou ${targetIsMyth ? "mýty/chybná tvrzení" : "pravdivá tvrzení"}).`
    );
  }

  if (!parts.length) {
    return targetIsMyth
      ? "Vybral/a jsi přesně všechny mýty a žádné pravdivé tvrzení navíc."
      : "Vybral/a jsi přesně všechna pravdivá tvrzení a žádný mýtus navíc.";
  }

  return parts.join(" ");
}

function sanitizeReasoning(reasoning, explanation) {
  if (!reasoning) {
    return null;
  }
  const normalizedReasoning = normalizeFeedbackText(reasoning);
  const normalizedExplanation = normalizeFeedbackText(explanation || "");
  if (!normalizedReasoning || normalizedReasoning === normalizedExplanation) {
    return null;
  }
  if (
    normalizedReasoning.includes("myty jsou zavadici vyroky") ||
    normalizedReasoning.includes("spravna kombinace je")
  ) {
    return null;
  }
  return reasoning;
}

function buildSingleReasonFromOptionMap(question, selectedIndex) {
  const map = question.feedback?.whyOthersWrong || {};
  const correctIndex = question.correctAnswers[0];
  const parts = [];

  if (selectedIndex !== null && selectedIndex !== undefined) {
    parts.push(
      `Tvoje volba „${question.options[selectedIndex]}“: ${
        map[String(selectedIndex)] || "Tahle možnost neodpovídá definici otázky."
      }`
    );
  }

  if (selectedIndex !== correctIndex) {
    parts.push(
      `Správná volba „${question.options[correctIndex]}“: ${
        map[String(correctIndex)] || "Tahle možnost odpovídá definici otázky."
      }`
    );
  }

  return parts.join(" ");
}

function buildMultiReasonFromOptionMap(question, selected, correct) {
  const map = question.feedback?.whyOthersWrong || {};
  const wrongSelected = [...selected].filter((index) => !correct.has(index));
  const missing = [...correct].filter((index) => !selected.has(index));

  const parts = [];
  if (wrongSelected.length) {
    parts.push(
      `Nesprávně vybrané: ${wrongSelected
        .map(
          (index) =>
            `„${question.options[index]}“ (${map[String(index)] || "Neodpovídá zadání."})`
        )
        .join("; ")}.`
    );
  }
  if (missing.length) {
    parts.push(
      `Chybějící správné: ${missing
        .map(
          (index) =>
            `„${question.options[index]}“ (${map[String(index)] || "Tohle tvrzení bylo potřeba vybrat."})`
        )
        .join("; ")}.`
    );
  }
  if (!parts.length) {
    return "Vybral/a jsi správné možnosti bez chybných navíc.";
  }
  return parts.join(" ");
}

function normalizeFeedbackText(text) {
  return String(text)
    .normalize("NFD")
    .replace(/\p{Diacritic}/gu, "")
    .toLowerCase()
    .replace(/[^\w\s]/g, " ")
    .replace(/\s+/g, " ")
    .trim();
}

function getStorageKey(questionSetId) {
  return `${STORAGE_PREFIX}:${questionSetId}`;
}

/** Náhodná permutace [0 .. n-1] (Fisher–Yates). */
function shuffleIndices(n) {
  const arr = Array.from({ length: n }, (_, i) => i);
  for (let i = arr.length - 1; i > 0; i--) {
    const j = Math.floor(Math.random() * (i + 1));
    const t = arr[i];
    arr[i] = arr[j];
    arr[j] = t;
  }
  return arr;
}
