using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class clsvehiculo
    {
        public string  Marca { get; set; }
        public string Modelo { get; set; }
        public int año { get; set; }

        //constructor

        public clsvehiculo()
        {
        Marca = "Desconocido";
        Modelo = "Desconocido";
            año = 0;
        }

        public clsvehiculo(string marca, string modelo, int ño)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        //Metodo virtual que es el que se va a sobrecargar por las clases dereivadas

        public override string MostrarDetalle() 
        { 
        return $"Marca":{Marca}, "Modelo": { Modelo}, "Año": { Año};

        }

        

    }
}
