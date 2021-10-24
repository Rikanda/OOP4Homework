using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4Homework
{
    class Build
    {
        private static int number = 1;

        public int Number { get; set; }

        public double Height { get; set; }

        public int Floors { get; set; }

        public int Apartments { get; set;  }

        public int Entrances { get; set; }

        // конструктор

        public Build(double height, int floors, int apartments, int entrances)
        {
            this.Height = height;
            this.Floors = floors;
            this.Apartments = apartments;
            this.Entrances = entrances;
            this.Number = number;
            ++number;
            
        }

        public void GetBuild()
        {
            Console.WriteLine($"Номер здания: {Number}  Высота: {Height}  Количество этажей: {Floors} Количество квартир: {Apartments}  Количество подъездов: {Entrances}");

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
}
