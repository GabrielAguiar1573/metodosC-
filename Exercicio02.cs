using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativMetodo
{
    internal class Exercicio02
    {
        public static void Main(string[] args)
        {
            ImprimirMensagem(); 
        }
        public static void ImprimirMensagem()
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine(frase);
        }
    }
}
