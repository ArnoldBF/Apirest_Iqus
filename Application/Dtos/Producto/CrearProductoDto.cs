

namespace Application.Dtos.Producto
{
    public class CrearProductoDto
    {

        required public string Nombre { get; set; }
        required public double Precio { get; set; }
        required public string Descripcion { get; set; }

    }
}