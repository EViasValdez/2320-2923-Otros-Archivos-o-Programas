using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace WebScraping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Lista = new List<string>();
            
            HtmlWeb Web = new HtmlWeb();
            HtmlDocument Doc = Web.Load("https://www.ionos.mx/digitalguide/paginas-web/desarrollo-web/aprende-html-tutorial-para-principiantes/");

            foreach (var Nodo in Doc.DocumentNode.CssSelect(".article--content"))
            {
                var NodoAncho = Nodo.CssSelect("p").First();
                Lista.Add(NodoAncho.InnerHtml);
            }
            String Search = @"[¿][A-Za-z áéíóú]*[?]";
            foreach (var Item in Lista)
            {
                Console.WriteLine($"Resultado {Item}");
                MatchCollection Matches = Regex.Matches(Item, Search);
                foreach (Match m in Matches)
                {
                    Console.WriteLine($"Se ha seleccionado {m}");
                }
            }
        }
    }
}