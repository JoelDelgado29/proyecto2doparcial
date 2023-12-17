using System;

// Facade
class TiendaEnLineaFacade
{
    private ProductosVisualizacion productosVisualizacion;
    private InicioSesion inicioSesion;
    private CarritoCompras carritoCompras;
    private MetodosPago metodosPago;
    private ConfirmacionPago confirmacionPago;
    private EstadoPedido estadoPedido;
    private NotificacionPedido notificacionPedido;

    public TiendaEnLineaFacade()
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
        // Lógica para remover un producto del carrito
        carritoCompras.RemoverProducto(indice);
    }

    public void RealizarPedido(int idMetodoPago)
    {
        // Lógica para realizar el pedido con el método de pago proporcionado
        string metodoPago = metodosPago.ObtenerMetodoPago(idMetodoPago);
        carritoCompras.RealizarPedido(metodoPago);
        double monto = 100.0; // Ejemplo de monto
        confirmacionPago.ProcesarPago(carritoCompras.PedidoActual, metodoPago, monto);
    }

    public void VerificarEstadoPedido()
    {
        // Lógica para verificar el estado del pedido
        estadoPedido.VerificarEstadoPedido(carritoCompras.PedidoActual);
    }

    public void EnviarNotificacion()
    {
        // Lógica para enviar la notificación del pedido
        notificacionPedido.EnviarNotificacion(carritoCompras.PedidoActual);
    }
}