using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FT05
{
    class Funcionario
    {
        protected int _id;
        protected string _eMail;
        protected double _valorHora;
        public Data DataNasc { get; set; }
        public int Id
        {
            get { return _id; }
            set
            {
                if (value >= 0)
                    _id = value;
            }
        }
        public string Nome { get; set; }
        public string EMail
        {
            get { return _eMail; }
            set
            {
                if (new EmailAddressAttribute().IsValid(value))
                    _eMail = value;
                else
                    _eMail = "a@a.a";
            }
        }
        public double ValorHora
        {
            get
            {
                return _valorHora;
            }
            set
            {
                if (value >= 0)
                    _valorHora = value;
            }
        }
        public double CalSal(double he)
        {
            return he * ValorHora;
        }

    }
}
