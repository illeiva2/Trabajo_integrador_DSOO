﻿using System.Runtime.CompilerServices;

namespace Trabajo_integrador_DSOO
{
    internal class Programa
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            List<Cliente> listaClientes = new List<Cliente>();
            bool continuar = true;

            while (continuar)
            {
                Cliente nuevoCliente = Cliente.RegistrarCliente();
                if (nuevoCliente != null)
                {
                    // Verificar si el cliente ya existe
                    if (Cliente.ExisteCliente(listaClientes, nuevoCliente.Dni))
                    {
                        Console.WriteLine("El cliente ya está registrado.");
                    }
                    else
                    {
                        // Agregar nuevo cliente a la lista
                        listaClientes.Add(nuevoCliente);
                        Console.WriteLine("Cliente registrado exitosamente.");
                    }
                }

                Console.WriteLine("¿Desea registrar otro cliente? (s/n)");
                string respuesta = Console.ReadLine()?.ToLower();
                if (respuesta != "s")
                {
                    continuar = false;
                }
            }

            // Mostrar todos los clientes registrados
            Console.WriteLine("Clientes registrados:");
            foreach (var cliente in listaClientes)
            {
                cliente.MostrarInfo();
            }
=======
            // Crear instancia del club
            Club club = new Club();

            // Ejemplo de registro de nuevos socios
            club.RegistrarSocio("Juan", "Pérez", "juan.perez@example.com", 12345678, "123456789");
            club.RegistrarSocio("Ana", "Gómez", "ana.gomez@example.com", 87654321, "987654321");
            club.RegistrarSocio("Luis", "Martínez", "luis.martinez@example.com", 13579246, "246813579");
            // Intentar registrar un socio existente
            club.RegistrarSocio("Juan", "Pérez", "juan.perez@example.com", 12345678, "123456789"); // Este dará un 

            // Agregar algunas actividades 
            club.AgregarActividad(new Actividades("Fútbol", 100, 10));
            club.AgregarActividad(new Actividades("Tenis", 150, 5));
            club.AgregarActividad(new Actividades("Natación", 200, 8));
            club.AgregarActividad(new Actividades("Boxeo", 200, 8));

            // Inscribir actividades
            Console.WriteLine(club.InscribirActividad("Fútbol", 12345678)); // INSCRIPCIÓN EXITOSA
            Console.WriteLine(club.InscribirActividad("Tenis", 12345678));  // INSCRIPCIÓN EXITOSA
            Console.WriteLine(club.InscribirActividad("Natación", 12345678)); // INSCRIPCIÓN EXITOSA
            Console.WriteLine(club.InscribirActividad("Boxeo", 12345678)); // LIMITE DE ACTIVIDADES
            Console.WriteLine(club.InscribirActividad("Muay thai", 12345678)); // ACTIVIDAD INEXISTENTE
            Console.WriteLine(club.InscribirActividad("Fútbol", 99999999)); // SOCIO INEXISTENTE
>>>>>>> fca795c27680b6d008fe4d4441d5c3d2c4a0cbfc
        }
    }
}
