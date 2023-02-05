using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Question
    {
        /// <summary>
        /// This class is used to show the Question Text and the Answers in the Application
        /// </summary>

        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string text, List<string> answers, int correctAnswerIndex)
        {
            Text = text;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
