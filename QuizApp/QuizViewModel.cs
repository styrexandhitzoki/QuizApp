using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class QuizViewModel
    {
        private Quiz quiz;

        public QuizViewModel()
        {
            quiz = new Quiz();
        }

        public string CurrentQuestionText
        {
            get { return quiz.CurrentQuestion.Text; }
        }

        public List<string> CurrentQuestionAnswers
        {
            get { return quiz.CurrentQuestion.Answers; }
        }

        public int Score
        {
            get { return quiz.Score; }
        }

        public bool IsQuizComplete
        {
            get { return quiz.IsComplete; }
        }

        public void SubmitAnswer(int answerIndex)
        {
            quiz.SubmitAnswer(answerIndex);
        }

        public void StartQuiz()
        {
            quiz = new Quiz();
        }
    }
}
