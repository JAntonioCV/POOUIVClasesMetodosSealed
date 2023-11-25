using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();

            Estudiante estudiante = new Estudiante("570-250799-1000D","15041255","Pedro",15);

            estudiante.Saludar();
            Console.WriteLine();
            estudiante.MostrarInformacion();

            Console.WriteLine();

            Instructor  instructor = new Instructor("Encargado de laboratorio", "570-250799-1000D","Pedro",18,60,1.75);

            instructor.MostrarInformacion();
            instructor.CalcularIMC();
            instructor.Felicitaciones("Pedro","Felicidades por tu Ascenso a Responsable de laboratorio");


            Console.ReadKey();

        }
    }
}
