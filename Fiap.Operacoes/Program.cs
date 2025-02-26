using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Operacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Digite seu nome:");
                String nome = Console.ReadLine();

                Console.Write("Digite um número:");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o número 2:");
                double num2 = double.Parse(Console.ReadLine());

                double soma = num1 + num2;
                double sub = num1 - num2;
                double mult = num2 * num1;  
                double modulo = num2 % num1;    

                Console.WriteLine("\nResultado:");
                Console.WriteLine($"O valor da soma é:{soma}");
                Console.WriteLine($"O valor da soma é:{sub}");
                Console.WriteLine($"O valor da soma é:{mult}");
                Console.WriteLine($"O valor da soma é:{modulo}");

                //Operações Relacionais

                Console.WriteLine("\nComparação entre números");
                Console.WriteLine($"Os números são iguais?{num1 == num2}");

                Console.WriteLine($"Os números são diferentes?{num1 != num2}");

                Console.WriteLine($"O primeiro número é maior que o segundo?{num1 > num2}");

                //Operações lógicas
                bool ambosPositivos = num1 > 0 && num2 > 0;
                bool nenhumNegativo = !(num1 <0 ||  num2 <0);

                Console.WriteLine($"Ambos positivos {ambosPositivos}");
                Console.WriteLine($"Algum negativo {nenhumNegativo}");


                Console.WriteLine("\nDigite qualquer coisa para sair!");
                
            }
            catch (Exception ex){ 
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();  
        }
    }
}
