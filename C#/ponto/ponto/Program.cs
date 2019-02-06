using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponto
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(3, 6);
            Ponto p2 = new Ponto(7, 9);
            Console.WriteLine(p1.ToString() + "\n" + p2.ToString());
            Reta r = new Reta(p1, p2);
            Console.WriteLine(r.ToString());
        }
    }
}
