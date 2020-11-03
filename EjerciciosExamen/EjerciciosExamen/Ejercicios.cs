using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EjerciciosExamen
{
    class Ejercicios
    {
        //Hacer una funcion que reciba dos enteros y devuelva la suma de esos dos enteros
        public static int Ejercicio01(int a, int b)
        {
            int result = a + b;
            return result;
            //Seria mejor, directamente poner un return a + b;
        }

        //Funcion que reciba dos reales y devuelva la resta de esos dos reales
        public static float Ejercicio02(float a, float b)
        {
            return a - b;
        }

        //Funcion que reciba dos enteros y devuelva el menor de los dos
        public static int Ejercicio03(int a, int b)
        {

            if (a > b)
                return b;
            else
                return a;
            //Si hay una sola instruccion, es recomendable quitar los corchetes para más nota. El profe nos enseñará otra
            // if (a < b)
            //  return a;
            //return b;
        }

        //Funcion que reciba dos enteros y devuelva si el primero es menor que el segundo
        public static bool Ejercicio04(int a, int b)
        {
            if (a < b)
                return true;
            
            return false;
            //Es correcta, ahorrar la mayor cantidad de espacio posible.
            // Directamente poner return a < b;
        }

        //Funcion que reciba 3 strings y devuelva al concatenacion de estos 3 strings
        public static string Ejercicio05(string s1, string s2, string s3)
        {
            return s1 + s2 + s3;
        }

        //Funcion que reciba dos enteros y devuelva -1 si el primero es menor que el segundo, +1 si el segundo es menor que el primero, y 0 en cualquier otro caso
        public static int Ejercicio06(int a, int b)
        {
            if (a < b)
                return - 1;
            else if (a > b) //Aquí puedes quitar el else
                return + 1; //Aquí, quitar el más
            else //Aquí te puedes ahorrar el else, porque si no se da ninguno de los casos anteriores, llegará aquí de todas maneras. Se ahorraría espacio y sería mejor
                return 0;
        }

        //Funcion que reciba un código de error e imprima por pantalla "Error critico, en caso de que el codigo sea 0".
        //Error leve si el codigo es uno
        //Error moderado en caso de que el error sea 2
        //Error desconocido en cualquier otro caso

        //public static string Ejercicio07(System.Exception e) Todo mal
        //{
        //            
        //
        //}
        public static void PrintError(int code) //Void porque no devuelve nada, solo imprime. Este es el método ideal
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error crítico");
                    break;
                case 1:
                    System.Console.WriteLine("Error leve");
                    break;
                case 2:
                    System.Console.WriteLine("Error moderado");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;

            }
        }

        //Un procedimiento es una funcion que devuelve void
        //Funcion que reciba por parametro un numero y escriba lo siguiente:
        //0, 3, 6, 12 ... hasta llegar a ese número
        //Ejemplo Funcion (10) imprimiría 0, 3, 6, 9

       public static void Ejercicio08(int n)
        {
            int i = 0;
            while (i <= n)
            {
                System.Console.Write(i + ", ");
                i += 3;
            }
        }

        //For usa en sus parametros una variable, una condicion y un incremento. Es parecido al while pero en alunos casos interesa usar mejor uno u otro,
        // en el anterior es más recomendable emplear un while, porque no sabemos el número concreto de veces que queremos prolongar el bucle.
        //Estructura for ( (1)int (2)i= 0; (3) i < 10; i++)
        //3


        //Funcion que se le pasen 3 enteros y devuelva el menor de los 3
        public static int Ejercicio09(int a, int b, int c)
        {
            if ((a < b) && (a < c)) // a<= b && a<=c
                return a;
            else if ((b < a) && (b < c)) // b<= a && b<=c
                return b;
            else if ((c < a) && (c < b)) //Aquí, return y fuera
                return c;
            else //En el caso de que los tres números sean iguales, se devolverá 0
                return 0;
        }

        public static int Ejercicio09Sol(int a, int b, int c)
        {
            if (a<=b)
            {
                if (a < c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b < c)
                    return b;
                else
                    return c;
            }
        }

        //Se le pasa 4 enteros y devuelva el menor de los 4
        public static int Ejercicio10(int a, int b, int c, int d)
        {
            if (a < b) //descartada la b           
                return Ejercicio09Sol(a, c, d);                                                    
            else            
                return Ejercicio09Sol(b, c, d);                        
        }

        //Ejercicio con for. Funcion que se le pase un entero e imprima por pantalla las siguiente series de ejemplo
        //serie (10) -> 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        public static void Ejercicio11(int n)
        {
            string PrintSerie = "";
            for (int i = 0; i < n; i++)
                PrintSerie += Convert.ToInt32(i) + ", ";
            System.Console.WriteLine(PrintSerie);
        }

        //Lo mismo pero sin la coma
        public static void Ejercicio12(int n)
        {

            for (int i = 1; i < n; i++)
            {
                if (i == (n - 1))                
                    System.Console.Write(i);
                else
                    System.Console.Write(i + ", ");
            }                            
        }

        public static void Ejercicio12Sol(int n)
        {
            if (n > 0)
                System.Console.Write(0);

            for (int i = 1; i < n; i++)
                    System.Console.Write(", " + i);            
        }

        //Funcion que se le pase un numero entero e imprima una linea de tantos astericos como es el número
        //astericos(4) ****
        public static void Ejercicio13(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write("*");
        }

        //Funcion que le pasas un numero e imprime el siguiente patron
        //asteriscos(4) -> *+*+*
        public static void Ejercicio14(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    System.Console.Write("*");
                else
                System.Console.Write("+");
            }
        }

        //Funcion que le pasas entero e imprime el suguiente patron
        //astericos (10) *+-/
        public static void Ejercicio15(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int resto = i % 4;
                switch (resto)
                {
                    case 0:
                        System.Console.Write("*");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("-");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;                                           
                }
            }
        }
        
        //Ejercicio para casa
        //Funcion que se le pasa numero entero e imprima algo como lo siguiente
        //funcion(3)
        //***
        //***
        //***

        //funcion(4)
        //****
        //****
        //****
        //****


    }
}
