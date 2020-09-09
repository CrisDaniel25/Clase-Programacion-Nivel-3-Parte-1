using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_1.Program_1
{
    class Values_Program_1
    {
        public readonly string Message = "Press enter for continue ...";
        private string Sentence { get; set; }
        public int Count_Total_sentence;
        public int Count_consonants;
        public int Count_vowels;
        public int Count_spaces;
        public char[] vowels = {'a','e','i','o','u'};

        public string GetSentence()
        {
            return Sentence;
        }

        public void SetSentence(string sentence)
        {
           this.Sentence = sentence;
        }

        public void Pause()
        {
            Console.WriteLine(this.Message);
            Console.ReadKey();
        }
    }
}
