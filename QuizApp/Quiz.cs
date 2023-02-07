using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Quiz
    {
        /// <summary>
        /// This class is used to track the Questions and the Score
        /// </summary>

        public List<Question> questions;
        public int currentQuestionIndex;
        public int score;

        public Quiz()
        {
            DataService dataService = new DataService();
            questions = dataService.LoadQuestions().Result;
            currentQuestionIndex = 0;
            score= 0;
        }

        public Question CurrentQuestion
        {
            get { return questions[currentQuestionIndex]; }
        }

        public int Score
        {
            get { return score; }
        }

        public bool IsComplete
        {
            get { return currentQuestionIndex >= questions.Count; }
        }

        public void SubmitAnswer(int answerIndex)
        {
            if (answerIndex == CurrentQuestion.CorrectAnswerIndex)
            {
                score++;
            }
            currentQuestionIndex++;
        }
    }
}
