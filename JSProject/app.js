let question = document.getElementById("question");
let answer1 = document.getElementById("answer1");
let answer2 = document.getElementById("answer2");
let answer3 = document.getElementById("answer3");
let answer4 = document.getElementById("answer4");

let data = fetch("questions.json")
    .then(response => response.json())
    .then(data => {
        GetRandQuestion(data.questions);
    });

answer1.addEventListener("click" )
function GetRandQuestion(questions) {
    let i = Math.floor(Math.random() * questions.length);

    question.textContent = questions[i].question;
    answer1.textContent = questions[i].options[0];
    answer2.textContent = questions[i].options[1];
    answer3.textContent = questions[i].options[2];
    answer4.textContent = questions[i].options[3];
}