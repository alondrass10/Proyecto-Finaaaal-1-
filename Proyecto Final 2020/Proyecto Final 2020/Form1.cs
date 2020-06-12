using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_2020
{
    public partial class Form1 : Form
    {
        private Venta miVenta;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                if (txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("Debe asignar un cliente");
                    txtNombre.Focus();
                    return;
                }
                miVenta = new Venta(txtNombre.Text);
                dgvProductos.DataSource = miVenta.Productos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Favor de llenar TODOS los campos correctamente");
                    txtNombre.Focus();
                    return;
                }
                if (txtID.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el número de serie del producto");
                    txtID.Focus();
                    return;
                }
                int id = 0;
                if (!int.TryParse(txtID.Text, out id))
                {
                    MessageBox.Show("Ingrese el número de serie adecuadamente.\nNOTA: Solo números");
                    txtID.Focus();
                    return;
                }
                if (id <= 0)
                {
                    MessageBox.Show("Ingrese el número de serie adecuadamente.\nNOTA: Solo números positivos");
                    txtID.Focus();
                    return;
                }
                if (txtDescripcion.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el nombre del producto");
                    txtDescripcion.Focus();
                    return;
                }
                double precio = 0;
                if (!double.TryParse(txtID.Text, out precio))
                {
                    MessageBox.Show("Ingrese el precio adecuadamente.\nNOTA: Solo números");
                    txtPrecio.Focus();
                    return;
                }
                if (precio <= 0)
                {
                    MessageBox.Show("Ingrese el precio adecuadamente.\nNOTA: Solo números poitivos");
                    txtPrecio.Focus();
                    return;
                }
                int cant = 0;
                if (!int.TryParse(txtID.Text, out cant))
                {
                    MessageBox.Show("Ingrese la cantidad adecuadamente. \nNOTA: Solo números");
                    txtCantidad.Focus();
                    return;
                }
                if (cant <= 0)
                {
                    MessageBox.Show("Ingrese la cantidad adecuadamente.\nNOTA: Solo números");
                    txtCantidad.Focus();
                    return;
                }

                Producto miProducto = new Producto();
                miProducto.ID = id;
                miProducto.Descripcion = txtDescripcion.Text;
                miProducto.Cantidad = cant;
                miProducto.Precio = precio;

                miVenta.AgregarProducto(miProducto);
               // dgvProductos.Rows.Clear();

                /*foreach(Producto producto in dgvProductos.Rows)
                {
                    dgvProductos.Rows.Add(miProducto.ID);
                    dgvProductos.Rows.Add(miProducto.Descripcion);
                    dgvProductos.Rows.Add(miProducto.Cantidad);
                    dgvProductos.Rows.Add(miProducto.Precio);

                }*/

                // Actualizar el dgv
                 dgvProductos.DataSource = null;
                 dgvProductos.DataSource = miVenta.Productos;

                txtID.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                txtCantidad.Text = string.Empty;
                txtPrecio.Text = string.Empty;
                txtID.Focus();
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DialogResult CostoTotal = MessageBox.Show(this, string.Format("Total a pagar: {0:C2}\n" + "¿Desea pagar?", miVenta.Calcular(miVenta.CalcularTotal)),"Pagar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(CostoTotal == DialogResult.No )
            {
                return;
            }

            miVenta = null;
            txtNombre.Text = string.Empty;
            txtNombre.Focus();
            dgvProductos.DataSource = null;
        }
        private void EventoClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvProductos.CurrentRow.Selected = true;
                txtID.Text = dgvProductos.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txtNombre.Text = dgvProductos.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                txtDescripcion.Text = dgvProductos.Rows[e.RowIndex].Cells["Producto"].FormattedValue.ToString();
                txtCantidad.Text = dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].FormattedValue.ToString();
                txtPrecio.Text = dgvProductos.Rows[e.RowIndex].Cells["Precio"].FormattedValue.ToString();
            }
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                txtCantidad.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            }
            catch { }
        }
    }
}

       
