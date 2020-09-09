using System;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System.Linq;

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

            HtmlNode Imange = document.DocumentNode.CssSelect("img").First();
            var img = Imange.InnerLength;

            HtmlNode Paragraph = document.DocumentNode.CssSelect("p").First();
            var P = Paragraph.InnerLength;

            Console.WriteLine(img);
            Console.WriteLine(P);

            Pause();
        }
    }
}
