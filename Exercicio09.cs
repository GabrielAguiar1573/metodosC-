using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativMetodo
{
    internal class Exercicio09
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a primeira palavra: ");
            string text01 = Console.ReadLine();
            Console.WriteLine("Digite a segunda palavra: ");
            string text02 = Console.ReadLine();
            Console.WriteLine(ConcatenarStrings(text01, text02));
        }
        public static string ConcatenarStrings(string text01, string text02)
        {
            return text01 + text02;
        }
    }
}
