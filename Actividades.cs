using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_integrador_DSOO
{
    internal class Actividades
    {
        // Definición de atributos
        private string nombre;
        private int costo;
        private int capacidad;

        // Propiedades
        public string Nombre
        {
            get { return nombre; }
        }

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        public Actividades(string nombre, int costo, int capacidad)
        {
            this.nombre = nombre;
            this.costo = costo;
            this.capacidad = capacidad;
        }
    }
}