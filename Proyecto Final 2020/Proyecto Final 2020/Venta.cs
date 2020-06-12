using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_2020
{
    class Venta
    {
        private string cliente;
        private List<Producto> productos;

        public List<Producto> Productos
        {
            get { return productos; }
        }
        public Venta(string cliente)
        {
            this.cliente = cliente;
            this.productos = new List<Producto>();
        }
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }
        public double CalcularTotal()
        {
            double total = 0;
            foreach (Producto producto in productos)
            {
                total = total + (producto.Cantidad * producto.Precio);
            }
            return total;
        }
        public delegate double Operacion();

        public double Calcular(Operacion miOperacion)
        {
            double CostoTotal = miOperacion();
            return CostoTotal;
        }

    }
}
