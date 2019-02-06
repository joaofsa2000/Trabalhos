using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro_e_Abastecimento
{
    class Abastecimento
    {
        private Carro car;
        private DateTime data;
        private double _valor;
        private double _litros;
        private double _km;
        public Abastecimento()
        {
            car = new Carro();
            data = new DateTime();
            _valor = 0;
            _litros = 0;
            _km = 0;
        }
        public Abastecimento(double val,double ltr,double km,Carro carro)
        {
            Valor = val;
            Litros = ltr;
            KM = km;
            data = DateTime.Now;
            car = carro;
        }
        public Abastecimento(Abastecimento ab)
        {
            car = ab.car;
            data = ab.data;
            _valor = ab.Valor;
            _litros = ab.Litros;
            _km = ab.KM;
        }
        public double Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                bool flag;
                do
                {
                    if (value > 0)
                    {
                        _valor = value;
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Insira um valor válido");
                        do
                        {
                            try
                            {
                                value = int.Parse(Console.ReadLine());
                                flag = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nInsira apenas números!!\n\n");
                                flag = false;
                            }
                        } while (!flag);
                        flag = false;
                    }
                } while (!flag);
            }
        }
        public double Litros
        {
            get
            {
                return _litros;
            }
            set
            {
                bool flag;
                do
                {
                    if (value > 0)
                    {
                        _litros = value;
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Insire um número de litros válido:");
                        do
                        {
                            try
                            {
                                value = int.Parse(Console.ReadLine());
                                flag = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nInsira apenas números!!\n\n");
                                flag = false;
                            }
                        } while (!flag);
                        flag = false;
                    }
                } while (!flag);
            }
        }
        public double KM
        {
            get { return _km; }
            set
            {
                bool flag;
                do
                {
                    if (value > 0)
                    {
                        _km = value;
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Insire um número de KM válido:");
                        do
                        {
                            try
                            {
                                value = int.Parse(Console.ReadLine());
                                flag = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nInsira apenas números!!\n\n");
                                flag = false;
                            }
                        } while (!flag);
                        flag = false;
                    }
                } while (!flag);
            }
        }
        public double calcPrecoLitro()
        {
            return Valor / Litros;
        }
        public override string ToString()
        {
            return "\nLitros: " + Litros.ToString("n2") + "\nValor: " + Valor.ToString("n2") + "\nKM: " + KM.ToString("n2") + "\nData: " + data.ToString();
        }

    }
}
