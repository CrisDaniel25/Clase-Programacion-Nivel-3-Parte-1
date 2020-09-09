using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_1.Program_2
{
    class Program_2 : Values_Program_2
    {
        public void Exercise_2()
        {
            Console.WriteLine("................................................................¡Welcome to the exercise #2!............................................................................");
            Console.WriteLine("\n2 - Programa que se ejecute y presionando enter muestre tus datos de contacto: matricula, nombre, apellido, telefono y correo:\n");

            Console.WriteLine(Message);
            Pause();
            Console.WriteLine("\n* Name: " + Name);
            Console.WriteLine("\n\t" + Message);
            Pause();
            Console.WriteLine("\n* Last Name: " + Last_Name);
            Console.WriteLine("\n\t" + Message);
            Pause();
            Console.WriteLine("\n* Enrollment: " + Enrollment);
            Console.WriteLine("\n\t" + Message);
            Pause();
            Console.WriteLine("\n* Contact: " + Contact);
            Console.WriteLine("\n\t" + Message);
            Pause();
            Console.WriteLine("\n* School Mail: " + Mail + "\n\n\tEnd you can press enter for going to Menu again....");
            Pause();
        }
    }
}
