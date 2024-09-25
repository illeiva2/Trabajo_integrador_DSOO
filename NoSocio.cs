using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_integrador_DSOO
{
    internal class NoSocio : Cliente
    {
        private List<Actividades> actividades;
        public NoSocio(string nombre, string apellido, string email, string dni, string telefono) : base(nombre, apellido, email, dni, telefono)
        {
            actividades = new List<Actividades>();
        }
        //public int agregarActividad(string nombre)
        //{
        //    for (int i = 0; i < actividades.Count; i++)
        //    {
        //        if (actividades[i].Actividad.Contains(nombre))
        //        {
        //            return 0;
        //        }
        //    }
        //    return 1;
        //}
    }
}

