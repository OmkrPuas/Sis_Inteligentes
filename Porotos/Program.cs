using System;


namespace Porotos
{
    class Program
    {
        static void Main(string[] args)
        {
            _8_Queen tarea = new _8_Queen();
            _8_puzzle tarea2 = new _8_puzzle();

            //int reinas = 0;
            //reinas = Int32.Parse(Console.ReadLine());
            //tarea.Proceso_Fuerza_Bruta_Reducido();

            tarea2.BFS_preparar(3);
        }
    }
}
