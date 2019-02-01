using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT05
{
    class Operario : Funcionario
    {
        public Operario()
        {
            Id = 0;
            Nome = "sem nome";
            DataNasc = new Data();
            EMail = "a@a.a";
            ValorHora = 0;
            Departamento = "sem departamento";
        }
        public Operario(int id, string n, int d, int m, int a, string mail, double vh, string dep)
        {
            Id = id;
            Nome = n;
            DataNasc = new Data(d, m, a);
            EMail = mail;
            ValorHora = vh;
            Departamento = dep;
        }
        public Operario(Operario p)
        {
            Id = p.Id;
            Nome = p.Nome;
            DataNasc = new Data(p.DataNasc);
            EMail = p.EMail;
            ValorHora = p.ValorHora;
            Departamento = p.Departamento;
        }
        public string Departamento { get; set; }
        public override string ToString()
        {
            return Id.ToString("D2") + " " + Nome + " " + DataNasc.ToStringShort() + " " + EMail + " " + ValorHora + " " + Departamento;
        }
        public string FichString()
        {
            return Id + "," + Nome + "," + DataNasc.Dia + "," + DataNasc.Mes + "," + DataNasc.Ano + "," + EMail + "," + ValorHora + "," +Departamento;
        }
    }
}
