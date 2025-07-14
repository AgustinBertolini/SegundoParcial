using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcesadorPagos procesadorPagosMP = new AdaptadorMercadoPago();

            Console.WriteLine("Ingresa un monto en pesos para mercado pago:");
            var monto1 = Console.ReadLine();
            procesadorPagosMP.RealizarPago(Convert.ToDecimal(monto1));
            Console.WriteLine("Ingresa otro monto en pesos para mercado pago:");
            var monto2 = Console.ReadLine();
            procesadorPagosMP.RealizarPago(Convert.ToDecimal(monto2));

            procesadorPagosMP.ListarPagos();

            ProcesadorPagos procesadorPagosStripe = new AdaptadorStripe();

            Console.WriteLine("Ingresa un monto en dolares para stripe:");
            var monto3 = Console.ReadLine();
            procesadorPagosStripe.RealizarPago(Convert.ToDecimal(monto3));
            Console.WriteLine("Ingresa otro monto en dolares para stripe:");
            var monto4 = Console.ReadLine();
            procesadorPagosStripe.RealizarPago(Convert.ToDecimal(monto4));

            procesadorPagosStripe.ListarPagos();
        }
    }
}
