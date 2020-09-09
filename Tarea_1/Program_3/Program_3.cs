using System;
using System.Collections.Generic;
using System.Threading;

namespace Tarea_1.Program_3
{
    class Program_3 : Values_Program_3
    {
        public void Exercise_3()
        {
            
            Console.WriteLine("................................................................¡Welcome to the exercise #3!............................................................................");
            Console.WriteLine("\n3 - Programa que acepte un numero de teléfono, determine si tiene todos los dígitos que contiene tu matricula, no necesariamente en el mismo orden. Si no los contiene, favor de especificar cuales estan presentes:");

            Console.Write("\n\n ■ Write a phone number by 11 digit for begun the process: ");
            try
            {
                long phone_number = Convert.ToInt64(Console.ReadLine());
                array(phone_number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("\nTry again....");
                Thread.Sleep(3000);
                Console.Clear();
                Exercise_3();
            }

            Console.Write("Match: ");

            for (int i = 0; i < Enrollment.Length; i++)
            {
                for(int j = 0; j < PhoneNumber.Length; j++)
                {
                    if(PhoneNumber[j] == Enrollment[i])
                    {
                        Console.Write(" " + PhoneNumber[j] + " | ");
                    }
                }
            }
            Console.Write("\nPhone number: ");
            for (int e = 0; e < PhoneNumber.Length; e++)
            {
                Console.Write(PhoneNumber[e] + " | ");
            }
            Console.WriteLine("\nEnrollment: 2018-6186");
            Pause();
        }
    }
}
