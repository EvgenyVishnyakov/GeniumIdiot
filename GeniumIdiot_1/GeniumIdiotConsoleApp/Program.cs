﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        static string GetDiagnoses(int countRightAnswers)
        {
            int defOfDiagnoses = countRightAnswers;
            string diagnoses = "";
            switch (defOfDiagnoses)
            {
                case 0: diagnoses = "кретин"; break;
                case 1: diagnoses = "идиот"; break;
                case 2: diagnoses = "дурак"; break;
                case 3: diagnoses = "нормальный"; break;
                case 4: diagnoses = "талант"; break;
                case 5: diagnoses = "гений"; break;
            }
            return diagnoses;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Добрый день! Как Ваше имя?");
            string name = Console.ReadLine();
            int countQuestions = 5;
            string[] questions = GetQuestions(countQuestions);


            Random random = new Random();
            
            
            string confirmOfProlongation = "да";
            while (confirmOfProlongation == "да")
            {
                int countRightAnswers = 0;
                for (int i = 0; i < countQuestions; i++)
                {
                    Console.WriteLine("Вопрос №" + (i + 1));
                    int randomQuestionIndex = random.Next(i + 1);
                    int tmp = randomQuestionIndex;
                    if (randomQuestionIndex != i+1)
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
                string diagnoses = GetDiagnoses(countRightAnswers);
                Console.WriteLine("Ваш диагноз: " + diagnoses);
                Console.WriteLine(name + "," + " желаете продолжить: да / нет ");
                confirmOfProlongation = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine(name + "," + "ждем Вас снова. Успехов!");
            Console.ReadKey();
        }
    }
}



