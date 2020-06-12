namespace Proyecto_Final_2020
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtProvProd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alondraDataSet = new Proyecto_Final_2020.AlondraDataSet();
            this.alondraDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alondraDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alondraDataSet1 = new Proyecto_Final_2020.AlondraDataSet1();
            this.provedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provedoresTableAdapter = new Proyecto_Final_2020.AlondraDataSet1TableAdapters.provedoresTableAdapter();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alondraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alondraDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alondraDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alondraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(293, 77);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 31);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(406, 77);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(88, 30);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(96, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(47, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(283, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(205, 48);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(289, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(49, 77);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(70, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(180, 74);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(81, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 141);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(517, 124);
            this.dgvProductos.TabIndex = 12;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(396, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Capturar nombre";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 116);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de la compra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtRFC);
            this.groupBox2.Controls.Add(this.txtProv);
            this.groupBox2.Controls.Add(this.btnProveedor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPago);
            this.groupBox2.Controls.Add(this.txtProvProd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(535, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 134);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del proveedor";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "RFC";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(174, 78);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(70, 20);
            this.txtRFC.TabIndex = 14;
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(49, 16);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(337, 20);
            this.txtProv.TabIndex = 8;
            this.txtProv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(253, 71);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(133, 38);
            this.btnProveedor.TabIndex = 13;
            this.btnProveedor.Text = "Capturar proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre ";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(44, 77);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(70, 20);
            this.txtPago.TabIndex = 10;
            // 
            // txtProvProd
            // 
            this.txtProvProd.Location = new System.Drawing.Point(79, 48);
            this.txtProvProd.Name = "txtProvProd";
            this.txtProvProd.Size = new System.Drawing.Size(307, 20);
            this.txtProvProd.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tipo de prod";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Pago";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rFCDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.provedoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(535, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 124);
            this.dataGridView1.TabIndex = 16;
            // 
            // alondraDataSet
            // 
            this.alondraDataSet.DataSetName = "AlondraDataSet";
            this.alondraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alondraDataSetBindingSource
            // 
            this.alondraDataSetBindingSource.DataSource = this.alondraDataSet;
            this.alondraDataSetBindingSource.Position = 0;
            // 
            // alondraDataSetBindingSource1
            // 
            this.alondraDataSetBindingSource1.DataSource = this.alondraDataSet;
            this.alondraDataSetBindingSource1.Position = 0;
            // 
            // alondraDataSet1
            // 
            this.alondraDataSet1.DataSetName = "AlondraDataSet1";
            this.alondraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provedoresBindingSource
            // 
            this.provedoresBindingSource.DataMember = "provedores";
            this.provedoresBindingSource.DataSource = this.alondraDataSet1;
            // 
            // provedoresTableAdapter
            // 
            this.provedoresTableAdapter.ClearBeforeFill = true;
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 105);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 288);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mi Tiendita";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alondraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alondraDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alondraDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alondraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtProvProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource alondraDataSetBindingSource;
        private AlondraDataSet alondraDataSet;
        private System.Windows.Forms.BindingSource alondraDataSetBindingSource1;
        private AlondraDataSet1 alondraDataSet1;
        private System.Windows.Forms.BindingSource provedoresBindingSource;
        private AlondraDataSet1TableAdapters.provedoresTableAdapter provedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEliminar;
    }
}

