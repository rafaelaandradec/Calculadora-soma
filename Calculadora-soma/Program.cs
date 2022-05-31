using System;

namespace Calculadora_soma
{
    class Program
    {
        static void Main()
        {
            bool opcao = true;

            Console.WriteLine("Olá, sou um assistente de soma, irei realizar a soma de número que você escolher até você desejar parar!");

            Console.WriteLine("Digite o valor inicial:");
            float.TryParse(Console.ReadLine(), out float inicial);

            while(opcao == true)
            {
                Console.WriteLine("Digite o número que deseja somar ao número inicial:");
                float.TryParse(Console.ReadLine(), out float n1);
                inicial = inicial + n1;
                Console.WriteLine("A soma até o momento é {0}.", inicial);
                Console.WriteLine("Deseja sair do programa? Digite (1) - sim ou (2) - não");
                int.TryParse(Console.ReadLine(), out int saida);
                switch (saida)
                {
                    case 1:
                        Console.WriteLine("Saindo do programa!");
                        opcao = false;
                        break;
                    case 2:
                        Console.WriteLine("Continue a soma!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida. Retornando para a soma.");
                        break;
                }
            }
        }
    }
}
