using System;

namespace Periodo_Atras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            data.obterData();
            data.obterPeriodoAtras();
            data.mostrar();

            Console.ReadKey();
        }
    }
}
