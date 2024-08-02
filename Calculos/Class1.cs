using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public static class Class1
    {

        public static double Somar(double x , double y)
        {

            return x + y;

        }
        public static double Subtracao(double x, double y)
        {

            return x - y;

        }

        public static double Divisao(double x, double y)
        {

            return x/y;

        }

        public static double Multiplicacao(double x, double y)
        {

            return x * y;

        }


        public static void AddLivro()
        {
            Console.WriteLine("Digite o livro que quer colocar na estante!");

            Console.WriteLine("Nome do Livro:");
            string x = Console.ReadLine();


            List<string> Estante = new List<string>();

            Estante.Add(x);


            for (int i = 0; i < Estante.Count(); i++)
            {
                Console.WriteLine("A estante esta com os livros:" + Estante[0 + i]);
            }





        }

        public static double CelciusFareight(double c)
        {
;

           return c * 1.8 + 32;
        }

        public static string DigitEmail()
        {
            Console.WriteLine("Digite o seu Email!");

            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            return email;
        }
    }
}
