using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace GeniyIdiotConsoleApp
{
    class Program
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
        static int RightAnswers(int numberOfQuastions)
        {
            int answers = numberOfQuastions;
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
            diagnoses[4] = "талан";
            diagnoses[5] = "гений";
            return diagnoses;
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Добрый день! Как Ваше имя?");
                string name = Console.ReadLine();
                int countQuestions = 5; int numberOfQuastion = 5;
                string[] questions = GetQuestions(countQuestions);
                int answers = RightAnswers(numberOfQuastion);

                int countRightAnswers = 0;

                Random random = new Random();

                for (int i = 0; i < countQuestions; i++)
                {
                    Console.WriteLine("Вопрос №" + (i + 1));

                    int randomQuestionIndex = random.Next(0, countQuestions);
                    Console.WriteLine(questions[randomQuestionIndex]);

                    int userAnswer = Convert.ToInt32(Console.ReadLine());

                    int rightAnswer = answers[randomQuestionIndex];

                    if (userAnswer == rightAnswer)
                    {
                        countRightAnswers++;
                    }
                }

                Console.WriteLine("Количество правильных ответов: " + countRightAnswers);
                
                string[] diagnoses = GetDiagnoses(countRightAnswers);
                
                Console.WriteLine("Ваш диагноз:" + diagnoses[countRightAnswers]);
        }
    }   
}








