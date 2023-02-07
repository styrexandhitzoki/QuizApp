using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Newtonsoft.Json;

namespace QuizApp
{
    class DataService
    {
        /// <summary>
        /// This class is used to load the questions from the Trivia API
        /// </summary>
        /// <returns></returns>

        private async Task<List<Question>> LoadQuestionsFromApiAsync()
        {
            using (var client = new HttpClient())
            {
                string apiUrl = "https://the-trivia-api.com/api/questions/";

                string response = await client.GetStringAsync(apiUrl);
                List<Question> questions = JsonConvert.DeserializeObject<List<Question>>(response);

                return questions;
            }
        }

        public async Task<List<Question>> LoadQuestions()
        {
            var questionTask = LoadQuestionsFromApiAsync();
            var questions = await questionTask;
            return questions;
        }
    }
}
