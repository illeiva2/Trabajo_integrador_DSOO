using System.Runtime.CompilerServices;

namespace Trabajo_integrador_DSOO
{
    internal class Program
    {
        static List<Cliente> listaClientes = new List<Cliente>();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                // Registrar cliente a partir de la entrada del usuario
                Cliente nuevoCliente = Cliente.RegistrarCliente();
                if (nuevoCliente != null)
                {
                    listaClientes.Add(nuevoCliente);
                    Console.WriteLine("Cliente registrado exitosamente.\n");
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