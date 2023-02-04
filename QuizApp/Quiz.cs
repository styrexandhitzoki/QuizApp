using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Quiz
    {
        public List<string> questions;
        public int currentQuestionIndex;
        public int score;

        public Quiz()
        {
            DataService dataService = new DataService();
            //questions = dataService.LoadQuestions();
            currentQuestionIndex = 0;
            score= 0;
        }
    }
}
