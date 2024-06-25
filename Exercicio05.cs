using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativMetodo
{
    internal class Exercicio05
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("O maior valor é: ");
            Console.Write(MaiorNumero(n1, n2));
        }


        public static int MaiorNumero(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                if(n1 < n2)
                {
                    return n2;
                }
                return n1 = n2;
            }
        }
    }
}
