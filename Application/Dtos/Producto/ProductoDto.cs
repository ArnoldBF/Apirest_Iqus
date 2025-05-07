using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Dtos.Producto
{
    public class ProductoDto
    {
        public int Id { get; set; }
        required public string Nombre { get; set; }
        required public double Precio { get; set; }
        required public string Descripcion { get; set; }
    }
}