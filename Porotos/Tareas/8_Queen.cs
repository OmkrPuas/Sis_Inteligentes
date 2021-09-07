using System;
using System.Collections.Generic;
using System.Text;


namespace Porotos
{
    public class _8_Queen
    {
        public List<int> tablero { get; set; }
        public _8_Queen()
        {
            List<int> tablero = new List<int>();
            Console.WriteLine("Tablero construido");
        }

        public void Proceso_Fuerza_Bruta()
        {
            List<int> tablero = new List<int>();
            Console.WriteLine("Entrando a proceso");
            Console.WriteLine(tablero);
            int posicion = 0;
            for (int i = 0; i < 8; i++)
            {
                tablero.Add(posicion);
            }
            Console.WriteLine("Tablero con Reinas");
            tablero.ForEach(Console.Write);
            Console.WriteLine();
            int cant_respuestas = 0;
            int permutaciones = 0;
            int escenarios = 0;
            for(int i = 1; i < 9; i++)
            {
                tablero[0] = i;
                for (int j = 1; j < 9; j++)
                {
                    tablero[1] = j;
                    for (int a = 1; a < 9; a++)
                    {
                        tablero[2] = a;
                        for (int b = 1; b < 9; b++)
                        {
                            tablero[3] = b;
                            for (int c = 1; c < 9; c++)
                            {
                                tablero[4] = c;
                                for (int d = 1; d < 9; d++)
                                {
                                    tablero[5] = d;
                                    for (int e = 1; e < 9; e++)
                                    {
                                        tablero[6] = e;
                                        for (int f = 1; f < 9; f++)
                                        {
                                            tablero[7] = f;
                                            escenarios++;
                                            if (permutacion(tablero))
                                            {
                                                permutaciones++;
                                                if (revisar(tablero))
                                                {
                                                    tablero.ForEach(Console.Write);
                                                    Console.WriteLine();
                                                    cant_respuestas++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
            }
            Console.WriteLine("Hay " +cant_respuestas + " respuestas posibles!");
            Console.WriteLine("Hay " + escenarios + " posibles escenarios!");
            Console.WriteLine("Hay " + permutaciones + " posibles permutaciones sin repeticion!");
        }

        public void Proceso_Fuerza_Bruta_Reducido()
        {
            List<int> tablero = new List<int>();
            Console.WriteLine("Entrando a proceso");
            Console.WriteLine(tablero);
            int posicion = 1;
            for (int i = 0; i < 8; i++)
            {
                tablero.Add(posicion);
            }
            Console.WriteLine("Tablero con Reinas");
            tablero.ForEach(Console.Write);
            Console.WriteLine();
            int cant_respuestas = 0;
            int escenarios = 0;
            for (int i = 1; i < 9; i++)
            {
                tablero[0] = i;
                for (int j = 1; j < 9; j++)
                {
                    tablero[1] = j;
                    if (revisar_casilla(tablero, 1))
                    {
                        for (int a = 1; a < 9; a++)
                        {
                            tablero[2] = a;
                            if (revisar_casilla(tablero, 2))
                            {
                                for (int b = 1; b < 9; b++)
                                {
                                    tablero[3] = b;
                                    if (revisar_casilla(tablero, 3))
                                    {
                                        for (int c = 1; c < 9; c++)
                                        {
                                            tablero[4] = c;
                                            if (revisar_casilla(tablero, 4))
                                            {
                                                for (int d = 1; d < 9; d++)
                                                {
                                                    tablero[5] = d;
                                                    if (revisar_casilla(tablero, 5))
                                                    {
                                                        for (int e = 1; e < 9; e++)
                                                        {
                                                            tablero[6] = e;
                                                            if (revisar_casilla(tablero, 6))
                                                            {
                                                                for (int f = 1; f < 9; f++)
                                                                {
                                                                    tablero[7] = f;
                                                                    if (revisar_casilla(tablero, 7))
                                                                    {
                                                                        escenarios++;
                                                                        if (revisar_completo(tablero))
                                                                        {
                                                                            tablero.ForEach(Console.Write);
                                                                            Console.WriteLine();
                                                                            cant_respuestas++;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        if(f == 8)
                                                                        {
                                                                            escenarios++;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            Console.WriteLine("Hay " + cant_respuestas + " respuestas posibles!");
            Console.WriteLine("Hay " + escenarios + " posibles escenarios!");
        }

        public void Proceso_corto(int reinas)
        {
            List<int> tablero = new List<int>();
            Console.WriteLine("Entrando al proceso corto");
            Console.WriteLine(tablero);
            int posicion = reinas;
            for (int i = 0; i < reinas; i++)
            {
                tablero.Add(posicion);
            }
            Console.WriteLine("Tablero con Reinas");
            tablero.ForEach(Console.Write);
            Console.WriteLine();
            int cant_respuestas = 0;
            int escenarios = 0;
            tablero[0] = 1;
            int reina = 1;
            int pos = 1;

            while (!posicion_final(tablero, reinas))
            {
                tablero[reina] = pos;
                if (revisar_casilla(tablero, reina))
                {
                    if (reina == 7)
                    {
                        if (revisar_completo(tablero))
                        {
                            cant_respuestas++;
                        }
                        escenarios++;
                        pos++;
                    }
                    else
                    {
                        reina++;
                        pos = 1;
                    }
                }
                else
                {
                    if (pos == 9)
                    {
                        reina--;
                        pos = tablero[reina] + 1;
                    }
                    else
                    {
                        if (pos < 8)
                        {
                            pos++;
                        }
                        else
                        {
                            if (reina < 7)
                            {
                                reina++;
                            }
                            else
                            {
                                if (revisar_completo(tablero))
                                {
                                    cant_respuestas++;
                                }
                                escenarios++;
                                reina--;
                                pos = tablero[reina] + 1;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Hay " + cant_respuestas + " respuestas posibles!");
            Console.WriteLine("Hay " + escenarios + " posibles escenarios!");
        }

        public bool posicion_final(List<int> tablero, int reinas)
        {
            bool res = true;
            for(int i = 0; i < reinas; i++)
            {
                if(tablero[i] < 8)
                {
                    res = false;
                }
            }
            return res;
        }

        public void Proceso_Recursivo()
        {
            List<int> tablero = new List<int>();
            Console.WriteLine("Entrando al proceso corto");
            Console.WriteLine(tablero);
            int posicion = 8;
            for (int i = 0; i < 8; i++)
            {
                tablero.Add(posicion);
            }
            Console.WriteLine("Tablero con Reinas");
            tablero.ForEach(Console.Write);
            Console.WriteLine();
            int cant_respuestas = 0;
            int escenarios = 0;

            for(int i = 1; i < 9; i++)
            {
                tablero[0] = i;
                (escenarios, cant_respuestas) = calcularEstados(tablero, 1, 1, escenarios, cant_respuestas);
            }
            
            Console.WriteLine("Hay " + cant_respuestas + " respuestas posibles!");
            Console.WriteLine("Hay " + escenarios + " posibles escenarios!");
        }

        public (int, int) calcularEstados(List<int> tablero, int reina, int pos, int escenarios, int cant_respuestas)
        {
            if (reina != 0)
            {
                if (pos < 9)
                {
                    if (reina < 8)
                    {
                        tablero[reina] = pos;
                        if (revisar_casilla(tablero, reina))
                        {
                            calcularEstados(tablero, reina + 1, 1, escenarios, cant_respuestas);
                        }
                        else
                        {
                            if (pos == 8)
                            {
                                calcularEstados(tablero, reina + 1, 1, escenarios, cant_respuestas);
                            }
                            else
                            {
                                calcularEstados(tablero, reina, pos + 1, escenarios, cant_respuestas);
                            }
                        }
                    }
                    else
                    {
                        if (revisar_completo(tablero))
                        {
                            cant_respuestas++;
                        }
                        calcularEstados(tablero, reina - 1, tablero[reina - 1] + 1, escenarios + 1, cant_respuestas);
                    }
                }
                else
                {
                    calcularEstados(tablero, reina - 1, tablero[reina - 1] + 1, escenarios, cant_respuestas);
                }
            }
            return (escenarios, cant_respuestas);
        }

        public bool revisar_casilla(List<int> tablero, int reina)
        {
            bool res = true;
            for(int i = reina-1; i>=0; i--)
            {
                if (res)
                {
                    if (tablero[reina] == tablero[i])
                    {
                        res = false;
                    }
                }
            }

            int var = 1;
            for (int i = reina - 1; i >= 0; i--)
            {
                if (res)
                {
                    if (tablero[reina] == (tablero[i] - var))
                    {
                        res = false;
                    }
                    else
                    {
                        if (tablero[reina] == (tablero[i] + var))
                        {
                            res = false;
                        }
                        else
                        {
                            var++;
                        }
                    }
                }
            }

            if (tablero[reina] == 8) res = true;
            return res;
        }

        public bool permutacion(List<int> tablero)
        {
            bool res = false;
            int veces = 0;
            int numero = 0;
            for (int j = 1; j < 9; j++)
            {
                if (veces == 0)
                {
                    numero = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        if (veces == 0)
                        {
                            if (tablero[i] == j)
                            {
                                numero++;
                                if (numero > 1)
                                {
                                    veces++;
                                }
                            }
                        }
                    }
                }
            }

            if (veces == 0)
            {
                res = true;
            }

            return res;
        }

        public bool revisar(List<int> tablero)
        {
            bool res = false;
            int veces = 0;

            if(veces == 0)
            {
                int numero_dos = 1;
                for(int i = 0; i < 7; i++)
                {
                    if (veces == 0)
                    {
                        numero_dos = 1;
                        for (int j = i + 1; j < 8; j++)
                        {
                            if ((tablero[i] + numero_dos) < 9)
                            {
                                if ((tablero[i] + numero_dos) == tablero[j])
                                {
                                    veces++;
                                }
                                else
                                {
                                    numero_dos++;
                                }
                            }
                        }
                    }
                }
            }

            if (veces == 0)
            {
                int numero_tres = 1;
                for (int i = 7; i > 0; i--)
                {
                    if (veces == 0)
                    {
                        numero_tres = 1;
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if ((tablero[i] + numero_tres) < 9)
                            {
                                if ((tablero[i] + numero_tres) == tablero[j])
                                {
                                    veces++;
                                }
                                else
                                {
                                    numero_tres++;
                                }
                            }
                        }
                    }
                }
            }

            if (veces == 0)
            {
                res = true;
            }
            
            return res;
        }

        public bool revisar_completo(List<int> tablero)
        {
            bool res = false;
            int veces = 0;
            int numero = 0;
            if (veces == 0)
            {
                int numero_dos = 1;

                for (int j = 1; j < 9; j++)
                {
                    if (veces == 0)
                    {
                        numero = 0;
                        for (int i = 0; i < 8; i++)
                        {
                            if (veces == 0)
                            {
                                if (tablero[i] == j)
                                {
                                    numero++;
                                    if (numero > 1)
                                    {
                                        veces++;
                                    }
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < 7; i++)
                {
                    if (veces == 0)
                    {
                        numero_dos = 1;
                        for (int j = i + 1; j < 8; j++)
                        {
                            if ((tablero[i] + numero_dos) < 9)
                            {
                                if ((tablero[i] + numero_dos) == tablero[j])
                                {
                                    veces++;
                                }
                                else
                                {
                                    numero_dos++;
                                }
                            }
                        }
                    }
                }
            }

            if (veces == 0)
            {
                int numero_tres = 1;
                for (int i = 7; i > 0; i--)
                {
                    if (veces == 0)
                    {
                        numero_tres = 1;
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if ((tablero[i] + numero_tres) < 9)
                            {
                                if ((tablero[i] + numero_tres) == tablero[j])
                                {
                                    veces++;
                                }
                                else
                                {
                                    numero_tres++;
                                }
                            }
                        }
                    }
                }
            }

            if (veces == 0)
            {
                res = true;
            }

            return res;
        }
    }
}
