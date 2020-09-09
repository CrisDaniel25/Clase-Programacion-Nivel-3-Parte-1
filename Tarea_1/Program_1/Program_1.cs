using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_1.Program_1
{
    class Program_1 : Values_Program_1
    {
        public void Exercise_1()
        {
            Console.WriteLine("................................................................¡Welcome to the exercise #1!............................................................................");
            Console.WriteLine("\n1 - Programa que acepte una frase u oración, luego muestre la cantidad de vocales, espacios y consonantes que tiene la misma:");
        
            Console.Write("\n\n ■ Write a sentence for begun the process: ");
            SetSentence(Console.ReadLine().ToLower());
            var written = GetSentence();
            Count_Total_sentence = written.Length;

            Method_Program_1(written);

            Console.Write(" We have:" + "\n * " + Count_vowels + " - Vowels." + "\n * " + Count_consonants 
                + " - Consonants." + "\n * " + Count_spaces + " - Spaces." + "\n * " + Count_Total_sentence 
                + " - Total sentence." + "\n");
            Pause();
        }

        public void Method_Program_1(string Message)
        {
            var sentence = Message; 
            for (int Count = 0; Count < sentence.Length; Count++)
            {
                var Array = sentence.ToCharArray(0, sentence.Length);

                if (Array[Count] < 'a' || Array[Count] > 'z')
                {
                    Count_spaces++;
                }
                else if (Array[Count] == vowels[0] || Array[Count] == vowels[1] ||
                    Array[Count] == vowels[2] || Array[Count] == vowels[3] || Array[Count] == vowels[4])
                {
                    Count_vowels++;
                }
                else
                {
                    Count_consonants++;
                }
            }
        }
    }
}
