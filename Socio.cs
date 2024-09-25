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
        private string? fecha_inscripcion;
        private string? fecha_finalización;
        private bool estado_cuota;
        public int SocioId { get { return socioId; } set { socioId = value; } }
        public string? FechaInscripcion { get { return fecha_inscripcion; } set { fecha_inscripcion = value; } }
        public string? FechaFinalizacion { get { return FechaFinalizacion; } set { FechaFinalizacion = value; } }
        public bool EstadoCuota { get { return estado_cuota; } set { estado_cuota = value; } }
    }
}