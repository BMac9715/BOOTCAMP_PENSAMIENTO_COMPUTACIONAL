using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscapeRoom
{
    public class Calculadora //Nombre de nuestra clase.
    {
        public Calculadora() { }

        static void Main(string[] args)
        {
            Console.Title = "Mini Calculadora de Enteros"; //Sirve para agregarle un titulo a la ventana
            string resp = "";
            do
            {
                int valor1 = 0; //Aqui se almacenara el primer valor ingresado.
                int valor2 = 0; //Aqui se almacenara el segundo valor ingresado.
                 //Aqui se almacenara el resultado de la operacion.

                //Aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu de seleccion.
                Console.WriteLine("\nPresione el simbolo para realizar la operacion:\n");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.Write("\n Eliga Una Opcion: "); //Aqui es donde indicaremos que operacion vamos a realizar
                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp);
                //Aqui se agregaran los mensajes para poder ingresar los datos.
                Console.WriteLine("\nIngrese sus dos numerosn");
                Console.Write("Valor1: ");
                valor1 = int.Parse(Console.ReadLine());
                Console.Write("Valor2: ");
                valor2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Menu(eleccion, valor1, valor2);
                
                Console.Write("\n¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.
                resp = Console.ReadLine();
            }
            while (resp == "s" || resp == "s");
        }
    
        static void Menu(string operacion, int valor1, int valor2)
        {
            int R = 0;
            Operaciones op = new Operaciones();

            switch (operacion)
            {
                case "+":
                    Console.WriteLine("El resultado de la suma es:");
                    R = op.Suma(valor1, valor2);
                    Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
                    break;
                case "-":
                    Console.WriteLine("El resultado de la resta es:");
                    R = op.Resta(valor1, valor2);
                    Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
                    break;
                case "*":
                    Console.WriteLine("El resultado de la multiplicacion es:");
                    R = op.Multiplicacion(valor1, valor2);
                    Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
                    break;
                case "/":
                    Console.WriteLine("El resultado de la division es:");
                    R = op.Division(valor1, valor2);
                    Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                    break;
            }
        }

    }

    public class Operaciones
    {
        public Operaciones () { }

        public int Suma(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public int Resta(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        public int Multiplicacion(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public int Division(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
    }
}
