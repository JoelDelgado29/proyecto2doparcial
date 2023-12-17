using System;
using System.Collections.Generic;

class CarritoCompras
{
    public List<string> Productos { get; private set; }
    public string PedidoActual { get; private set; }

    public CarritoCompras()
    {
        Productos = new List<string>();
        PedidoActual = string.Empty;
    }

    public void AgregarProducto(string producto)
    {
        Productos.Add(producto);
        Console.WriteLine("Producto agregado al carrito: " + producto);
    }

    public void RemoverProducto(int indice)
    {
        if (indice >= 0 && indice < Productos.Count)
        {
            string productoRemovido = Productos[indice];
            Productos.RemoveAt(indice);
            Console.WriteLine("Producto removido del carrito: " + productoRemovido);
        }
        else
        {
            Console.WriteLine("Índice de producto inválido");
        }
    }

    public void RealizarPedido(string metodoPago)
    {
        // Lógica para realizar el pedido con el método de pago proporcionado
        PedidoActual = "ID del pedido generado";
        Console.WriteLine("Pedido realizado. ID del pedido: " + PedidoActual);
    }
}
