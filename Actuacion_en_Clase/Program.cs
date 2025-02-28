using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actuacion_en_Clase
{
    // Clase que contiene la lógica del juego
    class JuegoAdivinanza
    {
        private int numeroAlazar; // Número generado aleatoriamente
        private int intentos;        // Contador de intentos del usuario

        public JuegoAdivinanza()
        {
            // Generamos un número aleatorio entre 1 y 100
            Random random = new Random();
            numeroAlazar = random.Next(1, 101);
            intentos = 0;
        }

        // Método que verifica la adivinanza del usuario
        public string VerificarNumero(int numeroUsuario)
        {
            intentos++;

            if (numeroUsuario < numeroAlazar)
                return "El número es mayor.";
            else if (numeroUsuario > numeroAlazar)
                return "El número es menor.";
            else
                return $"¡Correcto! Has adivinado el número en {intentos} intento(s).";
        }
    }

    // Clase principal que ejecuta el programa
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
            Console.WriteLine("Estoy pensando en un número entre 1 y 100. ¿Puedes adivinarlo?");

            JuegoAdivinanza juego = new JuegoAdivinanza(); // Crear una instancia del juego
            bool adivinado = false;

            while (!adivinado)
            {
                Console.Write("Introduce un número: ");
                if (int.TryParse(Console.ReadLine(), out int numeroUsuario))
                {
                    string resultado = juego.VerificarNumero(numeroUsuario);
                    Console.WriteLine(resultado);

                    if (resultado.Contains("¡Correcto!"))
                        adivinado = true;
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                }
            }
        }
    }
}