using System;

namespace QuintoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao novo projeto;");

            //entrada de dados
            Console.WriteLine("digite o ano do seu nascimento:");

            int anonascimento = int.Parse(Console.ReadLine());
            int anoatual = 2021;
            int total = anoatual - anonascimento;


            Console.WriteLine("ok, por favor aguarde...");
            Console.WriteLine("sua idade é de... " + total);

            //conversao em semanas
            double semana = 52.146;
            Console.WriteLine("sua idade convertida em semanas é de: " + total * semana);

            //condicional
            if (total >= 18) {
                 Console.WriteLine("o cliente possui ingressos ? (sim ou não)");
                string ingressos = Console.ReadLine();
                if (ingressos == "sim"){
                    Console.WriteLine("Acesso liberado");
                }else{
                    Console.WriteLine("encaminha para bilheteria");
                } 
            }
            else  {
                Console.WriteLine("acesso negado");
            }

            

        }
    }
} 
