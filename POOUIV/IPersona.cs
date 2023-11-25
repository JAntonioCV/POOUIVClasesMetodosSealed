using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUIV
{
    public interface IPersona
    {
        double peso { get; set; }
        double altura { get; set; }
        void Felicitaciones(string nombre, string motivo);
        void CalcularIMC();
    }
}
