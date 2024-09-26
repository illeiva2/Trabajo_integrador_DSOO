using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_integrador_DSOO
{
    internal class Socio
    {
        private string? nombre;
        private string? apellido;
        private string? email;
        private int? dni;
        private string? telefono;
        public Socio(string nombre, string apellido, string email, int dni, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.dni = dni;
            this.telefono = telefono;
        }
        public string? Nombre { get { return nombre; } set { nombre = value; } }
        public string? Apellido { get { return apellido; } set { apellido = value; } }
        public string? Email { get { return email; } set { email = value; } }
        public int? Dni { get { return dni; } set { dni = value; } }
        public string? Telefono { get { return telefono; } set { telefono = value; } }
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}, Apellido: {apellido}, Email: {email}, DNI: {dni}, Teléfono: {telefono}");
        }

    }
}
