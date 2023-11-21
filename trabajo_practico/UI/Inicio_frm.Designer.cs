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
            this.Ingresar_btn = new System.Windows.Forms.Button();
            this.Cerrar_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreUsuario1_lbl = new System.Windows.Forms.Label();
            this.NombreUsuario2_lbl = new System.Windows.Forms.Label();
            this.CerrarSesion1_btn = new System.Windows.Forms.Button();
            this.CerrarSesion2_btn = new System.Windows.Forms.Button();
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
            this.Registrarse_btn.Click += new System.EventHandler(this.Registrarse_btn_Click);
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
            // Ingresar_btn
            // 
            this.Ingresar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar_btn.Location = new System.Drawing.Point(91, 107);
            this.Ingresar_btn.Name = "Ingresar_btn";
            this.Ingresar_btn.Size = new System.Drawing.Size(93, 43);
            this.Ingresar_btn.TabIndex = 3;
            this.Ingresar_btn.Text = "Ingresar";
            this.Ingresar_btn.UseVisualStyleBackColor = true;
            this.Ingresar_btn.Click += new System.EventHandler(this.Ingresar_btn_Click);
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
            this.Cerrar_btn.Click += new System.EventHandler(this.Cerrar_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario 01:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario 02:";
            // 
            // NombreUsuario1_lbl
            // 
            this.NombreUsuario1_lbl.AutoSize = true;
            this.NombreUsuario1_lbl.Location = new System.Drawing.Point(79, 195);
            this.NombreUsuario1_lbl.Name = "NombreUsuario1_lbl";
            this.NombreUsuario1_lbl.Size = new System.Drawing.Size(111, 13);
            this.NombreUsuario1_lbl.TabIndex = 7;
            this.NombreUsuario1_lbl.Text = "Nombre de usuario 01";
            // 
            // NombreUsuario2_lbl
            // 
            this.NombreUsuario2_lbl.AutoSize = true;
            this.NombreUsuario2_lbl.Location = new System.Drawing.Point(79, 224);
            this.NombreUsuario2_lbl.Name = "NombreUsuario2_lbl";
            this.NombreUsuario2_lbl.Size = new System.Drawing.Size(111, 13);
            this.NombreUsuario2_lbl.TabIndex = 8;
            this.NombreUsuario2_lbl.Text = "Nombre de usuario 02";
            // 
            // CerrarSesion1_btn
            // 
            this.CerrarSesion1_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarSesion1_btn.Location = new System.Drawing.Point(199, 190);
            this.CerrarSesion1_btn.Name = "CerrarSesion1_btn";
            this.CerrarSesion1_btn.Size = new System.Drawing.Size(93, 23);
            this.CerrarSesion1_btn.TabIndex = 9;
            this.CerrarSesion1_btn.Text = "Cerrar sesión";
            this.CerrarSesion1_btn.UseVisualStyleBackColor = true;
            this.CerrarSesion1_btn.Visible = false;
            this.CerrarSesion1_btn.Click += new System.EventHandler(this.CerrarSesion1_btn_Click);
            // 
            // CerrarSesion2_btn
            // 
            this.CerrarSesion2_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarSesion2_btn.Location = new System.Drawing.Point(199, 219);
            this.CerrarSesion2_btn.Name = "CerrarSesion2_btn";
            this.CerrarSesion2_btn.Size = new System.Drawing.Size(93, 23);
            this.CerrarSesion2_btn.TabIndex = 10;
            this.CerrarSesion2_btn.Text = "Cerrar sesión";
            this.CerrarSesion2_btn.UseVisualStyleBackColor = true;
            this.CerrarSesion2_btn.Visible = false;
            this.CerrarSesion2_btn.Click += new System.EventHandler(this.CerrarSesion2_btn_Click);
            // 
            // Inicio_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 246);
            this.Controls.Add(this.CerrarSesion2_btn);
            this.Controls.Add(this.CerrarSesion1_btn);
            this.Controls.Add(this.NombreUsuario2_lbl);
            this.Controls.Add(this.NombreUsuario1_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cerrar_btn);
            this.Controls.Add(this.Ingresar_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jugar_btn);
            this.Controls.Add(this.Registrarse_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inicio_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - Trabajo Práctico";
            this.Load += new System.EventHandler(this.Inicio_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registrarse_btn;
        private System.Windows.Forms.Button Jugar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ingresar_btn;
        private System.Windows.Forms.Button Cerrar_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NombreUsuario1_lbl;
        private System.Windows.Forms.Label NombreUsuario2_lbl;
        private System.Windows.Forms.Button CerrarSesion1_btn;
        private System.Windows.Forms.Button CerrarSesion2_btn;
    }
}

