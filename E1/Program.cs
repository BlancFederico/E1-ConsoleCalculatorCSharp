using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            string num1 = Console.ReadLine();
            Console.WriteLine("Ingrese el signo de una operacion (+ - * /)");
            string op = Console.ReadLine();
            Console.WriteLine("Ingrese otro numero");
            string num2 = Console.ReadLine();

            bool res1 = num1.All(Char.IsLetter);
            bool res2 = num2.All(Char.IsLetter);
            

            if (string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num2) || res1 == true || res2 == true)
            {
                Console.WriteLine("Error: Debe ingresar numeros");
            }
            else
            {
                int num3 = Convert.ToInt32(num1);
                int num4 = Convert.ToInt32(num2);
                switch (op)
                {
                    case "+":
                        Console.WriteLine("Resultado:" + (num3 + num4));
                        break;
                    case "-":
                        Console.WriteLine("Resultado:" + (num3 - num4));
                        break;
                    case "*":
                        Console.WriteLine("Resultado:" + (num3 * num4));
                        break;
                    case "/":
                        Console.WriteLine("Resultado:" + (num3 / num4));
                        break;
                    default:
                        Console.WriteLine("Error: Debe ingresar una operacion VALIDA");
                        break;
                }
            }

            
          
            Console.ReadKey();
        }
    }
}
