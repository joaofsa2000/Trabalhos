using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader(@"C:\FT02\NOTAS.txt");
            StreamWriter write1 = new StreamWriter(@"C:\FT02\APROVADOS.txt");
            StreamWriter write2 = new StreamWriter(@"C:\FT02\REPROVADOS.txt");
            int flag = 1;bool flag2 = false, flag3 = false;
            while (!read.EndOfStream)
            {
                string linha = read.ReadLine();
                string[] dados = linha.Split(' ');
                if (float.Parse(dados[2]) >= 9.5 && float.Parse(dados[2])<=20.0)
                {
                    write1.WriteLine(linha);
                    if (!flag3) { flag = flag*2; flag3 = true; };
                }
                else if(float.Parse(dados[2])>=0.0 && float.Parse(dados[2])<9.5) {
                    write2.WriteLine(linha);if (!flag2) { flag = flag * 3;flag2 = true; }; }
            }
            read.Close();
            switch (flag)
            {
                case 2:write2.WriteLine("Não há registos!");break;
                case 1:write1.WriteLine("Não há registos!");write2.WriteLine("Não há registos"); break;
                case 3:write1.WriteLine("Não há registos!");break;
            }
            write1.Close();write2.Close();

        }
    }
}
