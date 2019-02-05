using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Carro_e_Abastecimento
{
    class Carro
    {
        protected string _matricula, _tipoCombustivel;
        protected double _kmIniciais;
        protected int _ano;
        public List<Abastecimento> listaAbast;
        public Carro()
        {
            Matricula = null;
            TipoCombustivel = null;
            Ano = 1900;
            listaAbast = new List<Abastecimento>();
            KmInicias = 0.0;
        }
        public Carro(string mat, string tipoComb, double kmInic, int ano)
        {

            TipoCombustivel = tipoComb;
            KmInicias = kmInic;
            listaAbast = new List<Abastecimento>();
            Ano = ano;
            Matricula = mat;
        }
        public Carro(Carro car)
        {
            Matricula = car.Matricula;
            TipoCombustivel = car.TipoCombustivel;
            Ano = car.Ano;
            listaAbast = new List<Abastecimento>(car.listaAbast);
            KmInicias = car.KmInicias;

        }
        public int Ano
        {
            get
            {
                return _ano;
            }
            set
            {
                bool flag;
                do
                {
                    if (value > 1949)
                    {
                        _ano = value;
                        flag = true;
                    }
                    else
                    {
                        Console.Write("Insira um ano válido:");
                        do
                        {
                            try
                            {
                                value = int.Parse(Console.ReadLine());
                                flag = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Apenas números são aceites");
                                flag = false;
                            }
                        } while (!flag);
                        flag = false;
                    }
                } while (!flag);
            }
        }
        public string Matricula
        {
            get
            {
                return _matricula;
            }
            set
            {
                bool flag = false;
                do
                {
                    if (Ano < 1992)
                    {
                        if (new Regex(@"[a-zA-z][a-zA-z]-\d{2}-\d{2}").IsMatch(value))
                        {
                            _matricula = value;
                            flag = true;
                            Console.WriteLine("A matricula {0} foi adicionada com sucesso!\n", value);
                        }
                        else
                        {
                            Console.Write("Matricula inválida, insira a matricula correta:");
                            flag = false;
                            value = Console.ReadLine();
                        }
                    }
                    else if (Ano >= 1992 && Ano < 2005)
                    {
                        if (new Regex(@"\d{2}-\d{2}-[a-zA-z][a-zA-z]").IsMatch(value))
                        {
                            _matricula = value;
                            flag = true;
                            Console.WriteLine("A matricula {0} foi adicionada com sucesso!\n", value);
                        }
                        else
                        {
                            Console.Write("Matricula inválida, insira a matricula correta:");
                            flag = false;
                            value = Console.ReadLine();
                        }
                    }
                    else if (Ano >= 2005)
                    {
                        if (new Regex(@"\d{2}-[a-zA-z]{2}-\d{2}").IsMatch(value))
                        {
                            _matricula = value;
                            flag = true;
                            Console.WriteLine("A matricula {0} foi adicionada com sucesso!\n", value);
                        }
                        else
                        {
                            Console.Write("Matricula inválida, insira a matricula correta:");
                            flag = false;
                            value = Console.ReadLine();
                        }
                    }
                } while (!flag);
            }
        }
        public double KmInicias
        {
            get
            {
                return _kmIniciais;
            }
            set
            {
                if (value >= 0)
                    _kmIniciais = value;
            }
        }
        public string TipoCombustivel
        {
            get
            {
                return _tipoCombustivel;
            }
            set
            {
                if (string.Compare(value, "gasoleo", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) == 0)
                {
                    _tipoCombustivel = "Gasóleo";
                    Console.WriteLine(_tipoCombustivel+" adicionado com sucesso!\n\n");
                }
                else if (string.Compare(value, "gasolina", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) == 0)
                {
                    _tipoCombustivel = "Gasolina";
                    Console.WriteLine(_tipoCombustivel + " adicionado com sucesso!\n\n");
                }
                else if (string.Compare(value, "GPL", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) == 0)
                {
                    _tipoCombustivel = "GPL";
                    Console.WriteLine(_tipoCombustivel + " adicionado com sucesso!\n\n");
                }
                else if (string.Compare(value, "Diesel", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) == 0)
                {
                    _tipoCombustivel = "Diesel";
                    Console.WriteLine(_tipoCombustivel + " adicionado com sucesso!\n\n");
                }
                else if (string.Compare(value, "Bio Diesel", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) == 0)
                {
                    _tipoCombustivel = "Bio Diesel";
                    Console.WriteLine(_tipoCombustivel + " adicionado com sucesso!\n\n");
                }
                else
                    _tipoCombustivel = "Não Específicado";
            }
        }
        public double calConsumoMedio()
        {
            double km=0, litros=0;
            foreach(Abastecimento ab in listaAbast)
            {
                km += ab.KM;
                litros += ab.Litros;
            }
            return  litros/(km/100);
        }
        public double totalGastoEmCombustivel()
        {
            double litros = 0;
            foreach(Abastecimento ab in listaAbast)
            {
                litros += ab.Litros;
            }
            return litros;
        }
        public void addAbast(Abastecimento a)
        {
            listaAbast.Add(a);
        }
        public string listaString()
        {
            foreach(Abastecimento a in listaAbast)
            {
                Console.WriteLine("Abastecimento 1:");
                return a.ToString();
            }
            return "";
        }


    }
}
