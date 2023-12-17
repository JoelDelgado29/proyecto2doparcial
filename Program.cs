class Program
{
    static void Main()
    {
        TiendaEnLineaFacade tienda = new TiendaEnLineaFacade();
        tienda.VisualizarProductos();

        // Realiza el proceso de pedido usando la fachada
        if (tienda.IniciarSesion("usuario", "contraseña"))
        {
            tienda.AgregarProductoAlCarrito(1);
            tienda.AgregarProductoAlCarrito(2);
            tienda.RemoverProductoDelCarrito(1);
            tienda.RealizarPedido(1);
            tienda.VerificarEstadoPedido();
            tienda.EnviarNotificacion();
        }
        else
        {
            Console.WriteLine("Inicio de sesión fallido");
        }
    }
}