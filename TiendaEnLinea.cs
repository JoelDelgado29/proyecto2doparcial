using System;

class TiendaEnLinea
{
    private ProductosVisualizacion productosVisualizacion;
    private InicioSesion inicioSesion;
    private CarritoCompras carritoCompras;
    private MetodosPago metodosPago;
    private ConfirmacionPago confirmacionPago;
    private EstadoPedido estadoPedido;
    private NotificacionPedido notificacionPedido;

    public TiendaEnLinea()
    {
        productosVisualizacion = new ProductosVisualizacion();
        inicioSesion = new InicioSesion();
        carritoCompras = new CarritoCompras();
        metodosPago = new MetodosPago();
        confirmacionPago = new ConfirmacionPago();
        estadoPedido = new EstadoPedido();
        notificacionPedido = new NotificacionPedido();
    }

    public void VisualizarProductos()
    {
        // Lógica para visualizar los productos
        Console.WriteLine("Productos:");
        Console.WriteLine(productosVisualizacion.ObtenerProducto(1));
        Console.WriteLine(productosVisualizacion.ObtenerProducto(2));
        // Agrega aquí más productos si es necesario
    }

    public bool IniciarSesion(string usuario, string contraseña)
    {
        // Lógica para iniciar sesión
        return inicioSesion.IniciarSesion(usuario, contraseña);
    }

    public void AgregarProductoAlCarrito(int idProducto)
    {
        // Lógica para agregar un producto al carrito
        string producto = productosVisualizacion.ObtenerProducto(idProducto);
        carritoCompras.AgregarProducto(producto);
    }

    public void RemoverProductoDelCarrito(int indice)
    {
        carritoCompras.RemoverProducto(indice);
    }

    public void RealizarPedido(int idMetodoPago)
    {
        string metodoPago = metodosPago.ObtenerMetodoPago(idMetodoPago);
        carritoCompras.RealizarPedido(metodoPago);
        double monto = 100.0; // Ejemplo de monto
        bool pagoExitoso = confirmacionPago.ProcesarPago(carritoCompras.PedidoActual, metodoPago, monto);

        if (pagoExitoso)
        {
            estadoPedido.VerificarEstadoPedido(carritoCompras.PedidoActual);
            notificacionPedido.EnviarNotificacion(carritoCompras.PedidoActual);
        }
        else
        {
            Console.WriteLine("El pago no pudo ser procesado correctamente. Pedido cancelado.");
        }
    }
}