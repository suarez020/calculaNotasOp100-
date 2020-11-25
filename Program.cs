using System;
using System.Runtime.ConstrainedExecution;
using System.Transactions;
using System.Xml.Schema;

namespace calculaNotasOp100___
{
    class Program
    {
        static void Main(string[] args)
        {
            //double r;
            //double promedio;
            int n;
            //linea de p
            
            Console.Write("otra vez haciendo calculos maricas! cuantas notas sacaron esta vez?");
            n = int.Parse(Console.ReadLine());
            //int[] notas = new int[n];
            double acumulador = 0;
            double NotaFinal;

            for (int i = 1; i <= n; i++)
            {
                int valorEnI;

                valorEnI = i;
                double Porc;

                double tota;
                double valorNota;
                Console.Write("ingrese la nota " + valorEnI + "=");
                valorNota = double.Parse(Console.ReadLine());
                Console.Write("ingrese el porcentaje de la nota =");
                Porc = double.Parse(Console.ReadLine());
                tota = valorNota * Porc / 100;
                acumulador = acumulador + tota;
                             
            }
            NotaFinal = acumulador;
            Console.Write("tu nota final es= "+acumulador);

            //Console.Write(acumulador)
            Console.ReadKey();

        }
        

    }

}
