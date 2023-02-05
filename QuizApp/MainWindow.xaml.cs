using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private QuizViewModel quizViewModel;

        public MainWindow()
        {
            InitializeComponent();
            quizViewModel = new QuizViewModel();
            DataContext = quizViewModel;
        }

        private void SubmitAnswer_Click(object sender, RoutedEventArgs e)
        {
            int selectedAnswerIndex = 0; // code to get the index of the selected answer (from the UI)
            quizViewModel.SubmitAnswer(selectedAnswerIndex);
        }

        private void StartQuiz_Click(object sender, RoutedEventArgs e)
        {
            quizViewModel.StartQuiz();
        }
    }
}
