using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT05
{
    class Data
    {
        public DateTime now = DateTime.Now;
        private int _dia, _mes, _ano;private string _semDia;
        public int Dia              //DIAS
        {
            get
            {
                return _dia;
            }
            set
            {
                if (Mes <= now.Month ||  Ano< now.Year)
                {
                    if (Ano== now.Year && Mes== now.Month && Dia > now.Day) { _dia = 01;  }
                    else
                    {
                        if (Ano% 4 == 0 && (Ano% 400 == 0 || Ano% 100 != 0))
                        {
                            if (Mes== 2)
                            {
                                if (Dia > 0 && Dia < 30){_dia = value;}
                                else { _dia = 01;  }
                            }
                            else
                            {
                                if (Mes<= 7)
                                {
                                    if (Mes% 2 == 0)
                                    {
                                        if (Dia > 0 && Dia < 31) {_dia = value;}
                                        else { _dia = 01;  }
                                    }
                                    else
                                    {
                                        if (Dia > 0 && Dia < 32) {_dia = value;}
                                        else { _dia = 01;  }
                                    }

                                }
                                else
                                {
                                    if (Mes% 2 == 0)
                                    {
                                        if (Dia > 0 && Dia < 32) {_dia = value;}
                                        else { _dia = 01;  }
                                    }
                                    else
                                    {
                                        if (Dia > 0 && Dia < 31) {_dia = value;}
                                        else { _dia = 01;  }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (Mes== 2)
                            {
                                if (Dia > 0 && Dia < 29) {_dia = value;}
                                else { _dia = 01;  }
                            }
                            else
                            {
                                if (Mes<= 7)
                                {
                                    if (Mes% 2 == 0)
                                    {
                                        if (Dia > 0 && Dia < 31) {_dia = value;}
                                        else { _dia = 01;  }
                                    }
                                    else
                                    {
                                        if (Dia > 0 && Dia < 32) {_dia = value;}
                                        else { _dia = 01;  }
                                    }

                                }
                                else
                                {
                                    if (Mes% 2 == 0)
                                    {
                                        if (Dia > 0 && Dia < 32) {_dia = value;}
                                        else { _dia = 01;  }
                                    }
                                    else
                                    {
                                        if (Dia > 0 && Dia < 31) {_dia = value;}
                                        else { _dia = 01;  }
                                    }
                                }
                            }
                        }
                    }
                }
                else { _dia = 01;  }
                GiveDay();
            }
        }
        public int Mes           //MESES
        {
            get
            {
                return _mes;
            }
            set
            {
                if (value<= now.Month || Ano<now.Year)
                {
                    if (Ano== now.Year && value== now.Month && Dia > now.Day) { _dia = 41;  }
                    else
                    {
                        if (Ano% 4 == 0 && (Ano% 400 == 0 || Ano% 100 != 0))
                        {
                            if (value== 2)
                            {
                                if (Dia > 0 && Dia < 30) {_mes = value;}
                                else { _dia = 41;  }
                            }
                            else
                            {
                                if (value<= 7)
                                {
                                    if (value% 2 == 0)
                                    {
                                        if (Dia > 0 && Dia < 31) {_mes = value;}
                                        else { _dia = 41;  }
                                    }
                                    else
                                    {
                                        if (Dia > 0 && Dia < 32) {_mes = value;}
                                        else { _dia = 41;  }
                                    }

                                }
                                else
                                {
                                    if (value% 2 == 0)
                                    {
                                        if (Dia > 0 && Dia < 32) {_mes = value;}
                                        else { _dia = 41;  }
                                    }
                                    else
                                    {
                                        if (Dia > 0 && Dia < 31) {_mes = value;}
                                        else { _dia = 41;  }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (value== 2)
                            {
                                if (Dia > 0 && Dia < 29) {_mes = value;}
                                else { _dia = 41;  }
                            }
                            else
                            {
                                if (value<= 7)
                                {
                                    if (value% 2 == 0)
                                    {
                                        if (Dia > 0 && Dia < 31) {_mes = value;}
                                        else { _dia = 41;  }
                                    }
                                    else
                                    {
                                        if (Dia > 0 && Dia < 32) {_mes = value;}
                                        else { _dia = 41;  }
                                    }

                                }
                                else
                                {
                                    if (value% 2 == 0)
                                    {
                                        if (Dia > 0 && Dia < 32) {_mes = value;}
                                        else { _dia = 41;  }
                                    }
                                    else
                                    {
                                        if (Dia > 0 && Dia < 31) {_mes = value;}
                                        else { _dia = 41;  }
                                    }
                                }
                            }
                        }
                    }
                }
                else { _dia = 41;  }
                if (Dia != 0)
                {
                    GiveDay();
                }
            }
        }
        public int Ano          //ANOS
        {
            get
            {
                return _ano;
            }
            set
            {
                if (value <= now.Year)
                {
                    _ano = value; 
                }
                if (Mes != 0)
                {
                    GiveDay();
                }
            }
        }
        public string SEMDia
        {
            get
            {
                return _semDia;
            }
            set
            {
                string dia = GiveDay();
                if (String.Compare(value, dia, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase) == 0)
                    _semDia = dia;
                else
                    _semDia = "Wrong Day";
            }
        }
        public Data()
        {
            Dia = 1;
            Mes = 1;
            Ano = 2000;
        }
        public Data(int d,int m,int a)
        {
            
            _dia = d;_mes = m;_ano = a;
            Ano = a;
            Mes = m;
            Dia = d;
            
        }
        public Data(Data d)
        {
            Dia = d.Dia;Mes = d.Mes;Ano = d.Ano;
        }
        public int Idade(DateTime now)
        {
            if (Mes > now.Month)
                return now.Year - Ano - 1;
            else if (Mes == now.Month)
            {
                if (Dia > now.Day)
                    return now.Year - Ano - 1;
                else
                    return now.Year - Ano;
            }
            else
                return now.Year - Ano - 1; ;
        }
        public string GiveDay()
        {
            int a = Ano, anoC, mesC, centC;
            switch (Mes)
            {
                case 1: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 0; break;
                case 2: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 3; break;
                case 3: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 3; break;
                case 4: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 6; break;
                case 5: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 1; break;
                case 6: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 4; break;
                case 7: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 6; break;
                case 8: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 2; break;
                case 9: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 5; break;
                case 10: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 0; break;
                case 11: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 3; break;
                case 12: anoC = (Ano % 100 + ((Ano % 100) / 4)) % 7; mesC = 5; break;
                default: mesC = -1; anoC = -1; break;
            }
            if (Ano >= 2300 || (Ano >= 1900 && Ano < 2000))
                centC = 0;
            else if (Ano >= 2200 || (Ano >= 1800 && Ano < 1900))
                centC = 2;
            else if (Ano >= 2100 || (Ano >= 1700 && Ano < 1800))
                centC = 4;
            else
                centC = 6;
            if (Ano % 4 == 0 && (Ano % 400 == 0 || Ano % 100 != 0))
                mesC--;
            string[] semana = new string[7] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
            if (Mes < 3)
                a -= 1;
            int ptr = (anoC + mesC + centC + Dia) % 7;
            return semana[ptr];
        }
        public override string ToString()
        {
            return ("\n"+SEMDia+", dia "+Dia+" de "+CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Mes)+" de "+Ano); 
        }
        public string ToStringShort()
        {
            return (Dia + "/" + Mes + "/" + Ano);
        }
    }
}
