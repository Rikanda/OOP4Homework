using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4Homework
{
      class Creator

    {
        // спрятала класс Здание внутрь класса фабрики -- не совсем уверена, что требовалось именно это, но условие поняла так, что все должно быть скрыто и недоступно извне
        private class Build
        {
            private static int number = 1;

            public int Number { get; set; }

            public double Height { get; set; }

            public int Floors { get; set; }

            public int Apartments { get; set; }

            public int Entrances { get; set; }

            public int Code { get; set; }

            // конструктор

            public Build(double height, int floors, int apartments, int entrances)
            {
                this.Height = height;
                this.Floors = floors;
                this.Apartments = apartments;
                this.Entrances = entrances;
                this.Number = number;
                this.Code = 0;
                ++number;

            }

            public override int GetHashCode()
            {
                int a = base.GetHashCode();
                this.Code = a;
                return a;
            }


            // высота этажа
            public double HeightFloor()
            {
                return this.Height / this.Floors;
            }

            // количество квартир в подъезде

            public int CountApartmentsInEntrance()
            {
                return this.Apartments / this.Entrances;
            }

            // количество квартир на этаже
            public int CountApartmentsOnFloor()
            {
                int c = this.CountApartmentsInEntrance();
                return c / this.Floors;
            }




        }

        // конструктор сделан приватным
        private Creator() { }

        // хэш-таблица для хранения объектов
        private static HashSet<Build> hashSet = new HashSet<Build>();

        // создание здания и добавление записи в хэш-таблицу
        public static void CreateBuild(double height, int floors, int apartments, int entrances)
        {
           Build build = new Build(height, floors, apartments, entrances);
            hashSet.Add(build);          
            
        }
        // печать хэш-таблицы
        public static void PrintBuilds()
        {
            foreach(Build b in hashSet)
            {
                Console.WriteLine($"Хэш код: {b.Code}  Номер здания: {b.Number}  Высота: {b.Height}  Количество этажей: {b.Floors} Количество квартир: {b.Apartments}  Количество подъездов: {b.Entrances} ");
                Console.WriteLine();
            }
        }

        // удаление по уникальному номеру
        public static void DeleteBuild(int n)
        {

            foreach(Build b in hashSet)
            {
                if(b.Number==n)
                {
                    hashSet.Remove(b);
                }
            }

        }
         
        // запрос параметров по номеру здания

        public static void InfoBuild(int n)
        {
            foreach (Build b in hashSet)
            {
                if (b.Number == n)
                {
                    Console.WriteLine($"Высота этажа: {b.HeightFloor()}  Количество квартир в подъезде: {b.CountApartmentsInEntrance()} " +
                $"Количество квартир на этаже: {b.CountApartmentsOnFloor()}");
                }
            }

        }



    }

    
}
