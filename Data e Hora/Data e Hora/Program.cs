using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_Hora
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime pres = DateTime.Now;
            Hora h = new Hora(22, 22, 22);
            Data d = new Data(29, 2, 2018);
            int age = d.Idade(pres);
            Console.WriteLine(d.ToString());
            
        }
    }
}
