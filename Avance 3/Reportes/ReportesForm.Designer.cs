namespace Avance_3.Reportes
{
    partial class ReportesForm
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Compras = new System.Windows.Forms.DataGridView();
            this.DeFecha = new System.Windows.Forms.DateTimePicker();
            this.hastafecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(64, 313);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(105, 37);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Atrás";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.btn_Generate.FlatAppearance.BorderSize = 0;
            this.btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generate.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.btn_Generate.ForeColor = System.Drawing.Color.White;
            this.btn_Generate.Location = new System.Drawing.Point(697, 313);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(105, 37);
            this.btn_Generate.TabIndex = 7;
            this.btn_Generate.Text = "Generar";
            this.btn_Generate.UseVisualStyleBackColor = false;
            this.btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 25);
            this.panel1.TabIndex = 19;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(928, 0);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(25, 25);
            this.btn_Salir.TabIndex = 20;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(271, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "Reportes";
            // 
            // Compras
            // 
            this.Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Compras.Location = new System.Drawing.Point(64, 71);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(738, 223);
            this.Compras.TabIndex = 20;
            this.Compras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Compras_CellContentClick);
            // 
            // DeFecha
            // 
            this.DeFecha.Location = new System.Drawing.Point(64, 42);
            this.DeFecha.Name = "DeFecha";
            this.DeFecha.Size = new System.Drawing.Size(200, 20);
            this.DeFecha.TabIndex = 21;
            // 
            // hastafecha
            // 
            this.hastafecha.Location = new System.Drawing.Point(375, 45);
            this.hastafecha.Name = "hastafecha";
            this.hastafecha.Size = new System.Drawing.Size(200, 20);
            this.hastafecha.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "De";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(306, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Hasta";
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(956, 388);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hastafecha);
            this.Controls.Add(this.DeFecha);
            this.Controls.Add(this.Compras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesForm";
            this.Text = "ReportesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Compras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView Compras;
        private System.Windows.Forms.DateTimePicker DeFecha;
        private System.Windows.Forms.DateTimePicker hastafecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}