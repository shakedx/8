using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {

            //1

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("hh:mm:tt"));

            //2

            Console.WriteLine("Введите дату предстоящего запуска космического корабля:");
            Console.Write("Введите часы:");
            int h1 = int.Parse(Console.ReadLine());
            Console.Write("Введите минуты:");
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Введите секунды:");
            int s1 = int.Parse(Console.ReadLine());
            DateTime date1 = new DateTime(
            DateTime.Now.Year,
            DateTime.Now.Month,
            DateTime.Now.Day,
            h1, m1, s1);
            Console.WriteLine("Введите текущую дату:");
            Console.Write("Введите часы:");
            int h2 = int.Parse(Console.ReadLine());
            Console.Write("Введите минуты:");
            int m2 = int.Parse(Console.ReadLine());
            Console.Write("Введите секунды:");
            int s2 = int.Parse(Console.ReadLine());
            DateTime date2 = new DateTime(
            DateTime.Now.Year,
            DateTime.Now.Month,
            DateTime.Now.Day,
            h2, m2, s2);

            if (date1 < date2) Console.WriteLine("Осталось времени:" + date2.Subtract(date1));

        }
    }
}
