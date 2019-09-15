namespace Avance_3.Pedidos
{
    partial class PedidoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Pedidos = new System.Windows.Forms.DataGridView();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Vivienda = new System.Windows.Forms.TextBox();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.txt_Pedido = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_pedidos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pedidos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirección del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cédula del cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "No. de pedido";
            // 
            // dgv_Pedidos
            // 
            this.dgv_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pedidos.Location = new System.Drawing.Point(459, 53);
            this.dgv_Pedidos.Name = "dgv_Pedidos";
            this.dgv_Pedidos.ReadOnly = true;
            this.dgv_Pedidos.Size = new System.Drawing.Size(533, 187);
            this.dgv_Pedidos.TabIndex = 6;
            this.dgv_Pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Pedidos_CellClick);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Nombre.Location = new System.Drawing.Point(237, 83);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(216, 24);
            this.txt_Nombre.TabIndex = 7;
            // 
            // txt_Vivienda
            // 
            this.txt_Vivienda.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Vivienda.Location = new System.Drawing.Point(237, 113);
            this.txt_Vivienda.Name = "txt_Vivienda";
            this.txt_Vivienda.Size = new System.Drawing.Size(216, 24);
            this.txt_Vivienda.TabIndex = 8;
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Cedula.Location = new System.Drawing.Point(237, 143);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(216, 24);
            this.txt_Cedula.TabIndex = 9;
            // 
            // txt_Pedido
            // 
            this.txt_Pedido.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_Pedido.Location = new System.Drawing.Point(237, 173);
            this.txt_Pedido.Name = "txt_Pedido";
            this.txt_Pedido.Size = new System.Drawing.Size(216, 24);
            this.txt_Pedido.TabIndex = 10;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(237, 256);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(105, 37);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "Atrás";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.btn_Check.FlatAppearance.BorderSize = 0;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.btn_Check.ForeColor = System.Drawing.Color.White;
            this.btn_Check.Location = new System.Drawing.Point(348, 256);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(105, 37);
            this.btn_Check.TabIndex = 12;
            this.btn_Check.Text = "Revisar";
            this.btn_Check.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.lbl_pedidos);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 13;
            // 
            // lbl_pedidos
            // 
            this.lbl_pedidos.AutoSize = true;
            this.lbl_pedidos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pedidos.ForeColor = System.Drawing.Color.White;
            this.lbl_pedidos.Location = new System.Drawing.Point(340, 5);
            this.lbl_pedidos.Name = "lbl_pedidos";
            this.lbl_pedidos.Size = new System.Drawing.Size(124, 14);
            this.lbl_pedidos.TabIndex = 9;
            this.lbl_pedidos.Text = "Revisión de pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_ID.Location = new System.Drawing.Point(237, 53);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(216, 24);
            this.txt_ID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Status";
            // 
            // cmb_Status
            // 
            this.cmb_Status.Font = new System.Drawing.Font("Verdana", 10F);
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(237, 203);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(216, 24);
            this.cmb_Status.TabIndex = 17;
            // 
            // PedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1090, 287);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txt_Pedido);
            this.Controls.Add(this.txt_Cedula);
            this.Controls.Add(this.txt_Vivienda);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.dgv_Pedidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidoForm";
            this.Load += new System.EventHandler(this.PedidoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pedidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Pedidos;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Vivienda;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.TextBox txt_Pedido;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_pedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Status;
    }
}