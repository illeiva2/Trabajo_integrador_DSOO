using System.Runtime.CompilerServices;

namespace Trabajo_integrador_DSOO
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            Club club = new Club();

            // Ejemplo de registro de nuevos socios
            club.RegistrarSocio("Juan", "Pérez", "juan.perez@example.com", 12345678, "123456789");
            club.RegistrarSocio("Ana", "Gómez", "ana.gomez@example.com", 87654321, "987654321");
            club.RegistrarSocio("Luis", "Martínez", "luis.martinez@example.com", 13579246, "246813579");
            // Intentar registrar un socio existente
            club.RegistrarSocio("Juan", "Pérez", "juan.perez@example.com", 12345678, "123456789"); // Este dará un error

            // Mostrar los socios registrados
            club.MostrarSocios();
        }
    }
}