using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_integrador_DSOO
{
    internal class Cliente
    {
        // Definición de atributos
        private string? nombre;
        private string? apellido;
        private string? email;
        private string? dni;
        private string? telefono;

        // Constructor
        public Cliente(string nombre, string apellido, string email, string dni, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.dni = dni;
            this.telefono = telefono;
        }

        // Propiedades
        public string? Nombre { get { return nombre; } set { nombre = value; } }
        public string? Apellido { get { return apellido; } set { apellido = value; } }
        public string? Email { get { return email; } set { email = value; } }
        public string? Dni { get { return dni; } set { dni = value; } }
        public string? Telefono { get { return telefono; } set { telefono = value; } }

        // Método para mostrar la información del cliente
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}, Apellido: {apellido}, Email: {email}, DNI: {dni}, Teléfono: {telefono}");
        }

        // Método para registrar un nuevo cliente
        public static Cliente RegistrarCliente()
        {
            Console.WriteLine("Ingrese los datos del cliente:");

            Console.Write("Nombre: ");
            string? nombre = Console.ReadLine();
            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacío.");
                return null;
            }

            Console.Write("Apellido: ");
            string? apellido = Console.ReadLine();
            if (string.IsNullOrEmpty(apellido))
            {
                Console.WriteLine("El apellido no puede estar vacío.");
                return null;
            }

            Console.Write("Email: ");
            string? email = Console.ReadLine();
            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("El email no puede estar vacío.");
                return null;
            }

            Console.Write("DNI: ");
            string? dni = Console.ReadLine();
            if (string.IsNullOrEmpty(dni))
            {
                Console.WriteLine("El DNI no puede estar vacío.");
                return null;
            }

            Console.Write("Teléfono: ");
            string? telefono = Console.ReadLine();
            if (string.IsNullOrEmpty(telefono))
            {
                Console.WriteLine("El teléfono no puede estar vacío.");
                return null;
            }

            return new Cliente(nombre, apellido, email, dni, telefono);
        }

        // Método para verificar si un cliente ya existe
        public static bool ExisteCliente(List<Cliente> listaClientes, string dni)
        {
            return listaClientes.Exists(c => c.Dni == dni);
        }
    }   
}