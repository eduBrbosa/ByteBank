using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaTeste = new ContaCorrente(234, 34534509);

            contaTeste.Sacar(-10);

            Console.WriteLine(contaTeste.Saldo);

            Console.ReadLine();

        }
    }
}
