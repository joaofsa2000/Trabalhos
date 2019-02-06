using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //Adicionar

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            do {
                Console.Write("Digite o email:");
                email = Console.ReadLine();
                if (!new EmailAddressAttribute().IsValid(email))
                {
                    Console.WriteLine("Digite um email valido");
                    email = null;
                }

            } while(email==null);
            Console.WriteLine(email);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
