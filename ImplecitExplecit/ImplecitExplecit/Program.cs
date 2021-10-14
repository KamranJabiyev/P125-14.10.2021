using System;

namespace ImplecitExplecit
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            //Area area;
            //area.Length = 20;
            //area.Width = 10;
            #endregion

            #region Upcasting,boxing,implicit
            //Shark shark = new Shark();
            //Animal shark1 = shark;
            //Eagle eagle = new Eagle();
            //Animal[] animals = { shark, shark1, eagle };
            //foreach (var item in animals)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            #endregion

            #region Downcasting,unboxing,explicit
            //Animal animal1 = new Shark();
            //Shark shark = (Shark)animal1;
            //object[] arr = { 12, true, "Salam", shark, 10.3f, animal1 };
            //foreach (var item in arr)
            //{
            //    #region Downcating security way-2(as)
            //    //Shark s = item as Shark;
            //    //if (s != null)
            //    //{
            //    //    s.Swim();
            //    }
            //    #endregion
            //    #region Downcating security way-1(is)
            //    //if(item is Shark s)
            //    //{
            //    //    s.Swim();
            //    //}
            //    #endregion
            //}
            #endregion

            #region Implicit&Explicit
            Manat manat = new Manat(774.1);
            Dollar dollar = manat;
            //Console.WriteLine(dollar.Usd);
            #endregion

            #region Operator overloading
            Person p1 = new Person("Khanish","Elesgerov",16);
            Person p2 = new Person("Khanish", "Elesgerov", 16);
            int a = 5;
            int b = 6;
            Console.WriteLine(p1>p2);
            #endregion
        }
    }

    #region Operator overloading
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public static bool operator >(Person p1,Person p2)
        {
            return p1.Age > p2.Age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
    }
    #endregion

    #region Implicit&Explicit
    class Manat
    {
        public double Azn { get; set; }
        public Manat(double azn)
        {
            Azn = azn;
        }

        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7);
        }
    }
    class Dollar
    {
        public double Usd { get; set; }
        public Dollar(double usd)
        {
            Usd = usd;
        }
    }
    #endregion

    #region Casting
    abstract class Animal
    {
        public abstract void Eat();
        public override string ToString()
        {
            return "Animal";
        }
    }

    abstract class Fish:Animal
    {
        public abstract void Swim();
    }

    class Shark : Fish
    {
        public int TeethCount { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }

        public override string ToString()
        {
            return "Shark";
        }
    }

    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }

        public override string ToString()
        {
            return "Eagle";
        }
    }
    #endregion

    #region Struct
    //struct Area
    //{
    //    public double Width;
    //    public double Length;
    //    public int MyProperty { get; set; }
    //    public Area(int width, int length)
    //    {
    //        Width = width;
    //        Length = length;
    //        MyProperty = 10;
    //    }
    //}
    #endregion
}
