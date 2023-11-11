using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIV
{
	//Clase sellada Sealed no se puede heredar
    public sealed class Estudiante: Persona
    {
		private string carnet;

		public string Carnet
		{
			get { return carnet; }
			set { carnet = value; }
		}

		public Estudiante()
		{

		}

		public Estudiante(string cedula,string carnet, string nombre, int edad): base(cedula,nombre,edad)
		{
			this.carnet = carnet;
		}

		//Metodo Sellado Sealed no se puede heredar
		public sealed override void MostrarInformacion()
		{
			base.MostrarInformacion();
			Console.WriteLine("Carnet: "+Carnet);
		}


	}
}
