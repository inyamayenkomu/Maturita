# 23. Operační systémy – praktické příklady

Pět typických zadání k maturitní otázce. Řešení zatím neobsahuje - jde jen o zadání.

**Teorie:** [Teorie.md](Teorie.md)

---

## Příklad 1: Round-robin scheduler - základ

Napište konzolovou aplikaci v C#, která:

- Uživatel zadá počet procesů.
- U každého procesu zadá dobu běhu (v časových jednotkách).
- Uživatel zadá časové kvantum.
- Simuluje round-robin a po každém kroku vypíše běžící proces, zbývající čas a okamžik dokončení.

---

## Příklad 2: Round-robin s různým kvantem

Napište konzolovou aplikaci v C#, která:

- Na stejných datech procesů spustí simulaci pro dvě různá kvanta (např. 1 a 3).
- U každé simulace vypíše průběh proces switching.
- Na konci porovná průměrný čekací čas.
- Stručně vyhodnotí, kdy je vhodné menší/větší kvantum.

---

## Příklad 3: Scheduler s příchody procesů

Napište konzolovou aplikaci v C#, která:

- U každého procesu uživatel zadá čas příchodu a dobu běhu.
- Scheduler zařazuje proces do fronty až od času příchodu.
- Simuluje round-robin s kvantem od uživatele.
- Vypíše, kdy proces čekal, kdy běžel a kdy skončil.

---

## Příklad 4: Scheduler s context-switch nákladem

Napište konzolovou aplikaci v C#, která:

- K základní round-robin simulaci přidá fixed cost za přepnutí procesu (např. 1 jednotka).
- Tento čas se přičte po každém switchi.
- Program vypíše celkový počet přepnutí a celkový overhead.
- Porovná dobu dokončení bez/with overhead.

---

## Příklad 5: FCFS vs Round-robin

Napište konzolovou aplikaci v C#, která:

- Načte procesy (ID + doba běhu).
- Spustí dvě simulace: FCFS a round-robin (kvantum zadá uživatel).
- U obou vypíše čas dokončení každého procesu.
- Na konci porovná férovost a odezvu plánovačů.
