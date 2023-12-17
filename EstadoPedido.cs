using System;

class EstadoPedido
{
    public string ObtenerEstadoPedido(string idPedido)
    {
        // Lógica para obtener el estado del pedido según el ID proporcionado
        // Puedes obtener el estado del pedido de una base de datos o un servicio externo
        return "Estado del pedido para el ID " + idPedido;
    }

    public void VerificarEstadoPedido(string idPedido)
    {
        string estadoPedido = ObtenerEstadoPedido(idPedido);
        Console.WriteLine("El estado del pedido " + idPedido + " es: " + estadoPedido);
    }
}
