using System.Runtime.CompilerServices;

namespace Trabajo_integrador_DSOO
{
    internal class Programa
    {
        static void Main(string[] args)
        {
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
        }
    }
}
