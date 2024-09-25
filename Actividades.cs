using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_integrador_DSOO
{
    internal class Actividades
    {       
            // Atributos
            private DateTime horario;
            private string instructor;
            private int costo;
            private int capacidad;
            
            // Propiedades
            public DateTime Horario
            {
                get { return horario; }
                set { horario = value; }
            }

            public string Instructor
            {
                get { return instructor; }
                set { instructor = value; }
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

            // Constructor
            public Actividades(DateTime horario, string instructor, int costo, int capacidad)
            {
                this.horario = horario;
                this.instructor = instructor;
                this.costo = costo;
                this.capacidad = capacidad;
            }
    }
}