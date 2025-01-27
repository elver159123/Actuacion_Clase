# Programas en C# con Menú de Opciones

Este repositorio contiene un conjunto de programas realizados en C# utilizando programación orientada a objetos (POO). Los programas están organizados bajo un menú interactivo que permite al usuario seleccionar la funcionalidad que desea ejecutar.

## Descripción

El programa principal proporciona un menú con las siguientes opciones:

1. **Juego: Adivina el número**

   - Genera un número aleatorio entre 1 y 100 y permite al usuario intentar adivinarlo mediante pistas (mayor, menor, igual).

2. **Determinar si puedes votar**

   - Solicita la edad del usuario y verifica si es mayor o igual a 18 años para determinar si puede votar.

3. **Convertir calificación numérica a letra**

   - Convierte una calificación numérica (0-100) en una letra según el siguiente criterio:
     - 90-100: A
     - 80-89: B
     - 70-79: C
     - 60-69: D
     - 0-59: F

4. **Determinar si un número es par o impar**

   - Permite al usuario introducir un número entero y verifica si es par o impar.

5. **Determinar el número mayor**

   - Solicita dos números al usuario y muestra cuál de ellos es mayor o si son iguales.

6. **Edad suficiente para votar**

   - Solicita la edad del usuario y muestra si cumple con la edad mínima (18 años) para votar.

7. **Día de la semana (switch)**

   - Solicita un número entre 1 y 7 y muestra el nombre del día correspondiente (Lunes, Martes, etc.).

8. **Calificación a letra (switch)**

   - Convierte una calificación numérica (0-100) a una letra utilizando una sentencia `switch`.

9. **Salir**

   - Permite al usuario salir del programa.

## Estructura del Proyecto

El código está estructurado en diferentes clases, cada una representando una funcionalidad específica:

- `MenuPrincipal`: Gestiona el menú principal e interactúa con el usuario.
- `AdivinaElNumero`: Contiene la lógica del juego para adivinar el número.
- `Votacion`: Determina si el usuario puede votar según su edad.
- `Calificacion`: Convierte una calificación numérica en letra.
- `ParOImpar`: Determina si un número es par o impar.
- `NumeroMayor`: Compara dos números y determina cuál es mayor.
- `EdadVotacion`: Verifica si el usuario tiene la edad suficiente para votar.
- `DiaSemana`: Muestra el día de la semana según un número usando un `switch`.
- `CalificacionSwitch`: Convierte una calificación numérica en letra utilizando un `switch`.

## Requisitos

- .NET SDK (versión 6.0 o superior)
- Un editor de texto o IDE compatible con C#, como Visual Studio o Visual Studio Code.


## Uso

1. Al ejecutar el programa, se mostrará un menú con las opciones disponibles.
2. Introduce el número correspondiente a la opción que deseas ejecutar.
3. Sigue las instrucciones en pantalla.

## Ejemplo de Ejecución

### Menú Principal:

```
=== Menú Principal ===
1. Juego: Adivina el número
2. Determinar si puedes votar
3. Convertir calificación numérica a letra
4. Determinar si un número es par o impar
5. Determinar el número mayor
6. Edad suficiente para votar
7. Día de la semana (switch)
8. Calificación a letra (switch)
9. Salir
Selecciona una opción: _
```


¡Gracias por usar este programa! ¡Esperamos que sea útil! 😊

