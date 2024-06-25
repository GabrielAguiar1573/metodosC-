using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativMetodo
{
    internal class Exercicio03
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int valor01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valor02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("A soma dos valores é: ");
            Console.Write(Somar(valor01,valor02));
        }
        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
