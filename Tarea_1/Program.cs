using System;
using System.Threading;

namespace Tarea_1
{
    class Program
    {
        public static string Menu = "\t\ta) Program #1 | b) Program #2 | c) Program #3 | d) Program #4" +
            "| e) Program #5 | f) Program #6 | g) Program #7 | x) Exit ";
        public static char Selection;

        public static void ResetDisplay()
        {
            Console.Clear();
        }
        
        static void Main()
        {

            Console.WriteLine("...............................................¡Welcome to homework #1 made by Cristopher Figueroa enrollment 2018-6186!................................................");
            Console.WriteLine("\n\t\t\t\t\t\t\t\tPick one of all this option:\n\n" + Menu);

            try
            {
                Console.Write("\n\n ■ Enter one of the available options: ");
                Selection = Convert.ToChar(Console.ReadLine().ToLower());
            }
            catch (Exception ex)
            {
                Console.WriteLine("You should to introduce once character in the same time " + ex);
                Console.WriteLine("\nTry again....");
                Thread.Sleep(3000);
                ResetDisplay();
                Main();
            }

            switch (Selection)
            {
                case 'a':
                    Program_1.Program_1 Exercise_1 = new Program_1.Program_1();
                    Exercise_1.Exercise_1();
                    ResetDisplay();
                    Main();
                    break;
                case 'b':
                    Program_2.Program_2 Exercise_2 = new Program_2.Program_2();
                    Exercise_2.Exercise_2();
                    ResetDisplay();
                    Main();
                    break;
                case 'c':
                    Program_3.Program_3 Exercise_3 = new Program_3.Program_3();
                    Exercise_3.Exercise_3();
                    ResetDisplay();
                    Main();
                    break;
                case 'd':
                    Program_4.Program_4 Excercise_4 = new Program_4.Program_4();
                    Excercise_4.Exercise_4();
                    ResetDisplay();
                    Main();
                    break;
                case 'e':
                    Program_5.Program_5 Excercise_5 = new Program_5.Program_5();
                    Excercise_5.Exercise_5();
                    ResetDisplay();
                    Main();
                    break;
                case 'f':
                    Program_6.Program_6 Excercise_6 = new Program_6.Program_6();
                    Excercise_6.Exercise_6();
                    ResetDisplay();
                    Main();
                    break;
                case 'g':
                    Program_7.Program_7 Excercise_7 = new Program_7.Program_7();
                    Excercise_7.Exercise_7();
                    ResetDisplay();
                    Main();
                    break;
                case 'x':
                    Console.WriteLine("\nThanks... you should will be back, see you later <3");
                    Thread.Sleep(3000);
                    break;
                default:
                    Console.WriteLine("\nThe option what you pick isn't available... try again thanks <3");
                    Thread.Sleep(3000);
                    ResetDisplay();
                    Main();
                    break;
            }

        }
    }
}
