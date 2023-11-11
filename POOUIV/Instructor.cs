using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIV
{
    public class Instructor: Estudiante
    {
		private string nombreCargo;

		public string NombreCargo
		{
			get { return nombreCargo; }
			set { nombreCargo = value; }
		}

		public Instructor()
		{

		}

		public Instructor(string nombreCargo,string cedula, string carnet, string nombre, int edad): base(cedula,carnet,nombre,edad)
		{
			this.nombreCargo = nombreCargo;
		}

		public override void MostrarInformacion()
		{
			base.MostrarInformacion();
		}
	}
}
