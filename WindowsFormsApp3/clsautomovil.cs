using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class clsAutomovil : clsVehiculo
    {
        public int numeroDePuertas { get; set; }

        public clsAutomovil(string Marca, string Modelo, int Año, int numeroDePuertas) : base(Marca, Modelo) //aqui faltan unos datos
        {
            numeroDePuertas = numeroDePuertas;
        }

        //sobreescribo el metodo
        public override string MostrarDetalles()

        {
            return $"Automovil:{base.MostrarDetalles()}, puertas: {numeroDePuertas}";
        }

    }
}
