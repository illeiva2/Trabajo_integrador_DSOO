using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_integrador_DSOO
{
    internal class Club
    {
        private List<Socio> listaSocios;

        public Club()
        {
            listaSocios = new List<Socio>();
        }

        // Método para verificar si un socio ya existe
        private bool ExisteSocio(int dni)
        {
            return listaSocios.Exists(s => s.Dni == dni);
        }

        // Método para registrar un nuevo socio
        public void RegistrarSocio(string nombre, string apellido, string email, int dni, string telefono)
        {
            // Validar si el socio ya existe
            if (ExisteSocio(dni))
            {
                Console.WriteLine("Error: El socio ya está registrado.");
                return;
            }

            var nuevoSocio = new Socio(nombre, apellido, email, dni, telefono);
            listaSocios.Add(nuevoSocio);
            Console.WriteLine("Socio registrado exitosamente.");
        }

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
