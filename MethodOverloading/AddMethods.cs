using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class AddMethods
    {
        public static int Add(int numero1, int numero2) 
        {
            return numero1 + numero2;
        }
        public static double Add(double numero1, double numero2) 
        {           
            return numero1 + numero2;
        }
        public static string Add(int numero1, int numero2, bool numero3)
        {
            int total = numero1 + numero2;

            if (numero3 == true && total > 1)
            {
                return $"{total} dollars";
            }
            else if (numero3 == true && total == 1) 
            {             
                return $"{total} dollar";
            }
            else
            {
                return "Lose Money";
            }
        }
    }
}
