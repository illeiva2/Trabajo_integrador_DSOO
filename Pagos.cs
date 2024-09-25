using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_integrador_DSOO
{
    class Pagos
    {
        public int idSocio { get; private set; }
        // public int idNoSocio { get; private set; }
        public int monto { get; private set; }
        public string fechaPago { get; private set; }
        public string fechaVencimiento { get; private set; }
        public string tipoCuota { get; private set; }
        public bool estado { get; private set; }

        public Pagos(int idSocio, int monto, string fechaPago,
            string fechaVencimiento, string tipoCuota, bool estado)
        {
            this.idSocio = idSocio;
            //this.idNoSocio = idNoSocio; 
            this.monto = monto;
            this.fechaPago = fechaPago;
            this.fechaVencimiento = fechaVencimiento;
            this.tipoCuota = tipoCuota;
            this.estado = estado;

        }
        public override string ToString()
        {
            return $"idSocio {idSocio}, Monto {monto}, Fecha Hoy {fechaPago}, Vencimiento {fechaVencimiento}";
        }
    }
}


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Pago pago;
//        // Obtengo la fecha
//        DateTime hoy = DateTime.Now;
//        // La paso a string para poder solo mostrar fecha sin hora
//        string hoySinHora = hoy.ToString("dd/MM/yyyy");
//        // A la fecha de hoy le sumo un mes para obtener la fecha de vencimiento
//        DateTime vencimiento = hoy.AddMonths(1);
//        string venciSinHora = vencimiento.ToString("dd/MM/yyyy");
//        string tCuota = "Mensual";

//        pago = new Pago(1, 250, hoySinHora, venciSinHora, tCuota, true);
//        Console.WriteLine(pago);
//    }
//}

