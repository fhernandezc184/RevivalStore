namespace Avance_3
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar contraseña";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_pass.Location = new System.Drawing.Point(225, 161);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(197, 24);
            this.txt_pass.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Verdana", 10F);
            this.txt_id.Location = new System.Drawing.Point(225, 123);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(197, 24);
            this.txt_id.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(235, 200);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(105, 37);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Ingresar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(69)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 25);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(185, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Revival App";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(410, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(25, 25);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(107, 247);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(51, 23);
            this.lbl_Date.TabIndex = 7;
            this.lbl_Date.Text = "date";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.lbl_Time.ForeColor = System.Drawing.Color.White;
            this.lbl_Time.Location = new System.Drawing.Point(177, 270);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(57, 23);
            this.lbl_Time.TabIndex = 8;
            this.lbl_Time.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(117, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 84);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(435, 300);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revival Store";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

