

namespace Application.Dtos.Producto
{
    public class ProductoDto
    {
        public int Id { get; set; }
        required public string Nombre { get; set; }
        required public decimal PrecioUnitario { get; set; }
        required public string Descripcion { get; set; }
    }
}