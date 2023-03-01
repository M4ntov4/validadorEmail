using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validadorEmailJoao
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string email;
            int caracters;
            int tamanho = 0;
            string local = "";
            string dominio = "";

            Console.WriteLine("Insira seu E-mail para ser validado: ");
            email = Console.ReadLine();

            for (int i = 0; i < email.Length; i++)
            {
                caracters = email[i];
                //Console.Write(caracters);

                if (caracters == '@')
                {
                  i = email.Length;
                                
                }
                else
                {
                    local += email.Substring(i, 1);
                    tamanho++;
                }
            }

            for (int i = tamanho; i < email.Length; i++)
            {
                dominio += email.Substring(i, 1);
            }


        Console.WriteLine("Local: " + local + " e dominio: "+ dominio);
            
            Console.ReadKey();




        }
    }
}
