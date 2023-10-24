using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Expresiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {

            Console.WriteLine("█████████████████████████████████████");
            Console.WriteLine("█ Programa de expresiones regulares █");
            Console.WriteLine("█████████████████████████████████████");
            Console.WriteLine("█ 1. Validar nombres                █");
            Console.WriteLine("█ 2. Validar numeros telefonicos    █");
            Console.WriteLine("█ 3. Salir                          █");
            Console.WriteLine("█████████████████████████████████████");
            Console.WriteLine("Introduzca una Opcion");
            int Opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca una cadena");
            string Cadena = Console.ReadLine();
            switch (Opcion)
            {
                case 1:
                    url(Cadena);
                break;

                case 2:
                    numero(Cadena);
                break;

                case 3:
                    Exit();
                break;
                
                default:
                    Console.WriteLine("Opcion no valida por favor intente de nuevo");
                    Console.ReadLine();
                    Console.Clear();
                    Menu();
                break;
            }
        }
        public static void url(string Cadena)
        {
            string pattern = "^[A-Z][a-zA-Z]+$";
            Console.Write($"La expresion regular a validar es: {pattern}");
            Console.WriteLine("");
            try
            {
                Console.WriteLine("{0} {1} una cadena valida.",
                              Cadena,
                              Regex.IsMatch(Cadena, pattern, RegexOptions.IgnoreCase)
                                            ? "es" : "no es", TimeSpan.FromMilliseconds(500));
                Console.WriteLine("¿Quiere volver al menu?");
                Console.WriteLine("1 - Si");
                Console.WriteLine("2 - No");
                int Opc = int.Parse(Console.ReadLine());
                
                if (Opc == 1)
                {
                    Menu();
                }
                else
                {
                    Exit();
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                Console.WriteLine("Tiempo excedido {0} segundos coincidentes {1}",
                              e.MatchTimeout, e.Input);
            }
        }
        public static void numero(string Cadena)
        {
            string pattern = "([+52]|)((\\s?[0-9]{3}(-?|\\s?)){2}[0-9]{4}|(\\s?[0-9]{2}(-?|\\s?)){4}[0-9]{2})";
            Console.Write($"La expresion regular a validar es: {pattern}");
            Console.WriteLine("");
            try
            {
                Console.WriteLine("{0} {1} una cadena valida.",
                              Cadena,
                              Regex.IsMatch(Cadena, pattern, RegexOptions.IgnoreCase)
                                            ? "es" : "no es", TimeSpan.FromMilliseconds(500));
                Console.WriteLine("¿Quiere volver al Menu?");
                Console.WriteLine("1 - Si");
                Console.WriteLine("2 - No");
                int Opc = int.Parse(Console.ReadLine());
                if (Opc == 1)
                {
                    Menu();
                }
                else
                {
                    Exit();
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                Console.WriteLine("Tiempo excedido {0} segundos coincidentes {1}",
                              e.MatchTimeout, e.Input);
            }
        }
        public static void Exit()
        {
            Environment.Exit(1);
        }
    }
}