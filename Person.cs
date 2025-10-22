using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PROOP
{
    internal class Person
    {
        private int age;
        private string name;

        public int Age { 
            get { return age; }
            set 
            {
                if (value >= 0 && value < 120)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                    Console.WriteLine("Ошибка, некоректное значение!")
                }
            } 
        }
        public string Name {
            get { return name; }
            set { name = value; } 
        }   

        public Person(int age, string name) 
        {
            Age = age;
            Name = name;
        }

        public void SayHello()
        {
            Console.WriteLine($"Привет, я {name}, мне {age} лет!»");
        }
    }
}
