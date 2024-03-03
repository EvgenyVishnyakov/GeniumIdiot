using System;
using System.Diagnostics.Eventing.Reader;

namespace GeniumIdiotConsoleApp
{
    internal class Program
    {
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
        static int RightAnswers(int randomQuestionIndex)
        {
            int answers = randomQuestionIndex;
            switch (answers)
            {
                case 0: answers = 6; break;
                case 1: answers = 9; break;
                case 2: answers = 25; break;
                case 3: answers = 60; break;
                case 4: answers = 2; break;
            }
            return answers;
        }
        static string[] GetDiagnoses(int countRightAnswers)
        {
            string[] diagnoses = new string[countRightAnswers];
            diagnoses[0] = "кретин";
            diagnoses[1] = "идиот";
            diagnoses[2] = "дурак";
            diagnoses[3] = "нормальный";
            diagnoses[4] = "талант";
            diagnoses[5] = "гений";
            return diagnoses;            
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Добрый день! Как Ваше имя?");
            string name = Console.ReadLine();
            int countQuestions = 5;
            string[] questions = GetQuestions(countQuestions);
            int countRightAnswers = 0;
            
            Random random = new Random();
            string confirmOfProlongation = "да";
            while (confirmOfProlongation == "да")
            {
                for (int i = 0; i < countQuestions; i++)
                {
                    Console.WriteLine("Вопрос №" + (i + 1));
                    int randomQuestionIndex = random.Next(countQuestions - i - 1);
                    if (randomQuestionIndex != i + 1)
                    {
                        randomQuestionIndex = countQuestions - i - 1;
                    }
                    else
                    {
                        randomQuestionIndex = i;
                    }

                    Console.WriteLine(questions[randomQuestionIndex]);

                    int userAnswer = Convert.ToInt32(Console.ReadLine());
                    int rightAnswer = RightAnswers(randomQuestionIndex);
                    if (userAnswer == rightAnswer)
                    {
                        countRightAnswers++;
                    }
                }
                Console.WriteLine(name + "," + "количество правильных ответов: " + countRightAnswers);
                string[] diagnoses = GetDiagnoses(countRightAnswers);
                Console.WriteLine(name + "," + "ваш диагноз:" + diagnoses[countRightAnswers]);
                Console.WriteLine(name + "," + "желаете продолжить: да / нет ");
                confirmOfProlongation = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine(name + "," + "ждем Вас снова. Успехов!");           
        }
    }
}
