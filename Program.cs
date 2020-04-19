

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            float a = 0.0f, b = 0.0f, c = 0.0f;
            double realRoot1 = 0.0, realRoot2 = 0.0, d = 0.0f;
            string charA = " ", charB = " ", charC = " ";
            string chain = " ";

            //Requesting data from the user
            Console.Write(" Enter the cuadratic equation: ");
            chain = Console.ReadLine();

            //Getting coefficients
            charA = chain.Substring(0, 1);
            charB = chain.Substring(3, 2);
            charC = chain.Substring(6, 2);

            a = Convert.ToSingle(charA);
            b = Convert.ToSingle(charB);
            c = Convert.ToSingle(charC);

            //Calculating the discriminant
            d = (b * b) - (4 * a * c);

            //Shows real root
            if(d == 0)
            {
                realRoot1 = -(b) / (2 * a);
                Console.Write(" The real root is: {0} ",realRoot1);
            }
            else
            {
                if (d > 0)
                {
                    realRoot1 = (-(b) +  Math.Sqrt(d)) / (2 * a);
                    Console.Write(" The first real root is: {0} ", realRoot1);

                    realRoot2 = (-(b) - Math.Sqrt(d)) / (2 * a);
                    Console.Write(" The first real root is: {0} ", realRoot2);
                }
                else
                {
                    if (d < 0)
                    {
                       
                        Console.Write(" The cuadratic equation is not real root");
                    }
                }

            }


            Console.ReadKey();
        }
    }
}
