Una empresa de vinos ha desarrollado una aplicación web que permite a los usuarios realizar y gestionar sus pagos de forma rápida y segura. El sistema fue diseñado originalmente para funcionar con una única pasarela de pago, usando una interfaz estándar llamada ProcesadorPagos, que define métodos como RealizarPago(decimal monto) y ListarPagos().

Sin embargo, debido a la expansión internacional del negocio, la empresa decide incorporar nuevas pasarelas de pago que son populares en distintos países, como MercadoPago en Latinoamérica y Stripe en mercados internacionales. Estas plataformas ofrecen una infraestructura moderna y más opciones de pago, pero sus APIs son diferentes: utilizan otros nombres de métodos, estructuras de datos y formatos de moneda.

El sistema actual está muy acoplado a la interfaz ProcesadorPagos, y reescribir toda la lógica del código cliente para soportar las nuevas pasarelas resultaría costoso y poco práctico, tanto en términos de tiempo como de presupuesto.

El objetivo es integrar múltiples proveedores de pago al sistema existente sin modificar el código cliente que ya está funcionando con la interfaz ProcesadorPagos. 
