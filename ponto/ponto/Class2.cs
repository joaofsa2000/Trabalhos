using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponto
{
    public class Reta
    {
        public Ponto P1 { get; set; }
        public Ponto P2 { get; set; }

        public Reta()
        {
            P1.X = 0; P1.Y = 0;
            P2.X = 0; P2.Y = 0;
        }
        public Reta(Ponto pa, Ponto pb)
        {
            this.P1 = pa;
            this.P2 = pb;
        }
        public Reta(Reta r)
        {
            P1 = r.P1;
            P2 = r.P2;
        }
        public override string ToString()
        {
            return "Reta:\n Ponto 1:(" + P1.X + "," + P1.Y + ")\n Ponto 2:(" + P2.X + "," + P2.Y + ")";
        }
    }
}
