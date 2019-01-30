using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis

            int num,num2, opcao;
            double res;

            

            Console.Write("\n Informe a operação ?\n 1 -Adição(+) \n 2-Subtração(-)\n 3-Multiplicação(*) \n 4-Divisão(/)\n");
            opcao = int.Parse(Console.ReadLine());

            

            //processamento
            
            switch (opcao)
             {
                    case 1:
                        
                        Console.Write("\n Informe o primeiro número :");
                        num = int.Parse(Console.ReadLine());

                        Console.Write("\n Informe o segundo número :");
                        num2 = int.Parse(Console.ReadLine());
                        res = (num + num2);

                        Console.Write("\n O Resultado é :" + res);
                        break;
                    case 2:
                        
                        Console.Write("\n Informe o primeiro número :");
                        num = int.Parse(Console.ReadLine());

                        Console.Write("\n Informe o segundo número :");
                        num2 = int.Parse(Console.ReadLine());
                        res = (num - num2);

                        Console.Write("\n O Resultado é :" + res);
                        break;
                    case 3:
                        
                        Console.Write("\n Informe o primeiro número :");
                        num = int.Parse(Console.ReadLine());

                        Console.Write("\n Informe o segundo número :");
                        num2 = int.Parse(Console.ReadLine());
                        res = (num * num2);
                        Console.Write("\n O Resultado é :" + res);
                        break;
                    case 4:
                        Console.Write("\n Informe o primeiro número :");
                        num = int.Parse(Console.ReadLine());

                        Console.Write("\n Informe o segundo número :");
                        num2 = int.Parse(Console.ReadLine());

                    if (num2 == 0)
                        {
                            Console.Write("\n*****ERRO! Não existe divisão por zero(0)*****");

                        }
                        else
                        {
                            
                            
                            res = (num / num2);
                        Console.Write("\n O Resultado é :" + res);
                        }
                        break;
                    default:
             
                        Console.Write("\n *******ERRO!Esse código é invalido***********");
                    
                        break;
             }
            Console.ReadKey();
        }
    }
}
