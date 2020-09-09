using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Tarea_1.Program_5
{
    class Program_5 : Values_Program_5
    {
        public void Exercise_5()
        {
            Console.WriteLine("................................................................¡Welcome to the exercise #5!............................................................................");
            Console.WriteLine("\n5 - Programa que acepte nombre, apellido y teléfono de una persona. Generar un archivo HTML bonito que contenga estos datos:\n");

            if(Directory.Exists(Path) == false)
            {
                Directory.CreateDirectory(Path);
            }

            Console.Write("\n\n ■ Write your name: ");
            Name = Console.ReadLine();
            Console.Write("\n\n ■ Write your last name: ");
            Last_Name = Console.ReadLine();
            Console.Write("\n\n ■ Write your phone number: ");
            Phone_Number = Console.ReadLine();

            try
            {
                File.WriteAllText(Path + "\\" + "Content" + ".html", HTML());
                Console.WriteLine("\n\tDocument was created successful\n");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("\nTry again....");
                Thread.Sleep(3000);
                Console.Clear();
                Exercise_5();
            }
            
            Pause();
        }
    }
}
