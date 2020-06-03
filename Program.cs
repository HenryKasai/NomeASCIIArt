using System;
using Figgle;

namespace NomeASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Olá usuário! Por favor digite seu nome");
            string nome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(FiggleFonts.Fraktur.Render(nome));
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
