using System;

namespace HomeWork2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string FullName = "Антон Петров";
            int Age = 18;
            string Email = "AnPetrov@mail.com";
            int markProgramming = 51;
            int markMath = 47;
            int markPhysics = 69;

            string FUNA = $"Ф.И.О. - {FullName}";
            Console.SetCursorPosition(Console.WindowWidth / 2 - FUNA.Length / 2, Console.WindowHeight / 2 - 4);
            Console.WriteLine(FUNA);

            string AGE = $"Возраст - {Age}";
            Console.SetCursorPosition(Console.WindowWidth / 2 - AGE.Length / 2, Console.WindowHeight / 2 - 3);
            Console.WriteLine(AGE);

            string EMAIL = $"Эл. почта - {Email}";
            Console.SetCursorPosition(Console.WindowWidth / 2 - EMAIL.Length / 2, Console.WindowHeight / 2 - 2);
            Console.WriteLine(EMAIL);
            

            string markProStr = $"Баллы по программированию - {markProgramming}";
            Console.SetCursorPosition(Console.WindowWidth / 2 - markProStr.Length / 2, Console.WindowHeight / 2 - 1);
            Console.WriteLine(markProStr);

            string markMathStr = $"Баллы по математике - {markMath}";
            Console.SetCursorPosition(Console.WindowWidth / 2 - markMathStr.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(markMathStr);

            string markPhysStr = $"Баллы по физике - {markPhysics}";
            Console.SetCursorPosition(Console.WindowWidth / 2 - markPhysStr.Length / 2, Console.WindowHeight / 2 + 1);
            Console.WriteLine(markPhysStr);





            //string infoStudent = "Ф.И.О. - " + $"{FullName}" + "\nВозраст - " + $"{Age}" + " \nЭл. почта - " + $"{Email}" +
            //    "\nБаллы по программированию - " + $"{markProgramming}" + "\nБаллы по математике - " + $"{markMath}" + "\nБаллы по физике - " + $"{markPhysics}";

            //Console.WriteLine(infoStudent);


            Console.ReadKey();
            int markSum = markMath + markPhysics + markProgramming;
            double markMedian = Math.Round((double)markSum / 3, 2);


            string MARKSUM = $"Сумма баллов - " + $"{markSum}";
            Console.SetCursorPosition(Console.WindowWidth / 2 - MARKSUM.Length / 2, Console.WindowHeight / 2 + 2);
            Console.WriteLine(MARKSUM);
            Console.ReadKey();

            string MAKRMEDIAN = $"Средний балл - {markMedian}";
            Console.SetCursorPosition(Console.WindowWidth / 2 - MAKRMEDIAN.Length / 2, Console.WindowHeight / 2 + 3);
            Console.WriteLine(MAKRMEDIAN);            
            Console.ReadKey();

        }
    }
}