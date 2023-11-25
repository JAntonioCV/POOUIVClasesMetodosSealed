using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIV
{ 
	//Clase
    public abstract class Persona
    {
		//Propiedades
		public abstract string cedula { get; set; }

		public string nombre  {get; set; }

		public int edad { get; set; }

		public abstract void MostrarInformacion();


		public void Saludar() {
			Console.WriteLine(cedula);
			Console.WriteLine(nombre);
			Console.WriteLine(edad);

        }
	}
}
