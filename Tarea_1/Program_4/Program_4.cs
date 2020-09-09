using System;
using System.Collections.Generic;
using System.Threading;

namespace Tarea_1.Program_4
{
    class Program_4: Program_1.Values_Program_1
    {
        public Int32[] Sides = new Int32[3];
        public void Exercise_4()
        {
            Console.WriteLine("................................................................¡Welcome to the exercise #4!............................................................................");
            Console.WriteLine("\n4 - Programa que acepte las medidas de los lados de un triangulo determine el tipo de triangulo según sus lados.");

            int i = 0;
            try
            {
                foreach (int e in Sides)
                {
                    Console.Write("\n\n ■ Introduce the value for side " + i + ": ");
                    Sides[i] = Convert.ToInt32(Console.ReadLine());
                    i++;

                }

                Condition();
                Pause();
            }
            catch (Exception ex)
            {
                Console.WriteLine("You should to introduce only intenger " + ex);
                Console.WriteLine("\nTry again....");
                Thread.Sleep(3000);
                Console.Clear();
                Exercise_4();
            }
        }

        public void Condition()
        {
            if (Sides[0] == Sides[1] && Sides[0] == Sides[2] && Sides[1] == Sides[2])
            {
                Console.WriteLine("\n- It's an equilateral triangle\n" +
                    "Side A: " + Sides[0]+ " | Side B: " + Sides[1] + " | Side C: " + Sides[2]);
            }
            else if (Sides[0] == Sides[1] || Sides[0] == Sides[2] || Sides[1] == Sides[2])
            {
                Console.WriteLine("\n- It's an isosceles triangle\n" +
                    "Side A: " + Sides[0] + " | Side B: " + Sides[1] + " | Side C: " + Sides[2]);
            }
            else
            {
                Console.WriteLine("\n- It's an scalene triangle\n" +
                    "Side A: " + Sides[0] + " | Side B: " + Sides[1] + " | Side C: " + Sides[2]);
            }
        }
    }
}
