using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Coordenadas
{
    class Program
    {
        private static int N = 5;//tamaño matriz
        private static String[,] M = {{"","","","",""},//matriz cuadrada
                                      {"","","","",""},
                                      {"","","","",""},
                                      {"","","","",""},
                                      {"","","","",""}};

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;//color de consola visible para el usuario
            Console.ForegroundColor = ConsoleColor.Green;//color de letras visibles para el usuario
            Console.Clear();

            inicio();//llama metodo inicio
        }
        //procedimiento que inicia toda la aplicacion
        public static void inicio()
        {
            String seguir = "y";//variable de continuidad
            Boolean flag = true;//variable para pedir cordenadas

            Console.WriteLine("La matriz cuadrada de {0}x{1}.\n",N,N);//imprime tamaño matriz
            
            while (flag)//mientras sea verdadero
            {
                if (seguir.Equals("y"))//si se presion  'y'
                {
                    Console.ForegroundColor = ConsoleColor.Green;//color de letras visibles para el usuario
                    try
                    {
                        seguir = ingresaCoordenada().ToLower();//ingresa coordenada
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ingrese la coordenada correctamente.");
                    }
                }
                else
                {
                    flag = false;//cambia a false para salir del while
                    mostrarMatrizCuadrada(M);//muestra en pantalla la matriz
                }
            }
        }
        //Funcion que captura coordenada y las guarda
        public static String ingresaCoordenada()
        {
            Console.WriteLine("Ingrese coordenadas < x,y >: ");//pide que ingrese mas coordenadas

            String seguir = null;
            String coordenada = Console.ReadLine();//captura el input con la coordenada
            String[] split = coordenada.Split(',');//separa las coordenadas
            int x = int.Parse(split[0]);//convierte 'x' en entero
            int y = int.Parse(split[1]);//convierte 'y' en entero


            if (x <= N && x > 0 && y <= N && y > 0)//si el las coordenadas se encuentran entre 1 y 5 tanto en 'x' como en 'y'
            {
                M[x-1, y-1] = "*";//agregar a la matriz un *                 
                Console.WriteLine("Desea continuar con la captura de coordenadas?: Y/N");
                seguir = Console.ReadLine();//lee si es 'y' o 'n'
            }

            return seguir;
        }

        //procedimiento que mustra la matriz poe consola.
        public static void mostrarMatrizCuadrada(String[,] M)
        {
            Console.WriteLine("\n\n");//crea un distancia para mostrar matriz
            Console.WriteLine("Salida");

            for (int c = 0; c < N; c++)//recorre columnas
            {
                for (int f = 0; f < N; f++)//recorre filas
                {
                    Console.Write("   {0}\t|", M[c, f]);//mustra el valor de la fila,columna agregando un espacio
                }
                Console.WriteLine("\n");//crea un salto de lines
            }
            Console.ReadLine();//espera para salir del programa
        }
    }
}