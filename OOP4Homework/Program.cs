using System;

namespace OOP4Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Build build1 = new Build(15, 5, 100, 5);
            build1.GetBuild();
            Build build2 = new Build(15, 5, 100, 5);
            build2.GetBuild();
            Console.WriteLine($"Высота этажа: {build2.HeightFloor()}  Количество квартир в подъезде: {build2.CountApartmentsInEntrance()} " +
                $"Количество квартир на этаже: {build2.CountApartmentsOnFloor()}");
        }
    }
}
