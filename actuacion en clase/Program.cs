using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actuacion_en_clase
{
    // Clase para gestionar el menú y las opciones
    /*
     *Menú principal 
     *Crear una clase llamada MenuPrincipal.
     *En el menú:
     *Mostrar las opciones disponibles del 1 al 8, más una opción para salir.
     *Usar un bucle para mantener el programa en ejecución hasta que el usuario elija salir.
     *Llamar al método correspondiente de la clase de cada opción según la entrada del usuario. 
    */
    class MenuPrincipal
    {
        public void MostrarMenu()
        {
            Console.WriteLine("=== Menú Principal ===");
            Console.WriteLine("1. Juego: Adivina el número");
            Console.WriteLine("2. Determinar si puedes votar");
            Console.WriteLine("3. Convertir calificación numérica a letra");
            Console.WriteLine("4. Determinar si un número es par o impar");
            Console.WriteLine("5. Determinar el número mayor");
            Console.WriteLine("6. Edad suficiente para votar");
            Console.WriteLine("7. Día de la semana (switch)");
            Console.WriteLine("8. Calificación a letra (switch)");
            Console.WriteLine("9. Salir");
        }
    }

    /*
     * 1. Juego: Adivina el número
     * Crear una clase llamada AdivinaElNumero.
     * Generar un número aleatorio entre 1 y 100 usando la clase Random.
     * Pedir al usuario que introduzca un número.
     * Comparar el número ingresado con el número generado:
     * Si es menor, mostrar "El número es mayor."
     * Si es mayor, mostrar "El número es menor."
     * Si es igual, mostrar "¡Felicidades! Adivinaste el número."
     * Repetir hasta que el usuario adivine el número correctamente.
     */
    class AdivinaElNumero
    {
        public void Jugar()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            bool adivinado = false;

            Console.WriteLine("Estoy pensando en un número entre 1 y 100. ¡Adivínalo!");

            while (!adivinado)
            {
                Console.Write("Introduce tu número: ");
                if (int.TryParse(Console.ReadLine(), out int numeroUsuario))
                {
                    if (numeroUsuario < numeroAleatorio)
                        Console.WriteLine("El número es mayor.");
                    else if (numeroUsuario > numeroAleatorio)
                        Console.WriteLine("El número es menor.");
                    else
                    {
                        Console.WriteLine("¡Felicidades! Adivinaste el número.");
                        adivinado = true;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                }
            }
        }
    }

    /*
     * 2.- Determinar si puedes votar
     * Crear una clase llamada Votacion.
     * Pedir al usuario que introduzca su edad.
     * Verificar si la entrada es válida.
     * Comparar la edad con 18:
     * Si es mayor o igual a 18, mostrar "Puedes votar."
     * Si es menor, mostrar "No puedes votar."
    */
    class Votacion
    {
        public void PuedeVotar()
        {
            Console.Write("Introduce tu edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                if (edad >= 18)
                    Console.WriteLine("Puedes votar.");
                else
                    Console.WriteLine("No puedes votar.");
            }
            else
            {
                Console.WriteLine("Por favor, introduce una edad válida.");
            }
        }
    }

    /*
     *3. Convertir calificación numérica a letra
     *Crear una clase llamada Calificacion.
     *Pedir al usuario que introduzca una calificación entre 0 y 100.
     *Verificar si la entrada es válida.
     *Usar condicionales if-else para determinar la letra correspondiente:
     *90-100 → A
     *80-89 → B
     *70-79 → C
     *60-69 → D
     *0-59 → F
     *Mostrar el resultado al usuario. 
    */
    class Calificacion
    {
        public void ConvertirCalificacion()
        {
            Console.Write("Introduce la calificación (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int calificacion))
            {
                if (calificacion >= 90)
                    Console.WriteLine("Calificación: A");
                else if (calificacion >= 80)
                    Console.WriteLine("Calificación: B");
                else if (calificacion >= 70)
                    Console.WriteLine("Calificación: C");
                else if (calificacion >= 60)
                    Console.WriteLine("Calificación: D");
                else
                    Console.WriteLine("Calificación: F");
            }
            else
            {
                Console.WriteLine("Por favor, introduce una calificación válida.");
            }
        }
    }

    /*
     *4. Determinar si un número es par o impar
     *Crear una clase llamada ParOImpar.
     *Pedir al usuario que introduzca un número entero.
     *Verificar si la entrada es válida.
     *Determinar si el número es divisible entre 2 (numero % 2 == 0):
     *Si es divisible, mostrar "El número es par."
     *Si no es divisible, mostrar "El número es impar."
    */
    class ParOImpar
    {
        public void Determinar()
        {
            Console.Write("Introduce un número entero: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero % 2 == 0)
                    Console.WriteLine("El número es par.");
                else
                    Console.WriteLine("El número es impar.");
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }
    }

    /*
     *5. Determinar cuál número es mayor 
     *Crear una clase llamada NumeroMayor.
     *Pedir al usuario que introduzca dos números.
     *Verificar si ambas entradas son válidas.
     *Comparar los dos números:
     *Si el primer número es mayor, mostrarlo como mayor.
     *Si el segundo número es mayor, mostrarlo como mayor.
     *Si son iguales, mostrar "Ambos números son iguales."
    */
    class NumeroMayor
    {
        public void DeterminarMayor()
        {
            Console.Write("Introduce el primer número: ");
            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.Write("Introduce el segundo número: ");
                if (int.TryParse(Console.ReadLine(), out int num2))
                {
                    if (num1 > num2)
                        Console.WriteLine($"El mayor es: {num1}");
                    else if (num2 > num1)
                        Console.WriteLine($"El mayor es: {num2}");
                    else
                        Console.WriteLine("Ambos números son iguales.");
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }
    }

    /*
     *6. Edad suficiente para votar 
     *Crear una clase llamada EdadVotacion.
     *Pedir al usuario que introduzca su edad.
     *Verificar si la entrada es válida.
     *Usar una sentencia if:
     *Si la edad es mayor o igual a 18, mostrar "Tienes la edad suficiente para votar."
     *Si es menor, mostrar "No tienes la edad suficiente para votar." 
    */
    class EdadVotacion
    {
        public void VerificarEdad()
        {
            Console.Write("Introduce tu edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                if (edad >= 18)
                    Console.WriteLine("Tienes la edad suficiente para votar.");
                else
                    Console.WriteLine("No tienes la edad suficiente para votar.");
            }
            else
            {
                Console.WriteLine("Por favor, introduce una edad válida.");
            }
        }
    }

    /*
     *7. Día de la semana (switch) 
     *Crear una clase llamada DiaSemana.
     *Pedir al usuario que introduzca un número entre 1 y 7.
     *Verificar si la entrada es válida.
     *Usar una sentencia switch para mapear el número a un día de la semana:
     *1 → Lunes
     *2 → Martes
     *3 → Miércoles
     *4 → Jueves
     *5 → Viernes
     *6 → Sábado
     *7 → Domingo
     *Mostrar el día correspondiente o un mensaje de error si el número no es válido. 
    */
    class DiaSemana
    {
        public void MostrarDia()
        {
            Console.Write("Introduce un número (1-7) para un día de la semana: ");
            if (int.TryParse(Console.ReadLine(), out int dia))
            {
                switch (dia)
                {
                    case 1: Console.WriteLine("Lunes"); break;
                    case 2: Console.WriteLine("Martes"); break;
                    case 3: Console.WriteLine("Miércoles"); break;
                    case 4: Console.WriteLine("Jueves"); break;
                    case 5: Console.WriteLine("Viernes"); break;
                    case 6: Console.WriteLine("Sábado"); break;
                    case 7: Console.WriteLine("Domingo"); break;
                    default: Console.WriteLine("Número no válido."); break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }
    }

    /*
     *8. Calificación a letra (switch)
     *Crear una clase llamada CalificacionSwitch.
     *Pedir al usuario que introduzca una calificación entre 0 y 100.
     *Verificar si la entrada es válida.
     *Usar una sentencia switch para mapear el rango de calificación:
     *90-100 → A
     *80-89 → B
     *70-79 → C
     *60-69 → D
     *0-59 → F
     *Mostrar el resultado al usuario. 
    */
    class CalificacionSwitch
    {
        public void ConvertirCalificacionSwitch()
        {
            Console.Write("Introduce la calificación (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int calificacion))
            {
                switch (calificacion / 10)
                {
                    case 10:
                    case 9: Console.WriteLine("Calificación: A"); break;
                    case 8: Console.WriteLine("Calificación: B"); break;
                    case 7: Console.WriteLine("Calificación: C"); break;
                    case 6: Console.WriteLine("Calificación: D"); break;
                    default: Console.WriteLine("Calificación: F"); break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce una calificación válida.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal menu = new MenuPrincipal();
            bool salir = false;

            while (!salir)
            {
                menu.MostrarMenu();
                Console.Write("Selecciona una opción: ");
                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 1: new AdivinaElNumero().Jugar(); break;
                        case 2: new Votacion().PuedeVotar(); break;
                        case 3: new Calificacion().ConvertirCalificacion(); break;
                        case 4: new ParOImpar().Determinar(); break;
                        case 5: new NumeroMayor().DeterminarMayor(); break;
                        case 6: new EdadVotacion().VerificarEdad(); break;
                        case 7: new DiaSemana().MostrarDia(); break;
                        case 8: new CalificacionSwitch().ConvertirCalificacionSwitch(); break;
                        case 9: salir = true; break;
                        default: Console.WriteLine("Opción no válida."); break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, introduce una opción válida.");
                }

                Console.WriteLine(); 
            }

            Console.WriteLine("¡Gracias por usar el programa!");
        }
    }
}