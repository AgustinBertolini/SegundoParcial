using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public abstract class ProcesadorPagos
    {
        public abstract void RealizarPago(decimal monto);

        public abstract void ListarPagos();
    }
}
