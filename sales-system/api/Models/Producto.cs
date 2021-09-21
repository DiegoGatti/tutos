using System;
using System.Collections.Generic;

#nullable disable

namespace sales_system.Models
{
    public partial class Producto
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public long? Costo { get; set; }
    }
}
