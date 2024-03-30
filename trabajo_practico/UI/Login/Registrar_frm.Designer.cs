namespace UI.Login
{
    partial class Registrar_frm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Error_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordRep_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Usuario_textBox = new System.Windows.Forms.TextBox();
            this.CrearUsuario_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.Nick_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nick_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Error_lbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PasswordRep_textBox);
            this.groupBox1.Controls.Add(this.Password_textBox);
            this.groupBox1.Controls.Add(this.Usuario_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 294);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear nuevo usuario";
            // 
            // Error_lbl
            // 
            this.Error_lbl.AutoSize = true;
            this.Error_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_lbl.ForeColor = System.Drawing.Color.Red;
            this.Error_lbl.Location = new System.Drawing.Point(6, 244);
            this.Error_lbl.Name = "Error_lbl";
            this.Error_lbl.Size = new System.Drawing.Size(87, 13);
            this.Error_lbl.TabIndex = 7;
            this.Error_lbl.Text = "Texto de error";
            this.Error_lbl.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "* Todos los campos son obligatorios *";
            // 
            // PasswordRep_textBox
            // 
            this.PasswordRep_textBox.Location = new System.Drawing.Point(9, 187);
            this.PasswordRep_textBox.Name = "PasswordRep_textBox";
            this.PasswordRep_textBox.PasswordChar = '*';
            this.PasswordRep_textBox.Size = new System.Drawing.Size(204, 20);
            this.PasswordRep_textBox.TabIndex = 5;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(9, 136);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(204, 20);
            this.Password_textBox.TabIndex = 4;
            // 
            // Usuario_textBox
            // 
            this.Usuario_textBox.Location = new System.Drawing.Point(9, 41);
            this.Usuario_textBox.Name = "Usuario_textBox";
            this.Usuario_textBox.Size = new System.Drawing.Size(204, 20);
            this.Usuario_textBox.TabIndex = 3;
            // 
            // CrearUsuario_btn
            // 
            this.CrearUsuario_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearUsuario_btn.Location = new System.Drawing.Point(12, 312);
            this.CrearUsuario_btn.Name = "CrearUsuario_btn";
            this.CrearUsuario_btn.Size = new System.Drawing.Size(89, 31);
            this.CrearUsuario_btn.TabIndex = 4;
            this.CrearUsuario_btn.Text = "Crear usuario";
            this.CrearUsuario_btn.UseVisualStyleBackColor = true;
            this.CrearUsuario_btn.Click += new System.EventHandler(this.CrearUsuario_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar_btn.Location = new System.Drawing.Point(216, 312);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(89, 31);
            this.Cancelar_btn.TabIndex = 5;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // Nick_textBox
            // 
            this.Nick_textBox.Location = new System.Drawing.Point(9, 88);
            this.Nick_textBox.Name = "Nick_textBox";
            this.Nick_textBox.Size = new System.Drawing.Size(204, 20);
            this.Nick_textBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apodo";
            // 
            // Registrar_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 355);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.CrearUsuario_btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registrar_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo usuario";
            this.Load += new System.EventHandler(this.Registrar_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordRep_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Usuario_textBox;
        private System.Windows.Forms.Button CrearUsuario_btn;
        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.Label Error_lbl;
        private System.Windows.Forms.TextBox Nick_textBox;
        private System.Windows.Forms.Label label5;
    }
}