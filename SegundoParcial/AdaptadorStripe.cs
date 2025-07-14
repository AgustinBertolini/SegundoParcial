using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class AdaptadorStripe : ProcesadorPagos
    {
        Stripe stripe = new Stripe();

        public override void ListarPagos()
        {
            stripe.ListarTransacciones();
        }

        public override void RealizarPago(decimal monto)
        {
            stripe.RealizarTransaccion(monto);
        }
    }
}
