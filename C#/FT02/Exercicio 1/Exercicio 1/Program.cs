using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rd = new StreamReader(@"C:\Users\Public\Downloads\VENCIMENTOS.txt");
            StreamWriter wr = new StreamWriter(@"C:\Users\Public\Downloads\SUPMIL.txt");
            int flag = 0;
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                string[] dados = linha.Split(' ');
                if (int.Parse(dados[2]) > 1000)
                {
                    wr.WriteLine(linha);
                    flag = 1;
                }
            }
            rd.Close();
            if (flag == 0)
                wr.WriteLine("Não há registos!");
            wr.Close();
        }

    }
}
