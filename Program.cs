using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecurcivo
{
    class Program
    {
        //Aqui e um metodo chamado main 
        static void Main(string[] args)
        {
            Console.Write("Caucular de fatorial de qual o numero?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("O fatorial de"+ num + "é" + Fatorial(num));

            Console.ReadKey();
        }

            //Aqui é um metodo fatorial que chama se proprio e calcula o numero inteiro
        static int Fatorial (int num)
        { 
          if (num <= 0)
          {
              return 1;
          }
                 //Aqui esta retornando o proprio valor do antecessor
            return num * Fatorial(num - 1);
            //5 * fatorial(4);
            //4 * fatorial(3);
            //3 * fatorial(2);
            //2 * fatorial(1);
            //1 * fatorial(0);
            //return 1;
        }


    }


}
