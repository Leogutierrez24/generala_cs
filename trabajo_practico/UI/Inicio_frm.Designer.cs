namespace UI
{
    partial class Inicio_frm
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
            this.Registrarse_btn = new System.Windows.Forms.Button();
            this.Jugar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Cerrar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Registrarse_btn
            // 
            this.Registrarse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarse_btn.Location = new System.Drawing.Point(91, 58);
            this.Registrarse_btn.Name = "Registrarse_btn";
            this.Registrarse_btn.Size = new System.Drawing.Size(93, 43);
            this.Registrarse_btn.TabIndex = 0;
            this.Registrarse_btn.Text = "Registrarse";
            this.Registrarse_btn.UseVisualStyleBackColor = true;
            // 
            // Jugar_btn
            // 
            this.Jugar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jugar_btn.Location = new System.Drawing.Point(199, 58);
            this.Jugar_btn.Name = "Jugar_btn";
            this.Jugar_btn.Size = new System.Drawing.Size(93, 43);
            this.Jugar_btn.TabIndex = 1;
            this.Jugar_btn.Text = "Jugar a la Generala";
            this.Jugar_btn.UseVisualStyleBackColor = true;
            this.Jugar_btn.Click += new System.EventHandler(this.Jugar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trabajo Práctico: Generala";
            // 
            // Login_btn
            // 
            this.Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(91, 107);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(93, 43);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Text = "Ingresar";
            this.Login_btn.UseVisualStyleBackColor = true;
            // 
            // Cerrar_btn
            // 
            this.Cerrar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar_btn.Location = new System.Drawing.Point(199, 107);
            this.Cerrar_btn.Name = "Cerrar_btn";
            this.Cerrar_btn.Size = new System.Drawing.Size(93, 43);
            this.Cerrar_btn.TabIndex = 4;
            this.Cerrar_btn.Text = "Salir";
            this.Cerrar_btn.UseVisualStyleBackColor = true;
            // 
            // Inicio_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 190);
            this.Controls.Add(this.Cerrar_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jugar_btn);
            this.Controls.Add(this.Registrarse_btn);
            this.MaximizeBox = false;
            this.Name = "Inicio_frm";
            this.Text = "Inicio - Trabajo Práctico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registrarse_btn;
        private System.Windows.Forms.Button Jugar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Cerrar_btn;
    }
}

