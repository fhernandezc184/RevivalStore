namespace Avance_3.Facturas
{
    partial class FacturaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaForm));
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoAPagar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lbleninventario = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btncrearfactura = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblDescuentoAplicado = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuentoAplicado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtm_Fecha = new System.Windows.Forms.DateTimePicker();
            this.cmbdescuento = new System.Windows.Forms.ComboBox();
            this.lblprendascomprar = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Prenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_prendas_comprar = new System.Windows.Forms.DataGridView();
            this.dgv_inventario = new System.Windows.Forms.DataGridView();
            this.btn_agregar_compras = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.detallePrendaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idPrenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblcedula = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prendas_comprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lblNumeroFactura.ForeColor = System.Drawing.Color.White;
            this.lblNumeroFactura.Location = new System.Drawing.Point(12, 40);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(161, 23);
            this.lblNumeroFactura.TabIndex = 1;
            this.lblNumeroFactura.Text = "Numero Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monto total a pagar";
            // 
            // txtMontoAPagar
            // 
            this.txtMontoAPagar.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtMontoAPagar.Location = new System.Drawing.Point(245, 206);
            this.txtMontoAPagar.Name = "txtMontoAPagar";
            this.txtMontoAPagar.Size = new System.Drawing.Size(139, 24);
            this.txtMontoAPagar.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtNombre.Location = new System.Drawing.Point(245, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 24);
            this.txtNombre.TabIndex = 7;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtNumeroFactura.Location = new System.Drawing.Point(248, 43);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(136, 24);
            this.txtNumeroFactura.TabIndex = 8;
            // 
            // lbleninventario
            // 
            this.lbleninventario.AutoSize = true;
            this.lbleninventario.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lbleninventario.ForeColor = System.Drawing.Color.White;
            this.lbleninventario.Location = new System.Drawing.Point(425, 40);
            this.lbleninventario.Name = "lbleninventario";
            this.lbleninventario.Size = new System.Drawing.Size(139, 23);
            this.lbleninventario.TabIndex = 9;
            this.lbleninventario.Text = "En Inventario";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(18, 581);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(201, 37);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "Atrás";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // btncrearfactura
            // 
            this.btncrearfactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.btncrearfactura.FlatAppearance.BorderSize = 0;
            this.btncrearfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrearfactura.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.btncrearfactura.ForeColor = System.Drawing.Color.White;
            this.btncrearfactura.Location = new System.Drawing.Point(771, 575);
            this.btncrearfactura.Name = "btncrearfactura";
            this.btncrearfactura.Size = new System.Drawing.Size(201, 37);
            this.btncrearfactura.TabIndex = 12;
            this.btncrearfactura.Text = "Crear Factura";
            this.btncrearfactura.UseVisualStyleBackColor = false;
            this.btncrearfactura.Click += new System.EventHandler(this.Btncrearfactura_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 25);
            this.panel1.TabIndex = 14;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(989, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(25, 25);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lblEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado.Location = new System.Drawing.Point(14, 189);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(0, 23);
            this.lblEmpleado.TabIndex = 15;
            // 
            // lblDescuentoAplicado
            // 
            this.lblDescuentoAplicado.AutoSize = true;
            this.lblDescuentoAplicado.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lblDescuentoAplicado.ForeColor = System.Drawing.Color.White;
            this.lblDescuentoAplicado.Location = new System.Drawing.Point(12, 166);
            this.lblDescuentoAplicado.Name = "lblDescuentoAplicado";
            this.lblDescuentoAplicado.Size = new System.Drawing.Size(199, 23);
            this.lblDescuentoAplicado.TabIndex = 16;
            this.lblDescuentoAplicado.Text = "Descuento Aplicado";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lblDescuento.ForeColor = System.Drawing.Color.White;
            this.lblDescuento.Location = new System.Drawing.Point(12, 125);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(110, 23);
            this.lblDescuento.TabIndex = 17;
            this.lblDescuento.Text = "Descuento";
            // 
            // txtDescuentoAplicado
            // 
            this.txtDescuentoAplicado.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtDescuentoAplicado.Location = new System.Drawing.Point(245, 169);
            this.txtDescuentoAplicado.Name = "txtDescuentoAplicado";
            this.txtDescuentoAplicado.ReadOnly = true;
            this.txtDescuentoAplicado.Size = new System.Drawing.Size(139, 24);
            this.txtDescuentoAplicado.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(244, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha";
            // 
            // dtm_Fecha
            // 
            this.dtm_Fecha.Font = new System.Drawing.Font("Verdana", 10F);
            this.dtm_Fecha.Location = new System.Drawing.Point(336, 588);
            this.dtm_Fecha.Name = "dtm_Fecha";
            this.dtm_Fecha.Size = new System.Drawing.Size(270, 24);
            this.dtm_Fecha.TabIndex = 5;
            // 
            // cmbdescuento
            // 
            this.cmbdescuento.FormattingEnabled = true;
            this.cmbdescuento.Location = new System.Drawing.Point(245, 130);
            this.cmbdescuento.Name = "cmbdescuento";
            this.cmbdescuento.Size = new System.Drawing.Size(139, 21);
            this.cmbdescuento.TabIndex = 20;
            // 
            // lblprendascomprar
            // 
            this.lblprendascomprar.AutoSize = true;
            this.lblprendascomprar.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lblprendascomprar.ForeColor = System.Drawing.Color.White;
            this.lblprendascomprar.Location = new System.Drawing.Point(425, 309);
            this.lblprendascomprar.Name = "lblprendascomprar";
            this.lblprendascomprar.Size = new System.Drawing.Size(192, 23);
            this.lblprendascomprar.TabIndex = 23;
            this.lblprendascomprar.Text = "Prendas a Comprar";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // c_Prenda
            // 
            this.c_Prenda.Name = "c_Prenda";
            // 
            // c_Price
            // 
            this.c_Price.Name = "c_Price";
            // 
            // c_Marca
            // 
            this.c_Marca.Name = "c_Marca";
            // 
            // c_Talla
            // 
            this.c_Talla.Name = "c_Talla";
            // 
            // dgv_prendas_comprar
            // 
            this.dgv_prendas_comprar.AllowUserToAddRows = false;
            this.dgv_prendas_comprar.AllowUserToDeleteRows = false;
            this.dgv_prendas_comprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prendas_comprar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.detallePrendaid,
            this.Prenda,
            this.Precio,
            this.Marca,
            this.Talla});
            this.dgv_prendas_comprar.Location = new System.Drawing.Point(429, 335);
            this.dgv_prendas_comprar.Name = "dgv_prendas_comprar";
            this.dgv_prendas_comprar.Size = new System.Drawing.Size(643, 234);
            this.dgv_prendas_comprar.TabIndex = 26;
            // 
            // dgv_inventario
            // 
            this.dgv_inventario.AllowUserToAddRows = false;
            this.dgv_inventario.AllowUserToDeleteRows = false;
            this.dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.idPrenda,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Cantidad});
            this.dgv_inventario.Location = new System.Drawing.Point(429, 66);
            this.dgv_inventario.Name = "dgv_inventario";
            this.dgv_inventario.Size = new System.Drawing.Size(643, 234);
            this.dgv_inventario.TabIndex = 27;
            // 
            // btn_agregar_compras
            // 
            this.btn_agregar_compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.btn_agregar_compras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar_compras.BackgroundImage")));
            this.btn_agregar_compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_agregar_compras.FlatAppearance.BorderSize = 0;
            this.btn_agregar_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_compras.Font = new System.Drawing.Font("Verdana", 12F);
            this.btn_agregar_compras.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_compras.Location = new System.Drawing.Point(301, 398);
            this.btn_agregar_compras.Name = "btn_agregar_compras";
            this.btn_agregar_compras.Size = new System.Drawing.Size(57, 52);
            this.btn_agregar_compras.TabIndex = 28;
            this.btn_agregar_compras.UseVisualStyleBackColor = false;
            this.btn_agregar_compras.Click += new System.EventHandler(this.Btn_agregar_compras_Click);
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // detallePrendaid
            // 
            this.detallePrendaid.HeaderText = "PrendaID";
            this.detallePrendaid.Name = "detallePrendaid";
            // 
            // Prenda
            // 
            this.Prenda.HeaderText = "Prenda";
            this.Prenda.Name = "Prenda";
            this.Prenda.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Talla
            // 
            this.Talla.HeaderText = "Talla";
            this.Talla.Name = "Talla";
            this.Talla.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccionar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // idPrenda
            // 
            this.idPrenda.HeaderText = "idPrenda";
            this.idPrenda.Name = "idPrenda";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Prenda";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lblcedula.ForeColor = System.Drawing.Color.White;
            this.lblcedula.Location = new System.Drawing.Point(12, 249);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(145, 23);
            this.lblcedula.TabIndex = 29;
            this.lblcedula.Text = "Cedula cliente";
            // 
            // txtcedula
            // 
            this.txtcedula.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtcedula.Location = new System.Drawing.Point(248, 252);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(139, 24);
            this.txtcedula.TabIndex = 30;
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1109, 630);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.lblcedula);
            this.Controls.Add(this.btn_agregar_compras);
            this.Controls.Add(this.dgv_inventario);
            this.Controls.Add(this.dgv_prendas_comprar);
            this.Controls.Add(this.lblprendascomprar);
            this.Controls.Add(this.cmbdescuento);
            this.Controls.Add(this.txtDescuentoAplicado);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblDescuentoAplicado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncrearfactura);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbleninventario);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMontoAPagar);
            this.Controls.Add(this.dtm_Fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumeroFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prendas_comprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoAPagar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lbleninventario;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btncrearfactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblDescuentoAplicado;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuentoAplicado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtm_Fecha;
        private System.Windows.Forms.ComboBox cmbdescuento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c_Check;
        private System.Windows.Forms.Label lblprendascomprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Prenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Talla;
        private System.Windows.Forms.DataGridView dgv_prendas_comprar;
        private System.Windows.Forms.DataGridView dgv_inventario;
        private System.Windows.Forms.Button btn_agregar_compras;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallePrendaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talla;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.TextBox txtcedula;
    }
}