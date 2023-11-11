using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIV
{ 
	//Clase
    public class Persona
    {
		//Propiedades
		private string cedula;

		private string nombre;

		private int edad;

		//Getter y Setter
		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Cedula
		{
			get { return cedula; }
			set { cedula = value; }
		}

		//Constructor por defecto
		public Persona()
		{

		}

		//Constructor con parametro
        public Persona(string cedula, string nombre, int edad)
		{
			Cedula = cedula;
			Nombre = nombre;
			Edad = edad;
		}

		public virtual void MostrarInformacion()
		{
			Console.WriteLine("Cedula: "+ Cedula);
			Console.WriteLine("Nombre: "+ Nombre);
			Console.WriteLine("Edad: " + Edad);
		}
	}
}
