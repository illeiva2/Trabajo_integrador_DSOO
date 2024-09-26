using System;
using System.Collections.Generic;
using System.Linq;

namespace Trabajo_integrador_DSOO
{
    internal class Club
    {
        private List<Socio> listaSocios;
        private List<Actividades> listaActividades;

        public Club()
        {
            listaSocios = new List<Socio>();
            listaActividades = new List<Actividades>();
        }

        // Método para verificar si un socio ya existe
        private bool ExisteSocio(int dni)
        {
            return listaSocios.Exists(s => s.Dni == dni);
        }

        // Método para registrar un nuevo socio
        public void RegistrarSocio(string nombre, string apellido, string email, int dni, string telefono)
        {
            if (ExisteSocio(dni))
            {
                Console.WriteLine("Error: El socio ya está registrado.");
                return;
            }

            var nuevoSocio = new Socio(nombre, apellido, email, dni, telefono);
            listaSocios.Add(nuevoSocio);
            Console.WriteLine("Socio registrado exitosamente.");
        }

        // Método para agregar una actividad
        public void AgregarActividad(Actividades actividad)
        {
            listaActividades.Add(actividad);
            Console.WriteLine("Actividad agregada exitosamente.");
        }

        // Método para inscribir un socio en una actividad
        public string InscribirActividad(string nombreActividad, int dniSocio)
        {
            Socio socio = listaSocios.FirstOrDefault(s => s.Dni == dniSocio);
            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }

            if (socio.Actividades.Count >= 4)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }

            Actividades actividad = listaActividades.FirstOrDefault(a => a.Nombre == nombreActividad);
            if (actividad == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }

            if (actividad.Capacidad > 0)
            {
                socio.Actividades.Add(actividad);
                actividad.Capacidad--;
                return "INSCRIPCIÓN EXITOSA";
            }

            return "NO HAY CUPOS DISPONIBLES";
        }

        // Método para mostrar socios registrados
        public void MostrarSocios()
        {
            Console.WriteLine("Socios registrados:");
            foreach (var socio in listaSocios)
            {
                socio.MostrarInfo();
            }
        }
    }
}
