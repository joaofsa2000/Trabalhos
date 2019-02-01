using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponto
{
    public class Ponto
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Ponto()
        {
            this.X = 0;this.Y = 0;
        }
        public Ponto(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public Ponto(Ponto p)
        {
            X = p.X;
            Y = p.Y;
        }
        public override string ToString()
        {
            return "Ponto(" + X + "," + Y + ")";
        }
        public double pointDist(Ponto p)
        {
            return Math.Sqrt(Math.Pow(this.X + p.X, 2) + Math.Pow(this.Y + p.Y, 2));

        }

    }
}
