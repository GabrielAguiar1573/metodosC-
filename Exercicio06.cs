using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativMetodo
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("O valor é par? ");
            Console.WriteLine(EhPar(n1));
        }

        public static bool EhPar(int n1)
        {
            if (n1 % 2 == 0)
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }
    }
}
