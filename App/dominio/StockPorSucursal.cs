using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class StockPorSucursal
    {
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public string Codigo { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
    }
}
