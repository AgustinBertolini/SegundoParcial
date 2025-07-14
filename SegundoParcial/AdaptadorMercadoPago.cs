using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class AdaptadorMercadoPago : ProcesadorPagos
    {
        MercadoPago mercadoPago = new MercadoPago();

        public override void ListarPagos()
        {
            mercadoPago.ListarPagos();
        }

        public override void RealizarPago(decimal monto)
        {
            mercadoPago.RealizarPago(monto);
        }
    }
}
