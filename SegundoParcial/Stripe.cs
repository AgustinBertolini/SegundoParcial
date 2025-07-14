using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class Stripe
    {
        private List<decimal> transacciones = new List<decimal>();

        public void ListarTransacciones()
        {
            decimal total = 0;
            
            foreach (var transaccion in transacciones)
            {
                total += transaccion;
                Console.WriteLine("Stripe --> Pago de: USD" + transaccion.ToString());
            }
            
            Console.WriteLine();
            Console.WriteLine("Stripe --> Pago total: USD" + total.ToString());
        }

        public void RealizarTransaccion(decimal monto)
        {
            Console.WriteLine("Stripe --> Transaccion de USD" + monto.ToString() + " realizada");
            transacciones.Add(monto);
        }
    }
}
