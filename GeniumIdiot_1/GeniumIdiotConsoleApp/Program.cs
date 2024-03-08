using System;
 
namespace GeniumIdiotConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Добрый день! Как Ваше имя?");
            var name = Console.ReadLine();
            int countQuestions = 5;
            string[] questions = GetQuestions(countQuestions);
            int[] answersOfQuestion = GetRightQuestions(countQuestions);

            var confirmOfProlongation = "да";
            while (confirmOfProlongation == "да")
            {
                int countRightAnswers = 0;
                int numberOfQuestion = 1;
                for (int randomQuestionIndex = questions.Length - 1; randomQuestionIndex >= 0; randomQuestionIndex--)
                {
                    Console.WriteLine("Вопрос №" + numberOfQuestion);
                    numberOfQuestion++;

                    var index = random.Next(randomQuestionIndex + 1);
                    var tempQuestion = questions[index];
                    questions[index] = questions[randomQuestionIndex];
                    questions[randomQuestionIndex] = tempQuestion;

                    var tempAnswer = answersOfQuestion[index];
                    answersOfQuestion[index] = answersOfQuestion[randomQuestionIndex];
                    answersOfQuestion[randomQuestionIndex] = tempAnswer;

                    Console.WriteLine(questions[randomQuestionIndex] + "");

                    int userAnswer = Convert.ToInt32(Console.ReadLine());
                    var rightAnswer = answersOfQuestion[randomQuestionIndex];
                    if (userAnswer == rightAnswer)
                    {
                        countRightAnswers++;
                    }
                }
                Console.WriteLine(name + "," + "количество правильных ответов: " + countRightAnswers);
                string[] diagnoses = GetDiagnoses();

                Console.WriteLine("Ваш диагноз: " + diagnoses[countRightAnswers]);
                Console.WriteLine(name + "," + " желаете продолжить: Да или Нет ");
                
                while (true)
                {
                    confirmOfProlongation = Convert.ToString(Console.ReadLine());
                    if (confirmOfProlongation.ToLower() == "да" || confirmOfProlongation.ToLower() == "нет")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите Да или Нет ");
                    }
                }
            }
            Console.WriteLine(name + "," + "ждем Вас снова. Успехов!");
            Console.ReadKey();
        }
        static int [] GetRightQuestions(int countQuestions)
        {
            int[] answersOfQuestion = new int[countQuestions];
            answersOfQuestion[0] = 6;
            answersOfQuestion[1] = 9;
            answersOfQuestion[2] = 25;
            answersOfQuestion[3] = 60;
            answersOfQuestion[4] = 2;
            return answersOfQuestion;
        }
        static string[] GetQuestions(int countQuestions)
        {
            string[] questions = new string[countQuestions];
            questions[0] = "Сколько будет два плюс два умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?";
            questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";
            return questions;
        }
        private static string[] GetDiagnoses()
        {
            string[] diagnoses = new string[6];
            diagnoses[0] = "кретин";
            diagnoses[1] = "идиот";
            diagnoses[2] = "дурак";
            diagnoses[3] = "нормальный";
            diagnoses[4] = "талант";
            diagnoses[5] = "гений"; 
            return diagnoses;
        }
    }
}



