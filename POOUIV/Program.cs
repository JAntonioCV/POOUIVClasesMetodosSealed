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
            Persona persona = new Persona("001-100798-0012Q","Josiel",25);

            persona.MostrarInformacion();

            Console.WriteLine();

            Estudiante estudiante = new Estudiante("570-250799-1000D","15041255","Pedro",15);

            estudiante.MostrarInformacion();

            Console.ReadKey();

        }
    }
}
