using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PROOP
{
    internal class Circle
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <=0)
                {
                    Console.WriteLine("Ошикбка, некоректное значение!");
                }
                else
                {
                    radius  = value;
                } 
            }
        }
        public Circle(double value)
        {
            Radius = value;
        }

        public void GetArea ()
        {
            if(radius >0)
            {
                Console.WriteLine( $"Площадь круга = { Math.PI* radius *radius} ");
            }
        }
    }
}
