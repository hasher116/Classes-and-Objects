using System;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Andrew = new Human(24, "Andrew");
            Human Vasya = new Human {age = 25, name = "Vasya"};
            Andrew.GetInfo();
            Vasya.GetInfo();
        }
    }
    class Human
    {
        public int age = 0;
        public string name = "Andrew";

        public void GetInfo()
        {
            Console.WriteLine($"age={age}\nname={name}");
        }
        public Human()
        {

        }
        public Human(int age)
        {
            this.age = age;
        }
        public Human(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
