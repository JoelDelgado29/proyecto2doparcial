using System;
using System.Collections.Generic;

class MetodosPago
{
    private Dictionary<int, string> metodosPago;

    public MetodosPago()
    {
        metodosPago = new Dictionary<int, string>()
        {
            { 1, "Tarjeta de crédito" },
            { 2, "PayPal" },
            { 3, "Transferencia bancaria" }
        };
    }

    public string ObtenerMetodoPago(int idMetodoPago)
    {
        if (metodosPago.ContainsKey(idMetodoPago))
        {
            return metodosPago[idMetodoPago];
        }

        return "Método de pago no encontrado";
    }
}