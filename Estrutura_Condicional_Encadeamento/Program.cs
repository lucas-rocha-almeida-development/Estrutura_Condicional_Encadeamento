using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Condicional_Encadeamento {
    internal class Program {
        static void Main(string[] args) {
            //Estrutura com encadeamento if / else if / else
            //exemplo classico das horas - bom dia- boa tarde - boa noite
            Console.WriteLine("Que horas são atualmente? ");
            int HorasDigitada = int.Parse(Console.ReadLine());

            if (HorasDigitada < 12)
                //podemos dispensar as chaves{}, caso seja apenas um comando a ser executado em cada bloco
                { Console.WriteLine("Bom dia!!!"); 

            }else if (HorasDigitada <18) // importancia do else if, já exclui a possibilidade da primeira condição.
                { Console.WriteLine("Boa tarde!!");
            }
            else { Console.WriteLine("Boa noite!!"); }
            Console.ReadKey();
        }
    }
}
