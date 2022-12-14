using System;
using System.Text.RegularExpressions;

namespace Expresiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        public static void menu()
        {

            Console.WriteLine("█████████████████████████████████████");
            Console.WriteLine("█ Programa de expresiones regulares █");
            Console.WriteLine("█████████████████████████████████████");
            Console.WriteLine("█ 1. Validar nombres                █");
            Console.WriteLine("█ 2. Validar numeros telefonicos    █");
            Console.WriteLine("█ 3. Salir                          █");
            Console.WriteLine("█████████████████████████████████████");
            Console.WriteLine("Introduzca una opcion");
            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca una cadena");
            string cadena = Console.ReadLine();
            switch (opcion)
            {
                case 1:
                    url(cadena);
                break;

                case 2:
                    numero(cadena);
                break;

                case 3:
                    exit();
                break;
                
                default:
                    Console.WriteLine("Opcion no valida por favor intente de nuevo");
                    Console.ReadLine();
                    Console.Clear();
                    menu();
                break;
            }
        }
        public static void url(string cadena)
        {
            string pattern = "^[A-Z][a-zA-Z]+$";
            Console.Write($"La expresion regular a validar es: {pattern}");
            Console.WriteLine("");
            try
            {
                Console.WriteLine("{0} {1} una cadena valida.",
                              cadena,
                              Regex.IsMatch(cadena, pattern, RegexOptions.IgnoreCase)
                                            ? "es" : "no es", TimeSpan.FromMilliseconds(500));
                Console.WriteLine("¿Quiere volver al menu?");
                Console.WriteLine("1 - Si");
                Console.WriteLine("2 - No");
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    menu();
                }
                else
                {
                    exit();
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                Console.WriteLine("Tiempo excedido {0} segundos coincidentes {1}",
                              e.MatchTimeout, e.Input);
            }
        }
        public static void numero(string cadena)
        {
            string pattern = "([+52]|)((\\s?[0-9]{3}(-?|\\s?)){2}[0-9]{4}|(\\s?[0-9]{2}(-?|\\s?)){4}[0-9]{2})";
            Console.Write($"La expresion regular a validar es: {pattern}");
            Console.WriteLine("");
            try
            {
                Console.WriteLine("{0} {1} una cadena valida.",
                              cadena,
                              Regex.IsMatch(cadena, pattern, RegexOptions.IgnoreCase)
                                            ? "es" : "no es", TimeSpan.FromMilliseconds(500));
                Console.WriteLine("¿Quiere volver al menu?");
                Console.WriteLine("1 - Si");
                Console.WriteLine("2 - No");
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    menu();
                }
                else
                {
                    exit();
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                Console.WriteLine("Tiempo excedido {0} segundos coincidentes {1}",
                              e.MatchTimeout, e.Input);
            }
        }
        public static void exit()
        {
            Environment.Exit(1);
        }
    }
}