

namespace Application.Dtos.Producto
{
    public class RespuestaProductoDto
    {

        public string Nombre { get; set; } = string.Empty;
        public decimal PrecioUnitario { get; set; }
        public string Descripcion { get; set; } = string.Empty;

    }
}