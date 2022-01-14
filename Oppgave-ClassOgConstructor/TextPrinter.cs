using System;

namespace Oppgave_ClassOgConstructor
{
    public class TextPrinter
    {
        private static string Name;

        public TextPrinter(string name)
        {
            Name = name;
        }

        public static void PrintName()
        {
            Name = "Bjarte";
            Console.Write(Name);
        }
        public static void PrintText()
        {
            for (var i = 0; i < 10; i++)
            {
            
                Console.WriteLine("Runde nr " + i);
            }
        }

    }
    
}