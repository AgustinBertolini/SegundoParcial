using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class MercadoPago
    {
        private List<decimal> pagos = new List<decimal>();

        public void ListarPagos()
        {
            decimal total = 0;

            foreach (var pago in pagos)
            {
                total += pago;
                Console.WriteLine("MercadoPago --> Pago de: $" + pago.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("MercadoPago --> Pago total: $" + total.ToString());
        }

        public void RealizarPago(decimal monto)
        {
            Console.WriteLine("MercadoPago --> Pago de $" + monto.ToString() + " realizado");
            pagos.Add(monto);
        }
    }
}
