using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_integrador_DSOO
{
    internal class Socio : Cliente
    {
        private int socioId;
        private DateTime fecha_inscripcion;
        private DateTime fecha_finalizacion;
        private bool estado_cuota;

        public Socio(string nombre, string apellido, string email, string dni, string telefono) : base(nombre, apellido, email, dni, telefono)
        {

        }

        public int SocioId { get { return socioId; } set { socioId = value; } }
        public DateTime FechaInscripcion { get { return fecha_inscripcion; } set { fecha_inscripcion = value; } }
        public DateTime FechaFinalizacion { get { return fecha_finalizacion; } set { fecha_finalizacion = value; } }
        public bool EstadoCuota { get { return estado_cuota; } set { estado_cuota = value; } }
    }
}