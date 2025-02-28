using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program programa = new Program();
            programa.adivinanumero();
        }

        /*crear un programa que pida la edad del ususario y determina si puede votar
         *escribir un programa que convierta una calificacion numerica (0-100)segun 
         * 90-100=A
         * 80-89=B
         * 70-79=C
         * 60-69=D
         * 0-59=F
         * crear un programa que pida un numero entero y determinar si es par o impar
         * escribe un prgrama que pida dos numeros al usuario y determinar cual es mayor
         * -------------------------------------------------------------------------------
         * paso1.- crear un menu con el ciclo do While
         * el menu va a tener una salida de texto que diga "ejercicios en clase, selecciona una opcion
         * esto a travez de Console.Writhe.Line("Ejercicios en clase, selecciona una opcion");
         * paso 2.- crear el primer programa
         * a) crear una funcion que solicite la edad al ususario y que determine si es mayor de edad,
         * si es mayor de edad este puede votar 
        */

        public void Voto()
        {
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad > 18)
            {
                Console.WriteLine("No puede Votar");
            }
            else
            {
                Console.WriteLine("Puede votar");
            }

        }
        public void Calidicacion()
        {
            Console.WriteLine("\nIngrese una calificación numérica (0-100):");
            int calificacion;
            if (int.TryParse(Console.ReadLine(), out calificacion) && calificacion >= 0 && calificacion <= 100)
            {
                string letra;
                if (calificacion >= 90)
                    letra = "A";
                else if (calificacion >= 80)
                    letra = "B";
                else if (calificacion >= 70)
                    letra = "C";
                else if (calificacion >= 60)
                    letra = "D";
                else
                    letra = "F";

                Console.WriteLine($"La calificación en letra es: {letra}");
            }
        }


        public int generanumero()
        {
            Random  random = new Random();
             return random.Next(1, 100);
        }


        public void adivinanumero()
        {
            int intento = 3;
            bool adivinar = false;
            int numeroSecreto = generanumero();

            Console.WriteLine("Adivina un numero del 1 al 100");
                while (intento > 0 && !adivinar)
                {
                Console.WriteLine("Ingrese nuemro");
                Console.WriteLine("\nIngresa un número:");
                if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
                {
                    if (numeroIngresado == numeroSecreto)
                    {
                        Console.WriteLine("¡Felicidades! Adivinaste el número.");
                        adivinar = true;
                    }
                    else
                    {
                        if (intento > 0)
                        {
                            if (numeroIngresado < numeroSecreto)
                            {
                                Console.WriteLine("El número es mayor. Te quedan " + intento + " intentos.");
                            }
                            else
                            {
                                Console.WriteLine("El número es menor. Te quedan " + intento + " intentos.");
                            }
                        }
                        else
                        {

                        }
                    }
                    if (!adivinar)
                    {
                        Console.WriteLine("\nLo siento, se acabaron los intentos");
                        Console.WriteLine("el numero era: " + numeroSecreto);
                    }
                   
                }
            }
        }

    }
}
