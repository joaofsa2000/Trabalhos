using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_Hora
{
    public class Hora
    {
        private int _hora, _minuto, _segundo;
        public int Horas
        {
            get
            {
                return _hora;  
            }
            set
            {
                if (value >= 0 && value <= 23)
                    _hora = value;
                else
                    _hora = 0;
            }
        }
        public int Minutos
        {
            get
            {
                return _minuto;
            }
            set
            {
                if (value >= 0 && value <= 59)
                    _minuto = value;
                else
                    _minuto = 0;
            }
        }
        public int Segundos
        {
            get
            {
                return _minuto;
            }
            set
            {
                if (value >= 0 && value <= 59)
                    _segundo = value;
                else
                    _segundo = 0;
            }
        }

        public Hora()
        {
            Segundos = 0;
            Minutos = 0;
            Horas = 0;
        }
        public Hora(int h,int m,int s)
        {
            Segundos = s;
            Minutos = m;
            Horas = h;
        }
        public Hora(Hora h)
        {
            Segundos = h.Segundos;
            Minutos = h.Minutos;
            Horas = h.Horas;
        }
        public Hora DifEntre2Horas(Hora h)
        {
            Hora diff = new Hora();
            if (Horas >= h.Horas)
                diff.Horas = h.Horas + 24 - Horas;
            else
                diff.Horas = h.Horas - Horas;
            if (h.Minutos >= Minutos)
                diff.Minutos = h.Minutos - Minutos;
            else
            {
                diff.Minutos = 60 - Minutos + h.Minutos;
                diff.Horas--;
            }
            if (h.Segundos >= Segundos)
                diff.Segundos = h.Segundos - Segundos;
            else
            {
                diff.Segundos = 60 - Segundos + h.Segundos;
                diff.Minutos--;
            }
            return diff;
        }
        public override string ToString()
        {
            return "\nHora: " + Horas + ":" + Minutos + ":" + Segundos;
        }
    }

}
