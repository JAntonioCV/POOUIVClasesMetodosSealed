using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace POOUIV
{
    public class Instructor: Persona, IPersona
    {
		private string nombreCargo;

		public string NombreCargo
		{
			get { return nombreCargo; }
			set { nombreCargo = value; }
		}

        public override string cedula { get; set ; }
        public double peso { get; set; }
        public double altura { get ; set; }

        public Instructor()
		{

		}

		public Instructor(string nombreCargo,string cedula, string nombre, int edad, double peso, double altura)
		{
            this.nombreCargo = nombreCargo;
            this.cedula = cedula;
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            this.altura = altura;
		}

        public override void MostrarInformacion()
        {
            Console.WriteLine(cedula);
            Console.WriteLine(nombreCargo);
            Console.WriteLine(nombre);
            Console.WriteLine(edad);
            Console.WriteLine(peso);
            Console.WriteLine(altura);

        }

        public void CalcularIMC()
        {
            var IMC = peso / (altura * altura);
            Console.WriteLine("El IMC es: "+IMC);
        }

        public void Felicitaciones(string nombre, string motivo)
        {
            Console.WriteLine($"{nombre} el motivo de este saludo es: {motivo}");
        }
    }
}
