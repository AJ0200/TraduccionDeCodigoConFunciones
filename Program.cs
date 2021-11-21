using System;
using System.Linq;
using System.Timers;

namespace Traduccion_de_codigo__funciones_
{
    class Program
    {
        public static double pi=3.14;
        public static double resultado;
        public static string opcion;
        public static int vradio;

        public static int vbase;
        public static int valtura;

/* titulo & menu del programa */
        public static void Titulo(string marco){
            System.Console.WriteLine(marco+"\n\t PROGRAMA PARA GEOMETRIA \n"+marco);
            Console.WriteLine("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir\n\n");

        }

        public static void AreaDelCirculo(double pi){
            Console.WriteLine("Para calcular el area del circulo \nIngrese el Radio");
            vradio = Int32.Parse(Console.ReadLine());
            Double x= (Double) vradio;
            resultado= pi*(x*x);
            System.Console.WriteLine("el resultado es: " + resultado);
        }

        public static void AreaDelRectangulo(double pi){
            Console.WriteLine("Para calcular el area del rectangulo\n");
            Console.WriteLine("Ingrese la Base");
            vbase = Int32.Parse(Console.ReadLine());
            Double x= (Double) vbase;
            Console.WriteLine("Ingrese la Altura");
            valtura = Int32.Parse(Console.ReadLine());
            Double y= (Double) valtura;
            resultado=vbase*valtura;
            System.Console.WriteLine("el resultado es: " + resultado);
        }
        public static void AreaDelTringulo(double pi){
            Console.WriteLine("Para calcular el area del triangulo\n");
            Console.WriteLine("Ingrese la Base");
            vbase = Int32.Parse(Console.ReadLine());
            Double x= (Double) vbase;
            Console.WriteLine("Ingrese la Altura");
            valtura = Int32.Parse(Console.ReadLine());
            Double y= (Double) valtura;
            resultado=(valtura*vbase)/2;
            System.Console.WriteLine("el resultado es: " + resultado);
        }

/* programa principal */
        static void Main(string[] args)
        {
            string marco=string.Concat(Enumerable.Repeat("*", 50));
            Titulo(marco);


            while (opcion != "s"){
            System.Console.WriteLine("Ingrese su opcion: "); 
            opcion=Console.ReadLine();
            System.Console.WriteLine();
            Console.Clear();
            if (opcion=="s"){
                System.Console.WriteLine("\n\nGracias por usar el programa de cálculo geométrico\n\n"); 
                break;
            }
            else if(opcion == "c"){
                AreaDelCirculo(pi);
                System.Console.WriteLine("Presione cualquier tecla para regresar al menu");
                Console.ReadKey();
                Console.Clear();
                Titulo(marco);

            }else if(opcion=="r"){
                AreaDelRectangulo(pi);
                System.Console.WriteLine("Presione cualquier tecla para regresar al menu");
                Console.ReadKey();
                Console.Clear();
                Titulo(marco);

            }else if(opcion=="t"){
                AreaDelTringulo(pi);
                System.Console.WriteLine("Presione cualquier tecla para regresar al menu");
                Console.ReadKey();
                Console.Clear();
                Titulo(marco);
            }else {
                System.Console.WriteLine("opcion invalida, porfavor ingrese una opcion valida");
                System.Console.WriteLine("Presione cualquier tecla para regresar al menu");
                Console.ReadKey();
                Console.Clear();
                Titulo(marco);
            }
            }
        }
    }
}
