using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT05
{
    class Gerente : Funcionario
    {
        public Gerente()
        {
            Id = 0;
            Nome = "sem nome";
            DataNasc = new Data();
            EMail = "a@a.a";
            ValorHora = 0;
            Especialidade = "sem especialidade";
            Extensao = 0;
        }
        public Gerente(int id,string n,int d,int m,int a,string mail,double vh,string esp,int ext)
        {
            Id = id;
            Nome = n;
            DataNasc = new Data(d, m, a);
            EMail = mail;
            ValorHora = vh;
            Especialidade = esp;
            Extensao = ext;
        }
        public Gerente(Gerente g)
        {
            Id = g.Id;
            Nome = g.Nome;
            DataNasc = new Data(g.DataNasc);
            EMail = g.EMail;
            ValorHora = g.ValorHora;
            Especialidade = g.Especialidade;
            Extensao = g.Extensao;
        }
        public string Especialidade { get; set; }
        public int Extensao { get; set; }
        public override string ToString()
        {
            return Id.ToString("D2") + " " + Nome + " " + DataNasc.ToStringShort() + " " + EMail + " " + ValorHora + " " + Especialidade + " " + Extensao.ToString("D3");
        }
        public string FichString()
        {
            return Id + "," + Nome + "," + DataNasc.Dia + "," + DataNasc.Mes + "," + DataNasc.Ano + "," + EMail + "," + ValorHora + "," + Especialidade + "," + Extensao;
        }
    }
}
