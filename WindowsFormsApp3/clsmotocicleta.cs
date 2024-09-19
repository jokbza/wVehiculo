using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class clsmotocicleta : clsVehiculo
    {
        public int cilindraje {  get; set; }
        //constructor
        public clsmotocicleta(string Marca, string Modelo, int año, int cilindraje) : base(Marca, Modelo, Año) //aqui faltan cosas
        {
            cilindraje 0 cilindraje;
        } 
        //sobreescribo el meotdo mostrar detalles()
        
        public override string MostrarDetalles()
        {
            return $"Motocicleta: {base.MostrarDetalles()}, xilindraje: {cilindraje}";
    }
}
