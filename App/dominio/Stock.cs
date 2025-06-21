using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    internal class Stock
    {
        public int Id { get; set; }
        public Sucursal Sucursal { get; set; }

        public int Cantidad { get; set; }
    }
}
