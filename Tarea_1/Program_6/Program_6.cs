using System;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System.Linq;
using System.Threading;

namespace Tarea_1.Program_6
{
    class Program_6 : Program_3.Values_Program_3
    {
        public void Exercise_6()
        {
            Console.WriteLine("................................................................¡Welcome to the exercise #6!............................................................................");
            Console.WriteLine("\n6 - Realiza un programa que acepte una URL, determine la cantidad de párrafos e imágenes que contienen estas:\n");

            Console.Write("Insert here the URL what do you want: ");
            var URL = Console.ReadLine();

            HtmlWeb Web = new HtmlWeb();
            HtmlDocument document = Web.Load(URL);

            try
            {
                HtmlNode Imange = document.DocumentNode.CssSelect("img").First();
                var img = Imange.InnerLength;

                HtmlNode Paragraph = document.DocumentNode.CssSelect("p").First();
                var P = Paragraph.InnerLength;

                Console.WriteLine(img);
                Console.WriteLine(P);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("\nTry again....");
                Thread.Sleep(3000);
                Console.Clear();
                Exercise_6();
            }

            Pause();
        }
    }
}
