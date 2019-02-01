using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FT05
{

    class Program
    {        
        static List<Gerente> listaGerentes = new List<Gerente>();
        static List<Operario> listaOperarios = new List<Operario>();
        static string[] mainmenu = {"MAIN MENU", "Inserir Gerente", "Inserir Operário", "Visualizar Gerentes", "Visualizar Operários", "Visualizar Funcionários", "Sair" };
        static string[] bemvindoMenu = {"Deseja importar os funcionários?", "Sim", "Não" };    
        static string[] segundomenu = {"Lista de Gerentes:", "Lista de Operários","Lista de Funcionários"};
        static string[] terceiromenu = { "Indique a opção pretendida", "Alterar Valor Hora", "Calcular Idade", "Calcular Salário" };
        static void Main(string[] args)
        {
            FileExist();
            int pointer = 1;
            int pointer1 = 0;
            ConsoleKeyInfo key;
            while (pointer !=-2)
            {
                MenuPrincipal(ref pointer, bemvindoMenu);
                key = Console.ReadKey(true);
                if (MenuSeta(3, key, ref pointer))
                {
                    MenuPrincipal(ref pointer, bemvindoMenu);
                    continue;
                }
                switch (pointer)
                {
                    case 1:
                        FromFichToList();
                        pointer = -2;
                        break;
                    case 2:
                        pointer = -2;
                        break;
                }
            }
            pointer = 0;
            while (pointer!=-2)
            {
                MenuPrincipal(ref pointer, mainmenu);
                key = Console.ReadKey(true);                
                if (MenuSeta(7, key, ref pointer))
                {
                    MenuPrincipal(ref pointer,mainmenu);
                    continue;
                }
                if (key.Key == ConsoleKey.Enter)
                {         
                    switch (pointer)
                    {
                        case 1:    //INSERIR GERENTE
                            {
                                Console.Clear();
                                do
                                {
                                    listaGerentes.Add(GerenteInput());
                                    key = PressToInsert();
                                } while (key.Key != ConsoleKey.Escape);                                
                                break;
                            }
                        case 2:   //INSERIR OPERARIO
                            {          
                                Console.Clear();               
                                do
                                {
                                    listaOperarios.Add(OperarioInput());
                                    key = PressToInsert();
                                } while (key.Key != ConsoleKey.Escape);                                
                                break;
                            }
                        case 3:    //VISUALIZAR GERENTES
                            {
                                Console.Clear();
                                pointer1 = 1;
                                while (key.Key!=ConsoleKey.Escape)
                                {
                                    menudeGerente(listaGerentes, ref pointer1, segundomenu);
                                    key = Console.ReadKey(true);
                                    if (MenuSeta(listaGerentes.Count+1, key, ref pointer1))
                                    {
                                        menudeGerente(listaGerentes, ref pointer1, segundomenu);
                                    }
                                    if (key.Key == ConsoleKey.Enter)
                                    {
                                        string a;
                                        int pointer2 = 1;
                                        a = "Gerente: " + listaGerentes[pointer1 - 1].ToString();
                                        ConsoleKeyInfo key2;
                                        key2 = default(ConsoleKeyInfo);
                                        while (key2.Key != ConsoleKey.Escape)
                                        {
                                            menuTerceiro(a, ref pointer2, terceiromenu);
                                            key2 = Console.ReadKey(true);
                                            if (MenuSeta(4, key2, ref pointer2))
                                            {
                                                menuTerceiro(a, ref pointer2, terceiromenu);
                                            }
                                            if (key2.Key == ConsoleKey.Enter)
                                            {
                                                switch (pointer2)
                                                {
                                                    case 1:
                                                        valorhoragerente(a, listaGerentes[pointer1 - 1]);
                                                        a = "Gerente: " + listaGerentes[pointer1 - 1].ToString();
                                                        break;
                                                    case 2:
                                                        idadegerente(a, listaGerentes[pointer1 - 1]);
                                                        PressAny();
                                                        break;
                                                    case 3:
                                                        CalcularSal(a, listaGerentes[pointer1 - 1]);
                                                        PressAny();
                                                        break;
                                                }
                                            }
                                            
                                        }


                                    }
                                    
                                }                                                                
                                break;
                            }
                        case 4:   //VISUALIZAR OPERARIOS
                            {
                                Console.Clear();
                                pointer1 = 1;
                                while (key.Key != ConsoleKey.Escape)
                                {
                                    menudeOperario(listaOperarios, ref pointer1, segundomenu);
                                    key = Console.ReadKey(true);
                                    if (MenuSeta(listaOperarios.Count + 1, key, ref pointer1))
                                    {
                                        menudeOperario(listaOperarios, ref pointer1, segundomenu);
                                    }
                                    if (key.Key == ConsoleKey.Enter)
                                    {                                        
                                        string a;
                                        int pointer2 = 1;
                                        a = "Operário: " + listaOperarios[pointer1-1].ToString();
                                        ConsoleKeyInfo key2;
                                        key2 = default(ConsoleKeyInfo);
                                        while (key2.Key != ConsoleKey.Escape)
                                        {

                                            menuTerceiro(a, ref pointer2, terceiromenu);
                                            key2 = Console.ReadKey(true);
                                            if (MenuSeta(4, key2, ref pointer2))
                                            {
                                                menuTerceiro(a, ref pointer2, terceiromenu);
                                            }
                                            if (key2.Key == ConsoleKey.Enter)
                                            {
                                                switch (pointer2)
                                                {
                                                    case 1:
                                                        valorhoraoperario(a, listaOperarios[pointer1-1]);
                                                        a = "Operário: " + listaOperarios[pointer1-1].ToString();
                                                        break;
                                                    case 2:
                                                        idadeoperario(a, listaOperarios[pointer1-1]);
                                                        PressAny();
                                                        break;
                                                    case 3:
                                                        CalcularSalOP(a, listaOperarios[pointer1-1]);
                                                        PressAny();
                                                        break;
                                                }
                                            }                                            
                                        }
                                    }                                    
                                }

                                break;
                            } 
                        case 5:    //VISUALIZAR FUNCIONARIOS
                            {
                                Console.Clear();
                                menudeFuncionario(listaOperarios, listaGerentes);
                                PressAny();                                
                                break;
                            }
                        case 6:     //SAIR
                            {
                                Console.Clear();
                                pointer = -2;
                                break;
                            }
                    }
                }
            }

            Exit();

        }
        static bool MenuPrincipal(ref int pointer, string[] menuEG)
        {
            Console.Clear();
            Console.WriteLine(menuEG[0]+"\n\n");
            for (int i = 1; i < menuEG.Length; i++)
            {
                if (i == pointer)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(menuEG[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(menuEG[i]);
                }
            }
            return true;
        }
        static void FromFichToList()
        {
            StreamReader gerentesRD = new StreamReader(@"C:\Users\Public\Documents\gerentes.txt");
            StreamReader operariosRD = new StreamReader(@"C:\Users\Public\Documents\operarios.txt");

            while (!gerentesRD.EndOfStream)
            {
                string linha = gerentesRD.ReadLine();
                string[] lista = linha.Split(',');
                listaGerentes.Add(new Gerente(int.Parse(lista[0]), lista[1], int.Parse(lista[2]), int.Parse(lista[3]), int.Parse(lista[4]), lista[5], double.Parse(lista[6]), lista[7], int.Parse(lista[8])));
            }
            gerentesRD.Close();
            while (!operariosRD.EndOfStream)
            {
                string linha = operariosRD.ReadLine();
                string[] lista = linha.Split(',');
                listaOperarios.Add(new Operario(int.Parse(lista[0]), lista[1], int.Parse(lista[2]), int.Parse(lista[3]), int.Parse(lista[4]), lista[5], double.Parse(lista[6]), lista[7]));
            }
            operariosRD.Close();
        }
        static void FromListToFich()
        {
            StreamWriter gerentesWR = new StreamWriter(@"C:\Users\Public\Documents\gerentes.txt",false);
            StreamWriter operariosWR = new StreamWriter(@"C:\Users\Public\Documents\operarios.txt",false);
            foreach (Gerente obj in listaGerentes)
            {
                gerentesWR.WriteLine(obj.FichString());
            }
            gerentesWR.Close();
            foreach (Operario obj in listaOperarios)
            {
                operariosWR.WriteLine(obj.FichString());
            }
            operariosWR.Close();
            Console.WriteLine("Funcionarios Guardados com sucesso!");
        }
        static Gerente GerenteInput()
        {
            int id=0, dia=0, mes=0, ano=0, exten=0; string nome, email, espe; double vh=0.0;
            Console.Write("INSERIR GERENTE\n\n");
            id =formatoVer(id, "Digite o ID: ");
            Console.Write("Digite o Nome:");
            nome = Console.ReadLine();
            Console.Write("Digite a data de Nascimento: \n");
            dia = formatoVer(dia, "Dia:");
            mes = formatoVer(mes,"Mes:");
            ano = formatoVer(ano,"Ano:");
            Console.Write("\nDigite o eMail: ");
            email = Console.ReadLine();
            vh = formatoVerDBL(vh, "Digite o valor hora: ");
            Console.Write("Digite a Especialidade: ");
            espe = Console.ReadLine();
            exten = formatoVer(exten,"Digite a extensão: ");
            return new Gerente(id, nome, dia, mes, ano, email, vh, espe, exten);
        }
        static Operario OperarioInput()
        {
            int id=0, dia=0, mes=0, ano=0; string nome, email, depe; double vh=0.0;
            Console.Write("INSERIR OPERARIO\n\n");
            id = formatoVer(id, "Digite o ID: ");
            Console.Write("Digite o Nome:");
            nome = Console.ReadLine();
            Console.Write("Digite a data de Nascimento:\n ");
            dia = formatoVer(dia, "Dia:");
            mes = formatoVer(mes, "Mes:");
            ano = formatoVer(ano, "Ano:");
            Console.Write("\nDigite o eMail: ");
            email = Console.ReadLine();
            vh = formatoVerDBL(vh, "Digite o valor hora: ");
            Console.Write("Digite a Especialidade: ");
            depe = Console.ReadLine();

            return new Operario(id, nome, dia, mes, ano, email, vh, depe);
        }
        static bool MenuSeta(int optionSize, ConsoleKeyInfo key,ref int pointer)
        {
// optionSize é o numero de opçoes no menu (ex:. se o menu tiver 4 opçoes entao o optionSize é 4), ele permite saber onde esta o ponteiro.
            if (key.Key == ConsoleKey.UpArrow)
            {     
                pointer -= 1;
                if (pointer == 0)  // SE O POINTER PASSAR ANTES DA PRIMEIRA POSICAO
                {
                    pointer = optionSize-1;  // POINTER É IGUAL A ULTIMA POSIÇAO NO VETOR 
                }
                
                return true;
            }
            else
            {
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pointer += 1;
                    if (pointer == optionSize)      // SE O POINTER PASSAR DA ULTIMA POSIÇAO
                    {
                        pointer = 1;      // POINTER IGUAL A PRIMEIRA POSIÇAO
                    }
                    
                    return true;
                }
                
            }
            return false;
        }
        static void menudeGerente(List<Gerente> s,ref int pointer,string[] menuEG)
        {
            int count = 1;
            Console.Clear();
            Console.WriteLine(menuEG[0]);
            foreach(Gerente obj in s)
            {
                if (count == pointer)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(obj.ToString());
                    Console.ResetColor();
                }
                else
                    Console.WriteLine(obj.ToString());
                count++;
            }
        }
        static void menudeOperario(List<Operario> s, ref int pointer, string[] menuEG)
        {
            int count = 1;
            Console.Clear();
            Console.WriteLine(menuEG[0]);
            foreach (Operario obj in s)
            {
                if (count == pointer)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(obj.ToString());
                    Console.ResetColor();
                }
                else
                    Console.WriteLine(obj.ToString());
                count++;
            }
        }
        static void menudeFuncionario(List<Operario> s,List<Gerente> t)
        {
            Console.Clear();
            Console.WriteLine("Lista de Funcionários:\n\n");
            foreach(Gerente obj in t)
            {
                Console.WriteLine(obj.ToString());
            }
            foreach (Operario obj in s)
            {
                    Console.WriteLine(obj.ToString());
            }
        }
        static void menuTerceiro(string es,ref int pointer,string[] menuEG)
        {
            Console.Clear();
            Console.WriteLine(es+"\n\n\n"+menuEG[0] + "\n");
            for (int i = 1; i < menuEG.Length; i++)
            {
                if (i == pointer)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(menuEG[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(menuEG[i]);
                }
            }
        }
        static void valorhoragerente(string es,Gerente obj)
        {
            Console.Clear();
            Console.Write(es+ "\n\n\nNovo Valor Hora: ");
            obj.ValorHora = int.Parse(Console.ReadLine());        
        }
        static void idadegerente(string es,Gerente obj)
        {
            Console.Clear();
            Console.Write(es + "\n\n\nO " + obj.Nome + " tem " + obj.DataNasc.Idade(obj.DataNasc.now));
        }
        static void CalcularSal(string es,Gerente obj)
        {
            Console.Clear();
            int a;
            Console.WriteLine(es+"\n\n\nIndique o número de horas que trabalhou: ");
            a = int.Parse(Console.ReadLine());            
            Console.WriteLine("O salário bruto sem subsídios é: "+ obj.CalSal(a));
        }
        static void valorhoraoperario(string es, Operario obj)
        {
            Console.Clear();
            Console.Write(es + "\n\n\nNovo Valor Hora: ");
            obj.ValorHora = int.Parse(Console.ReadLine());
        }
        static void idadeoperario(string es, Operario obj)
        {
            Console.Clear();
            Console.Write(es + "\n\n\nO " + obj.Nome + " tem " + obj.DataNasc.Idade(obj.DataNasc.now));
        }
        static void CalcularSalOP(string es, Operario obj)
        {
            Console.Clear();
            int a;
            Console.WriteLine(es + "\n\n\nIndique o número de horas que trabalhou: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("O salário bruto sem subsídios é: " + obj.CalSal(a));
        }
        static void Exit()
        {
            FromListToFich();
            Console.WriteLine("\n\nAté a próxima!");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }
        static int formatoVer(int a, string b)
        {
            bool flag = false;
            do
            {
                try
                {
                    Console.Write(b);
                    a = int.Parse(Console.ReadLine());
                    flag = true;
                    return a;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nFormato não aceitável!!!");
                    flag = false;
                }
            } while (!flag);
            return a;
        }
        static double formatoVerDBL(double a, string b)
        {
            bool flag = false;
            do
            {
                try
                {
                    Console.Write(b);
                    a = double.Parse(Console.ReadLine());
                    flag = true;
                    return a;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nFormato não aceitável!!!");
                    flag = false;
                }
            } while (!flag);
            return a;
        }
        static void FileExist()
        {
            if (!File.Exists(@"C:\Users\Public\Documents\gerentes.txt"))
                File.Create(@"C:\Users\Public\Documents\gerentes.txt");
            if (!File.Exists(@"C:\Users\Public\Documents\operarios.txt"))
                File.Create(@"C:\Users\Public\Documents\operarios.txt");
        }
        static ConsoleKeyInfo PressToInsert()
        {
            Console.WriteLine("\n\nPress Escape to finish or any other key to insert another...");
            return Console.ReadKey(true);
        }
        static void PressAny()
        {
            Console.WriteLine("\n\nPress any key to EXIT...");
            Console.ReadKey(true);
        }
    }

}
