using System;
using System.Collections.Generic;

class ProductosVisualizacion
{
    private Dictionary<int, string> productos;

    public ProductosVisualizacion()
    {
        productos = new Dictionary<int, string>()
        {
            { 1, "Bicicleta BMX" },
            { 2, "Tubo" },
            { 3, "Catalina" }
        };
    }

    public string ObtenerProducto(int idProducto)
    {
        if (productos.ContainsKey(idProducto))
        {
            return productos[idProducto];
        }

        return "Producto no encontrado";
    }
}
