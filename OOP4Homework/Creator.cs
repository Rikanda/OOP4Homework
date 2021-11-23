using System;
using System.Collections;
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
            private static int count = 1;
            private int number;
            private double height;
            private int floors;
            private int apartments;
            private int entrances;
            private int code;


            public int Number 
            {
                get
                { 
                    return number; 
                }
                set
                {
                    try // добавлена валидация
                    {
                        number = value;
                        GetNumber(); // инкремент номера выведен в отдельный метод
                    }
                        
                    catch
                    {
                        Console.WriteLine("Возникло исключение!");
                    }
                } 
            }

            public double Height
            {
                get
                {
                    return height;
                }
                set
                {
                    try // добавлена валидация
                    {
                        height = value;
                    }

                    catch
                    {
                        Console.WriteLine("Возникло исключение!");
                    }
                }
            }

            public int Floors
            {
                get
                {
                    return floors;
                }
                set
                {
                    try // добавлена валидация
                    {
                        floors = value;
                    }

                    catch
                    {
                        Console.WriteLine("Возникло исключение!");
                    }
                }
            }

            public int Apartments
            {
                get
                {
                    return apartments;
                }
                set
                {
                    try // добавлена валидация
                    {
                        apartments = value;
                    }

                    catch
                    {
                        Console.WriteLine("Возникло исключение!");
                    }
                }
            }
            public int Entrances
            {
                get
                {
                    return entrances;
                }
                set
                {
                    try // добавлена валидация
                    {
                        entrances = value;
                    }

                    catch
                    {
                        Console.WriteLine("Возникло исключение!");
                    }
                }
            }

            public int Code
            {
                get
                {
                    return code;
                }
                set
                {
                    try // добавлена валидация
                    {
                        code = value;
                    }

                    catch
                    {
                        Console.WriteLine("Возникло исключение!");
                    }
                }
            }

            // конструктор

            public Build(double height, int floors, int apartments, int entrances)
            {
                this.Height = height;
                this.Floors = floors;
                this.Apartments = apartments;
                this.Entrances = entrances;
                this.Number = count;
                this.Code = base.GetHashCode();               
            }

            public void GetNumber () // инкремент номера здания
            {
                ++count;
            }

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
        //private static HashSet<Build> hashSet = new HashSet<Build>(); вариант с хеш-сетом

        // создание хэш-таблицы
        private static Hashtable builds = new Hashtable();

        // создание здания и добавление записи в хэш-таблицу
        public static void CreateBuild(double height, int floors, int apartments, int entrances)
        {
           Build build = new Build(height, floors, apartments, entrances);
            builds.Add(build.Code, build);                    
        }
        // печать хэш-таблицы
        public static void PrintBuilds()
        {
            foreach(DictionaryEntry b in builds)
            {
                Console.WriteLine($"Хэш код: {b.Key}  Номер здания: {(b.Value as Build).Number}  Высота: {(b.Value as Build).Height}  Количество этажей: {(b.Value as Build).Floors} Количество квартир: {(b.Value as Build).Apartments}  Количество подъездов: {(b.Value as Build).Entrances} ");
                Console.WriteLine();
            }
        }

        // удаление по уникальному номеру
        public static void DeleteBuild(int n)
        {
            Object k = null;
            foreach(DictionaryEntry b in builds)
            {
                if((b.Value as Build).Number ==n)
                {
                    k = b.Key;
                }
            }
            if(k!=null)
            {
                builds.Remove(k);
            }
            else
            {
                Console.WriteLine("Здание с таким номером не найдено и не может быть удалено");
            }

        }
         
        // запрос параметров по номеру здания

        public static void InfoBuild(int n)
        {
            foreach (DictionaryEntry b in builds)
            {
                if ((b.Value as Build).Number == n)
                {
                    Console.WriteLine($"Высота этажа: {(b.Value as Build).HeightFloor()}  Количество квартир в подъезде: {(b.Value as Build).CountApartmentsInEntrance()} " +
                $"Количество квартир на этаже: {(b.Value as Build).CountApartmentsOnFloor()}");
                }
            }
        }
    }

    
}
