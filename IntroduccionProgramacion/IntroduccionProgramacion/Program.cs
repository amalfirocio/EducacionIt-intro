using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int var1 = 13;
             const  int var2 = 3; //Constante no se puede cambiar el valor
             int modulo = 0;

             Console.WriteLine("Suma " + (var1 + var2));
             Console.WriteLine("Multiplicacion " + (var1 * var2));
             Console.WriteLine("Division" + (var1 / var2));
             Console.WriteLine("Resta " + (var1 - var2));

             //Modulo - devuelve el resto de la division
             modulo = var1 % 5;
             Console.WriteLine("Modulo de " + var1 +  " es : " + modulo);

             //Ingreso de datos por consola

             int numero1 = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Usted ingreso : " + numero1);*/

            
            //Ejercicio 1
            int n1 = 5;
            int n2 = 10;
            int n3 = 20;
            int promedio = 0;
            int modulo = 0;
            
            Console.WriteLine("Suma: " + (n1 +n2));
            Console.WriteLine("Resta: " + (n3 - n1));
            Console.WriteLine("Multiplicacion: " + (n1 * n3));
            Console.WriteLine("Division: " + (n3 + n2));

            // Ejercicio 2
            Console.WriteLine();
            Console.WriteLine("Ingrese el primer numero : ");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero : ");
            n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero : ");
            n3 = Int32.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;
            modulo = n2 % n1;
            Console.WriteLine("El Total es: " + (n1 +n2 + n3));
            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine("El resto entre el primer y segundo numero es : " + modulo);

          
            Console.ReadLine();

        }
    }
}
