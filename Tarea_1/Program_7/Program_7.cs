using System;
using System.Collections.Generic;

namespace Tarea_1.Program_7
{
    class Program_7 : Values_Program_7
    {
        public void Exercise_7()
        {
            Console.WriteLine("................................................................¡Welcome to the exercise #7!............................................................................");
            Console.WriteLine("\n7 - Programa que acepte una calificación (0 a 100), calcule el equivalente literal de la misma y una posible distribución para el siguiente esquema: 40, 30, 30. Ejemplo si digitamos 90 el programa mostrara A => 31, 29 , 30:\n");

            Random Calculate = new Random();

            while(qualification != 100)
            {
                accumulated_1 = Calculate.Next(100);
                accumulated_2 = Calculate.Next(100);
                accumulated_3 = Calculate.Next(100);
                qualification = accumulated_1 + accumulated_2 + accumulated_3;
            }

            Console.WriteLine("\n\t | Parcial 1 = " + accumulated_1 + "\n\t | Parcial 2 = " + accumulated_2 
                + "\n\t | Final 3 = " + accumulated_3 + "\n\t | Total qualification = " + qualification + "\n");
            Pause();
           
        }
    }
}
