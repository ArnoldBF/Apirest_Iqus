using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Dtos.Producto
{
    public class RespuestaProductoDto
    {

        public string Nombre { get; set; } = string.Empty;
        public double Precio { get; set; }
        public string Descripcion { get; set; } = string.Empty;

    }
}