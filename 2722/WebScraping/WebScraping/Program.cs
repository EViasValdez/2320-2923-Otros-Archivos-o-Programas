using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace webscraping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.ionos.mx/digitalguide/paginas-web/desarrollo-web/aprende-html-tutorial-para-principiantes/");

            foreach (var nodo in doc.DocumentNode.CssSelect(".article--content"))
            {
                var nodoancho = nodo.CssSelect("p").First();
                lista.Add(nodoancho.InnerHtml);
            }
            String search = @"[¿][A-Za-z áéíóú]*[?]";
            foreach (var item in lista)
            {
                Console.WriteLine($"Resultado {item}");
                MatchCollection matches = Regex.Matches(item, search);
                foreach (Match m in matches)
                {
                    Console.WriteLine($"Se ha seleccionado {m}");
                }
            }
        }
    }
}