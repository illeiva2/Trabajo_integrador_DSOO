using System;
using System.Collections.Generic;

namespace Trabajo_integrador_DSOO
{
    internal class Socio
    {
        private string? nombre;
        private string? apellido;
        private string? email;
        private int? dni;
        private string? telefono;
        private List<Actividades> actividades; // Lista de actividades en las que está inscrito el socio

        public Socio(string nombre, string apellido, string email, int dni, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.dni = dni;
            this.telefono = telefono;
            actividades = new List<Actividades>(); // Inicializar la lista de actividades
        }

        public string? Nombre { get { return nombre; } set { nombre = value; } }
        public string? Apellido { get { return apellido; } set { apellido = value; } }
        public string? Email { get { return email; } set { email = value; } }
        public int? Dni { get { return dni; } set { dni = value; } }
        public string? Telefono { get { return telefono; } set { telefono = value; } }
        public List<Actividades> Actividades { get { return actividades; } } // Propiedad para acceder a la lista de actividades

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}, Apellido: {apellido}, Email: {email}, DNI: {dni}, Teléfono: {telefono}");
        }
    }
}