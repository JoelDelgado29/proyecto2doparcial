using System;

class ConfirmacionPago
{
    public bool ProcesarPago(string idPedido, string metodoPago, double monto)
    {
        // Lógica para procesar el pago con el método de pago y monto proporcionados
        // Puedes conectar con un proveedor de pagos externo para realizar el proceso de pago
        Console.WriteLine($"Pago procesado para el pedido {idPedido} con método de pago: {metodoPago} y monto: {monto}");
        // Devuelve true si el pago fue exitoso, o false en caso contrario
        return true;
    }
}