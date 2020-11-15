using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;
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

        public static void EjercicioCasa(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                    System.Console.Write("*");
                System.Console.WriteLine();
            }
        }

        //Funcion que devuelva el menor de 16 enteros pero
        //debe ocupar una sola línea
        public static int Ejercicio16(int n1, int n2, int n3, int n4, int n5, 
            int n6, int n7, int n8, int n9, int n10, int n11, int n12, int n13,
            int n14, int n15, int n16)
        {
            int menor1 = Ejercicio10(n1, n2, n3, n4);
            int menor2 = Ejercicio10(n5, n6, n7, n8);
            int menor3 = Ejercicio10(n9, n10, n11, n12);
            int menor4 = Ejercicio10(13, n14, n15, n16);
            return Ejercicio10(menor1, menor2, menor3, menor4);
        }
        
        //Igual que la de casa, solo que en lugar de imprimir astericos, es en plan
        //(4)
        //****
        //++++
        //****
        //++++
        //Variables r, i, c
        public static void Ejercicio17(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if ((r % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }

        //Funcion igual que la anterior, pero que imprima 
        //*+*+
        //+*+*
        //*+*+
        //+*+*
        public static void Ejercicio18(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if ((c % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }

        public static void Ejercicio18Sol(int n)
        {
            for (int r = 0; r < n; r++)
            {
               for(int c = 0; c < n; c++)
                {
                    int flag = r + c;
                    if ((flag % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");

                }
                System.Console.WriteLine();
            }
            
        }
        //recibe un numero, pero lo que imprime es
        //4
        //*
        //**
        //***
        //****
        public static void Ejercicio19(int n)
        {
            for (int r = 0; r < n; r++)
            {                
                for (int c = 0; c <= r; c++)
                {                    
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }

        //Como el anterior pero
        //4
        //   *
        //  **
        // ***
        //****
        //Si le pasaramos un cinco, la primera seria no comenzaria con 3 espacios, sino con 4, ocupando 5 caracteres en tortal

        public static void Ejercicio20(int n)
        {
            for (int r = 0; r < n; r++)
            {
                int nEspacios = n - r - 1; // n - (r + 1);               
                int nAsteriscos = r + 1;

                for (int c = 0; c < nEspacios; c++)
                    System.Console.Write(" _ ");
                for (int c = 0; c < nAsteriscos; c++)
                    System.Console.Write(" * ");
                System.Console.WriteLine();
            }                                           
        }

        //Funcion que imprima por pantalla los numeros divisores del número dado
        public static void Ejercicio21(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    System.Console.Write(i + ", ");
            }
        }

        //_ _ _ _ * *
        //_ _ _ * _ _ *
        //_ _ * _ _ _ _ *
        //_ * _ _ _ _ _ _ *
        //* _ _ _ _ _ _ _ _ *
        public static void Ejercicio22(int n)
        {
            for (int r = 0; r < n; r++)
            {
                int nEspacios1 = n - r - 1;
                int nEspacios2 = 2 * r;

                for (int c = 0; c < nEspacios1; c++)
                    System.Console.Write(" _ ");
                System.Console.Write(" * ");
                for (int c = 0; c < nEspacios2; c++)
                    System.Console.Write(" _ ");
                System.Console.WriteLine(" * ");
            }
            
        }
        //Al reves que la anterior
        //El anterior, invertido

        public static void Ejercicio23(int n)
        {
            for (int r = 0; r < n; r++)
            {
                int nEspacios1 = r;
                int nEspacios2 = (n - r - 1) * 2;

                for (int c = 0; c < nEspacios1; c++)
                    System.Console.Write(" _ ");
                System.Console.Write(" * ");
                for (int c = 0; c < nEspacios2; c++)
                    System.Console.Write(" _ ");
                System.Console.WriteLine(" * ");

            }
            
        }

        public static void Ejercicio24(int n)
        {            
            Ejercicio22(n);
            Ejercicio23(n);           
        }

        //Funcion que devuelva 2 elevado a 1 número entero
        public static int Ejercicio25(int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
                result *= 2;
            return result;
        }
        //for r > 8
        //for c < 20
        //
        // * _ * _ * _ *****
        // _ * _ * _ * *****
        // * _ * _ * _
        // _* _ * _*
        // *****************
        // *****************
        //
        //
        // *****************
        public static void Ejercicio26()
        {
            

            for ( int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 20; c++)
                {
                    int flag = c + r;
                    if (c >= 0 && c <= 5 && r >= 0 && r <= 2)
                    {
                         //Aquí hay que hacer los espacios de los puntos
                        //if flag par, punto, else espacio
                        if (flag % 2 == 0)
                            System.Console.Write(" * ");
                        else
                            System.Console.Write("   ");
                    }                        
                    else if (((r / 2) % 2) == 0)
                        System.Console.Write(" * ");
                    else 
                        System.Console.Write("   ");
                }
                System.Console.WriteLine();
            }
        }

        //Practica de hacer una app con un menú, con opciones que hacen una única cosa. las funciones en model, interfaz en visual con todo lo que se imprime, y controller 
        //1) Potencia en base 2
        //2) Sacar el sumatorio ( el sumatorio de 10 es, 1 + 2 + 3+ 4+5+6+7+8+9+10 = resultado
        //3) ! factorial de 10: 1*2*3*4*5*6*7*8*9*10
        //4) Saber si un número es primo
        //5) Imprimir la serie de fibonacci
        //0) Salir



        //Sumatorio z6= 1+2+3+4+5+6
        public static int Ejercicio27(int n)
        {
            int sumatorio = 0;
            for (int i = 0; i <= n; n++)            
                sumatorio += i;
            
            return sumatorio;
        }



    }


}
