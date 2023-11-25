using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIV
{
    public class Estudiante: Persona
    {
        private string carnet;

		public string Carnet
		{
			get { return carnet; }
			set { carnet = value; }
		}

        public override string cedula { get; set; }

        public Estudiante()
		{

		}

		public Estudiante(string cedula,string carnet, string nombre, int edad)
		{
			this.cedula = cedula;
			this.carnet = carnet;
			this.nombre = nombre;
			this.edad = edad;
		}

        public override void MostrarInformacion()
        {
            Console.WriteLine(cedula);
            Console.WriteLine(carnet);
			Console.WriteLine(nombre);
			Console.WriteLine(edad);
        }
    }
}
