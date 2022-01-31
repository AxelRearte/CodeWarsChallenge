using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[3];

            array[0] = 40;
            array[1] = 35;
            array[2] = 45;

            int[] arreglo = new int[9] {1,2,3,4,5,6,7,8,9};
            

            string Nombre = "oxx";

            string palabra = "El Avion";

            int a = 10;

            DesafioCodeWarsSix(a);

            int s;
          

            //Console.WriteLine(b);
            //Console.WriteLine(lenght);

            Console.ReadKey();

        }

        public static int Valores(int[] numeros)
        {
            int min = numeros.Min();

            Array.Sort(numeros);

            var numero = numeros[0] + numeros[1];

            Console.WriteLine(numero);

            return numero;
        }

        public static int DesafioCodeWars(int[] arreglo)
        {
            int MasChico = int.MaxValue;
            int SegundoMasChico = int.MaxValue;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (MasChico > arreglo[i])
                {
                    SegundoMasChico = MasChico;
                    MasChico = arreglo[i];
                }
                else if (SegundoMasChico > arreglo[i])
                {
                    SegundoMasChico = arreglo[i];
                }
            }

            Console.WriteLine("Primero " + MasChico);
            Console.WriteLine("segundo " + SegundoMasChico);

            return MasChico + SegundoMasChico;
        }

        public static int DesafioCodeWarsTwo(int[] num)
        {
            int numero = 0;

            for (int i = 0; i < num.Length; i++)
            {
                 numero = num[i];

                if (numero % 3 == 0 || numero % 5 == 0)
                {
                    Console.WriteLine(numero);
                }
               
            }
             return numero;
        }

        public static int DesafioCodeWardsThree(int num)
        {
            int otro = 0;
            int b = 0;

            for (int i = 0; i < num; i++)
            {
                otro = i;

                if (otro % 3 == 0 || otro % 5 == 0)
                {
                    b = b + otro;
                }
            }
            
            return b;
        }

        public static string DesafioCodeWardsFour(string palabra)
        {
            int lenght = palabra.Length;

            int l = 1 - palabra.Length % 2;

            string b = palabra.Substring(palabra.Length / 2 - l, 1 + l);

            return b;
        }

        public static bool DesafioCodeWardsFive(string input)
        {
            bool t = false;

            var nombreMinuscula = input.ToLower();

            var a = 'x';
            var b = 'o';

            int contadorx = nombreMinuscula.Count(f => (f == a));
            int contadoro = nombreMinuscula.Count(f => (f == b));

            if (contadoro == contadorx && contadoro != 0 && contadorx != 0)
            {
                t = true;
                Console.WriteLine("Tienen los numeros x y o");
            }
            if (contadoro == 0 && contadorx == 0)
            {
                t = true;
                Console.WriteLine("No hay x ni o");
            }
            if (contadoro != 0 && contadorx != 0 && contadoro != contadorx)
            {
                Console.WriteLine("No tienen la misma cantidad de x y o");
            }

            return t;
        }

        public static int[] DesafioCodeWarsSix(int a)
        {
            List<int> add_list = new List<int>();

           
                for (int i = 2; i <= a - 1 ; i++)
                {
                    if (a % i == 0)
                    {
                        add_list.Add(i);
                }
                }
            if (add_list.ToArray().Length < 1)
            {
                return null;
            }
            else
            {
                
                return add_list.ToArray();
            }
        }

    }
}
