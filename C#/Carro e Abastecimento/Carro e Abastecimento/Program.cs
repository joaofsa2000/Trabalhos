using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro_e_Abastecimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("13-45-dg", "Gasoleo", 24, 2004);
            c1.addAbast(new Abastecimento(30, 27, 300, c1));
            Console.WriteLine(c1.listaString());
            Console.WriteLine("\n\n" + c1.calConsumoMedio()+"\n\n"+c1.totalGastoEmCombustivel()+"\n\n"+c1.listaAbast[0].calcPrecoLitro().ToString("n2"));
        }
    }
}
