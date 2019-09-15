namespace Avance_3.UI
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Facturas = new System.Windows.Forms.Button();
            this.pnl_factura = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_inventarios = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_factura.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 25);
            this.panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(290, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(25, 25);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(106, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Interfaz de usuario";
            // 
            // btn_Facturas
            // 
            this.btn_Facturas.BackColor = System.Drawing.Color.Transparent;
            this.btn_Facturas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Facturas.BackgroundImage")));
            this.btn_Facturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Facturas.FlatAppearance.BorderSize = 0;
            this.btn_Facturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facturas.ForeColor = System.Drawing.Color.Black;
            this.btn_Facturas.Location = new System.Drawing.Point(2, 2);
            this.btn_Facturas.Name = "btn_Facturas";
            this.btn_Facturas.Size = new System.Drawing.Size(97, 97);
            this.btn_Facturas.TabIndex = 1;
            this.btn_Facturas.UseVisualStyleBackColor = false;
            this.btn_Facturas.Click += new System.EventHandler(this.Btn_Facturas_Click);
            // 
            // pnl_factura
            // 
            this.pnl_factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.pnl_factura.Controls.Add(this.label1);
            this.pnl_factura.Controls.Add(this.btn_Facturas);
            this.pnl_factura.Location = new System.Drawing.Point(57, 70);
            this.pnl_factura.Name = "pnl_factura";
            this.pnl_factura.Size = new System.Drawing.Size(100, 100);
            this.pnl_factura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Facturas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Reportes);
            this.panel2.Location = new System.Drawing.Point(174, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 100);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reportes";
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Reportes.BackgroundImage")));
            this.btn_Reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Reportes.FlatAppearance.BorderSize = 0;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Location = new System.Drawing.Point(1, 1);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(97, 97);
            this.btn_Reportes.TabIndex = 6;
            this.btn_Reportes.UseVisualStyleBackColor = true;
            this.btn_Reportes.Click += new System.EventHandler(this.Btn_Reportes_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btn_inventarios);
            this.panel4.Location = new System.Drawing.Point(109, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 100);
            this.panel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inventario";
            // 
            // btn_inventarios
            // 
            this.btn_inventarios.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inventarios.BackgroundImage")));
            this.btn_inventarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_inventarios.FlatAppearance.BorderSize = 0;
            this.btn_inventarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventarios.ForeColor = System.Drawing.Color.Black;
            this.btn_inventarios.Location = new System.Drawing.Point(0, 3);
            this.btn_inventarios.Name = "btn_inventarios";
            this.btn_inventarios.Size = new System.Drawing.Size(97, 97);
            this.btn_inventarios.TabIndex = 5;
            this.btn_inventarios.UseVisualStyleBackColor = false;
            this.btn_inventarios.Click += new System.EventHandler(this.Btn_inventarios_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(74, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bienvenido";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(184, 32);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(80, 23);
            this.lbl_user.TabIndex = 7;
            this.lbl_user.Text = "usuario";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(316, 331);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_factura);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_factura.ResumeLayout(false);
            this.pnl_factura.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Facturas;
        private System.Windows.Forms.Panel pnl_factura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_inventarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Exit;
    }
}