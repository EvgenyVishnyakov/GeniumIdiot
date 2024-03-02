// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
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
        static int GetAnswers(int numberOfQuestion);
        {
            int answers = new int[numberOfQuestion];
            switch (answers){
            case 0: 6; break;
            case 1: 9; break;
            case 2: 25; break;
            case 3: 60; break;
            case 4: 2; break;
            return answers; }           
          }
    static void Main(string[] args)
    {
    Console.WriteLine("Добрый день! Как Ваше имя? ");
    string name = Console.ReadLine();
    int countQuestions = 5; int numberOfQuestion = 5;
    string[] questions = GetQuestions(countQuestions);
    int answers = GetAnswers(numberOfQuestion);


     }

