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

            int[] seq = new int[3] {1,1,2};


            DesafioCodeWarsEight(seq);

           
            string Nombre = "oxx";
          


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

        public static int DesafioCodeWars(int[] seq)
        {
            int MasChico = int.MaxValue;
            int SegundoMasChico = int.MaxValue;

            for (int i = 0; i < seq.Length; i++)
            {
                if (MasChico > seq[i])
                {
                    SegundoMasChico = MasChico;
                    MasChico = seq[i];
                }
                else if (SegundoMasChico > seq[i])
                {
                    SegundoMasChico = seq[i];
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

        public static int DesafioCodeWarsThree(int num)
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

        public static string DesafioCodeWarsFour(string palabra)
        {
            int lenght = palabra.Length;

            int l = 1 - palabra.Length % 2;

            string b = palabra.Substring(palabra.Length / 2 - l, 1 + l);

            return b;
        }

        public static bool DesafioCodeWarsFive(string input)
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

        public static int[] DesafioCodeWarsSix(int n)
        {
            List<int> add_list = new List<int>();

           
                for (int i = 2; i <= n - 1 ; i++)
                {
                    if (n % i == 0)
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

        public static string DesafioCodeWarsSeven(string word)
        {
            string caracteres = ""; 
            int contador = 0;
            string palabraMinuscula = word.ToLower();string b = "";

            for (int i = 0; i < palabraMinuscula.Length; i++)
            {
                for (int w = 0; w < palabraMinuscula.Length; w++)
                {
                    if (palabraMinuscula[i] == palabraMinuscula[w])
                    {
                        contador = contador + 1;
                        if (contador > 1)
                        {
                            caracteres += ")";
                            break;
                        }
                    }
                }
                if (contador < 2)
                {
                    caracteres += "(";
                }
                contador = 0;
            }

            return caracteres;
        }

        public static int DesafioCodeWarsEight(int[] seq)
        {
            int n = 0;
            int acumulador = 0;
            int retorno = 0;
            for (int i = 0; i < seq.Length; i++)
            {

                n = seq[i];
                acumulador = 0;
                Console.WriteLine($"En la posicion {i} del numero {seq[i]}");

                for (int z = 0; z < seq.Length; z++)
                {
                    if (n == seq[z])
                    {
                        acumulador = acumulador + 1;
                        Console.WriteLine($"El acumulador es {acumulador}");
                    }


                }
                if (acumulador % 2 != 0)
                {
                    Console.WriteLine($"Es impar el numero {seq[i]}");
                    retorno = seq[i];
                }

            }

            return retorno;
        }
        
    }
}
