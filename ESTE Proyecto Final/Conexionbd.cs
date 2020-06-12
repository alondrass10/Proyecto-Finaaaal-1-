using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final_2020
{
    class Conexionbd
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexionbd()
        {
            try
            {
                // Servidor, Base de datos
                cn = new SqlConnection("Data Source =SERVIDOR; Initial Catalog =Alondra; Integrated Security = true;Persist Security Info=True");
                cn.Open();
                MessageBox.Show("Conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }



        public string insertar(string RFC, string Proveedor, string Producto, double Precio)
        {
            string salida = "Si se inserto";
            try
            {

                cmd = new SqlCommand("INSERT INTO Alondra.dbo.proveedores values(" + RFC + ",'" + Proveedor + "','" + Producto + "'," + Precio + ");", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string eliminar(string RFC)
        {
            string salida = "Si se elimino";
            try
            {

                cmd = new SqlCommand("DELETE FROM Alondra.dbo.proveedores where RFC ='" + RFC + "';", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

    }
}
