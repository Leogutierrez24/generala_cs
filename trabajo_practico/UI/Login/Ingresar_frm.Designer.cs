namespace UI.Login
{
    partial class Ingresar_frm
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
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Usuario_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Error_lbl = new System.Windows.Forms.Label();
            this.Ingresar_btn = new System.Windows.Forms.Button();
            this.Volver_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(12, 74);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(266, 20);
            this.Password_textBox.TabIndex = 8;
            // 
            // Usuario_textBox
            // 
            this.Usuario_textBox.Location = new System.Drawing.Point(12, 25);
            this.Usuario_textBox.Name = "Usuario_textBox";
            this.Usuario_textBox.Size = new System.Drawing.Size(266, 20);
            this.Usuario_textBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // Error_lbl
            // 
            this.Error_lbl.AutoSize = true;
            this.Error_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_lbl.ForeColor = System.Drawing.Color.Red;
            this.Error_lbl.Location = new System.Drawing.Point(12, 106);
            this.Error_lbl.Name = "Error_lbl";
            this.Error_lbl.Size = new System.Drawing.Size(87, 13);
            this.Error_lbl.TabIndex = 9;
            this.Error_lbl.Text = "Texto de error";
            this.Error_lbl.Visible = false;
            // 
            // Ingresar_btn
            // 
            this.Ingresar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ingresar_btn.Location = new System.Drawing.Point(12, 131);
            this.Ingresar_btn.Name = "Ingresar_btn";
            this.Ingresar_btn.Size = new System.Drawing.Size(87, 34);
            this.Ingresar_btn.TabIndex = 10;
            this.Ingresar_btn.Text = "Ingresar";
            this.Ingresar_btn.UseVisualStyleBackColor = true;
            this.Ingresar_btn.Click += new System.EventHandler(this.Ingresar_btn_Click);
            // 
            // Volver_btn
            // 
            this.Volver_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Volver_btn.Location = new System.Drawing.Point(129, 131);
            this.Volver_btn.Name = "Volver_btn";
            this.Volver_btn.Size = new System.Drawing.Size(87, 34);
            this.Volver_btn.TabIndex = 11;
            this.Volver_btn.Text = "Volver al inicio";
            this.Volver_btn.UseVisualStyleBackColor = true;
            this.Volver_btn.Click += new System.EventHandler(this.Volver_btn_Click);
            // 
            // Ingresar_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 177);
            this.Controls.Add(this.Volver_btn);
            this.Controls.Add(this.Ingresar_btn);
            this.Controls.Add(this.Error_lbl);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Usuario_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Ingresar_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.Ingresar_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Usuario_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Error_lbl;
        private System.Windows.Forms.Button Ingresar_btn;
        private System.Windows.Forms.Button Volver_btn;
    }
}