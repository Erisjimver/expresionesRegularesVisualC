using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string frase = "Mi nombre es Israel y mi numero de telefono es (+593)980-640-987";
            string patron = @"\+593";
            Regex miRegex = new Regex(patron);
            MatchCollection elMatch = miRegex.Matches(frase);
            if (elMatch.Count > 0) Console.WriteLine("Se ha encontrado numero de telefono de Ecuador");
            else Console.WriteLine("No se ha encontrado numeros");
        }
    }
}
