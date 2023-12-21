using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosMartes13 : MonoBehaviour
{
    // Podemos hacerlo con un array de char, pero es mucho m�s engorroso crearlo
    private char[] arrayDNI = {'T', 'R', 'W', 'A', 'G', '5'};

    // Tambi�n nos sirve un string, porque se comporta como un array de caracteres
    private string letrasDNI = "TRWAGMYFPDXBNJZSQVHLCKE";

    // Start is called before the first frame update
    void Start()
    {
        //Ejercicio1_Impares();

        /*
        Debug.Log(Ejercicio2_Factorial(0));
        Debug.Log(Ejercicio2_Factorial(1));
        Debug.Log(Ejercicio2_Factorial(2));
        Debug.Log(Ejercicio2_Factorial(5));
        Debug.Log(Ejercicio2_Factorial(8));
        */

        /*
        int DNI_Ejemplo1 = 99999999;
        int DNI_Ejemplo2 = 00000000;

        Debug.Log(DNI_Ejemplo1.ToString() + Ejercicio3_DNI(DNI_Ejemplo1));
        Debug.Log(DNI_Ejemplo2.ToString() + Ejercicio3_DNI(DNI_Ejemplo2));
        */

        int[] listaNumeros1 = { 0, 2, 4, 5, 23, 2432, 34354, 111, 353533, 0, 13 };
        int[] listaNumeros2 = { -5, -300, -1, -2000, -5000, -949994 };

        Debug.Log(Ejercicio5_MinimoLista(listaNumeros1));
        Debug.Log(Ejercicio5_MinimoLista(listaNumeros2));
    }


    // Ejercicio 1 - Muestra impares entre 0 y 30
    public void Ejercicio1_Impares()
    {
        for(int i = 0; i <= 30; i++)
        {
            // Un n�mero es impar, si su m�dulo de 2 es distinto de 0 (numero%2!=0)
            if(i%2 != 0) // Si i es impar (su m�dulo de 2 es distinto de 0)
            {
                Debug.Log(i); // Escribimos i
            }
        }
    }

    // Ejercicio 2 - Factorial de un n�mero
    public int Ejercicio2_Factorial(int n)
    {
        // Creo variable factorial
        int factorial = 1; // Su valor m�nimo siempre ser� 1

        // Calculo del factorial para el resto de n�meros
        // P.ej. factorial del 3, ser�a 3 x 2 x 1
        // factorial *= 3; factorial *= 2; factorial *= 1; 

        // Recorremos desde el n�mero del que sacamos el factorial hasta el 1 (no incluido)
        for(int i = n; i > 1; i--)
        {
            // Multiplicamos el factorial por el n�mero i
            factorial *= i; // factorial = factorial * i;
        }

        // Devuelvo el factorial
        return factorial;
    }

    // Ejercicio 3 - Letra del DNI
    public char Ejercicio3_DNI(int numeroDNI)
    {
        // Calcular el m�dulo 23 del n�mero del DNI ( %23)
        int modulo = numeroDNI%23;

        // Una vez lo tenga, puedo devolver la letra en la posici�n m�dulo 23 del string de letras DNI
        char letra = letrasDNI[modulo];

        return letra; // Devuelvo la letra
    }

    // Ejercicio 4 - M�ximo elemento en una lista
    public int Ejercicio4_MaximoLista(int[] lista)
    {
        // Creamos una variable int para el m�ximo, inicializada con el m�nimo valor posible
        // Tambi�n podr�amos crearla con el valor del primer n�mero lista[0]
        int max = int.MinValue;

        // Recorremos la lista en un bucle for
        for(int i = 0; i < lista.Length; i++)
        {
            // Si el n�mero de la posici�n i de la lista es mayor que el m�ximo, lo actualizamos
            if (max < lista[i]) max = lista[i];
            // max = Mathf.Max(max, lista[i]); //Para comparar dos n�meros podemos usar la Mathf.Max
        }

        // Devolvemos el mayor n�mero que hubiera en la lista
        return max;
    }

        // Ejercicio 5 - M�nimo elemento en una lista
    public int Ejercicio5_MinimoLista(int[] lista)
    {
        // Creamos una variable int para el m�nimo, inicializada con el m�ximo valor posible
        // Tambi�n podr�amos crearla con el valor del primer n�mero lista[0]
        int min = int.MaxValue;

        // Recorremos la lista en un bucle for
        for (int i = 0; i < lista.Length; i++)
        {
            // Si el n�mero de la posici�n i de la lista es menor que el m�numo, lo actualizamos
            if (lista[i] < min) min = lista[i];
            // min = Mathf.Min(min, lista[i]); //Para comparar dos n�meros podemos usar la Mathf.Min
        }

        // Devolvemos el menor n�mero que hubiera en la lista
        return min;
    }
}
