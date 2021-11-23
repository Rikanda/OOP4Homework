using System;

namespace OOP4Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // доавление зданий

           Creator.CreateBuild(15, 5, 100, 5);
           Creator.CreateBuild(15, 5, 100, 5);
           Creator.CreateBuild(15, 5, 100, 5);
           Creator.CreateBuild(15, 5, 100, 5);
            // вывод хэш-таблицы
            Creator.PrintBuilds();

            Console.WriteLine("Удаление здания с номером 3");
            Creator.DeleteBuild(3);
            // вывод хэш-таблицы
            Creator.PrintBuilds();

            Console.WriteLine("Удаление здания с номером 7");
            Creator.DeleteBuild(7);

            // печать информации о 2м здании
            Console.WriteLine("Информация о здании с номером 2:");
            Creator.InfoBuild(2);

        }
    }
}
