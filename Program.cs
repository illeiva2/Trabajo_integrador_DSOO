using System.Runtime.CompilerServices;

namespace Trabajo_integrador_DSOO
{
    internal class Program
    {
        public static List<Actividades>? listaActividades;

        static void Main(string[] args)
        {
            listaActividades = new List<Actividades>();
            listaActividades.Add(new Actividades("Natacion", 100, 10));
            listaActividades.Add(new Actividades("Voley", 150, 15));
            listaActividades.Add(new Actividades("Futbol", 200, 20));
            listaActividades.Add(new Actividades("Basquet", 250, 25));
            listaActividades.Add(new Actividades("Handball", 300, 30));
            listaActividades.Add(new Actividades("Rugby", 350, 35));
            listaActividades.Add(new Actividades("Tenis", 400, 40));
            listaActividades.Add(new Actividades("Golf", 450, 45));
            NoSocio noSocio = new NoSocio("Juan", "Perez", "asd.com", "12345678", "12345678");
            //Console.WriteLine(noSocio.agregarActividad("Futbol"));
            //Console.WriteLine(noSocio.agregarActividad(actividad2));
            //Console.WriteLine(noSocio.agregarActividad(actividad3));
            //Console.WriteLine(noSocio.agregarActividad(actividad3));
            //Console.WriteLine(noSocio.agregarActividad(actividad4));
        }
    }
}