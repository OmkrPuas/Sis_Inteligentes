using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Porotos
{
    public class _8_puzzle
    {

        public List<int> tablero { get; set; }
        public _8_puzzle()
        {
            List<int> tablero = new List<int>();
            Console.WriteLine("Tablero construido");
        }

        public void BFS_preparar(int n)
        {
            List<int> tablero = new List<int>();
            int posicion = 0;

            for (int i = 0; i < (n*n); i++)
            {
                tablero.Add(posicion);
            }
            string line;
            StreamReader sr = new StreamReader("D:/Unicato/Semestres/2-2021/Sistemas inteligentes/Porotos/Porotos/Tareas/8_puzzle.txt");
            line = sr.ReadLine();
            int inicial = Int32.Parse(line);
            line = sr.ReadLine();
            int final = Int32.Parse(line);

            sr.Close();

            Console.WriteLine(inicial);
            Console.WriteLine(final);

            int var = inicial;

            Console.WriteLine(tablero[5]);
            for (int i = (n*n)-1; i >= 0; i--)
            {
                tablero[i] = var % 10;
                var = var / 10;
            }
            string res = BFS(tablero, inicial, final, n);
            Console.WriteLine(res);

        }

        public string BFS(List<int> tablero, int inicial, int final, int n)
        {
            string res = "";
            List<int> cola = new List<int>();
            List<string> pasos = new List<string>();
            pasos.Add("");
            int pasos_encontrado = 0;
            cola.Add(inicial);
            int pos_cola = 0;
            int pos = 0;
            bool bandera = false;
            int estado = 0;
            int a = (int)Math.Pow(10, n-1);
            for (int i = 0; i < (n*n); i++)
            {
                estado=estado + (tablero[i]*a);
                a = a / 10;
            }

            while (!bandera)
            {
                int ace = 0;
                for(int j = 0; j < n*n; j++)
                {
                    if(tablero[j] == j)
                    {
                        ace++;
                    }
                }
                if (ace == n*n)
                {
                    bandera = true;
                    pasos_encontrado = pasos.Count-1;
                    res = "Los pasos son: " + pasos[pos_cola-1];
                    Console.WriteLine("encontrado!");
                }
                else
                {
                    if (pos_cola < cola.Count)
                    {

                        int estado_cola = cola[pos_cola];
                        pos_cola++;

                        for (int i = (n * n) - 1; i >= 0; i--)
                        {
                            tablero[i] = estado_cola % 10;
                            estado_cola = estado_cola / 10;
                            //Console.WriteLine(tablero[i]);
                        }

                        for (int i = 0; i < (n * n); i++)
                        {
                            if (tablero[i] == 0)
                            {
                                pos = i;
                                //Console.WriteLine("Posicion: " + pos);
                            }
                        }

                        if (pos != (n * n) - 1 && pos != 2 && pos != 5)
                        {
                            //Console.WriteLine("Izquierda : " + tablero[pos+1] + " a " + tablero[pos]);
                            tablero[pos] = tablero[pos + 1];
                            tablero[pos + 1] = 0;
                            string pas = pasos[pos_cola - 1] + "Izquierda, ";
                            aumentarCola(cola, tablero, n * n, pasos, pas);
                            tablero[pos + 1] = tablero[pos];
                            tablero[pos] = 0;
                        }

                        if (pos < (n * n) - n)
                        {
                            //Console.WriteLine("Arriba : " + tablero[pos + n] + " a " + tablero[pos]);
                            tablero[pos] = tablero[pos + n];
                            tablero[pos + n] = 0;
                            string pas = pasos[pos_cola - 1] + "Arriba, ";
                            aumentarCola(cola, tablero, n * n, pasos, pas);
                            tablero[pos + n] = tablero[pos];
                            tablero[pos] = 0;

                        }

                        if (pos != 0 && pos != 3 && pos != 6)
                        {
                            //Console.WriteLine("Derecha : " + tablero[pos - 1] + " a " + tablero[pos]);
                            tablero[pos] = tablero[pos - 1];
                            tablero[pos - 1] = 0;
                            string pas = pasos[pos_cola-1] + "Derecha, ";
                            aumentarCola(cola, tablero, n * n, pasos, pas);        
                            tablero[pos - 1] = tablero[pos];
                            tablero[pos] = 0;

                        }

                        if (pos > 2)
                        {
                            //Console.WriteLine("Abajo : " + tablero[pos - n] + " a " + tablero[pos]);
                            tablero[pos] = tablero[pos - n];
                            tablero[pos - n] = 0;
                            string pas = pasos[pos_cola - 1] + "Abajo, ";
                            aumentarCola(cola, tablero, n*n, pasos, pas);
                            tablero[pos - n] = tablero[pos];
                            tablero[pos] = 0;
                        }
                    }
                    else
                    {
                        bandera = true;
                        if(pasos_encontrado == 0) {
                            res = "No se puede resolver :(";
                        }                    
                    }

                }

            }
            for(int i = 0; i < n*n; i++)
            {
                Console.Write(tablero[i]);
            }
            Console.WriteLine();
            Console.WriteLine("La cantidad de estados extendidos son: " + pasos.Count);
            Console.WriteLine("La cantidad de estados extendidos hasta encontrar la solucion es: " + pasos_encontrado);
            return res;
        }

        public void aumentarCola(List<int> cola, List<int> tablero, int n, List<string> pasos, string paso) {
            int estado = 0;
            int a = (int)Math.Pow(10, n - 1);
            for (int i = 0; i < n; i++)
            {
                estado = estado + (tablero[i] * a);
                a = a / 10;
            }
            bool bandera = true;
            for(int i = 0; i < cola.Count; i++)
            {
                if(cola[i] == estado)
                {
                    bandera = false;
                }
            }
            if (bandera)
            {
                cola.Add(estado);
                pasos.Add(paso);
                Console.WriteLine("Aumentando: " + estado);
            }
        }

        

    }
}
