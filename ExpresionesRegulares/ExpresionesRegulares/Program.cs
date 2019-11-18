using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            //string frase = "Mi web es http://israjimenez.com";
            //string patron = "https?://(www.)?israjimenez.com";//busqueda de correo electronico
            string frase = "Mi nombre es Israel y mi numero de telefono es (+593)980-640-987";
            string patron = @"\+593";
            //string patron = @"\+593|\+923";//funcion o cuando se quiere buscar un numero de un paiso  de otro
            Regex miRegex = new Regex(patron);
            MatchCollection elMatch = miRegex.Matches(frase);
            if (elMatch.Count > 0) Console.WriteLine("Se ha encontrado numero de telefono de Ecuador");
            else Console.WriteLine("No se ha encontrado numeros");

    */

            string txt = "info@israjimenez.com";

            string re1 = ".*?"; // Non-greedy match on filler
            string re2 = "(@)"; // Any Single Character 1
            string re3 = ".*?"; // Non-greedy match on filler
            string re4 = "(\\.)";   // Any Single Character 2

            Regex r = new Regex(re1 + re2 + re3 + re4, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m = r.Match(txt);
            if (m.Success)
            {
                String c1 = m.Groups[1].ToString();
                String c2 = m.Groups[2].ToString();
                Console.Write("(" + c1.ToString() + ")" + "(" + c2.ToString() + ")" + "\n");
                Console.WriteLine("Email correcto");
            }
            else
            {
                Console.WriteLine("Email no correcto");
            }
            //Console.ReadLine();
        }
    }
}
