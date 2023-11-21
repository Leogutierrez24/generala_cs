namespace UI.Juego
{
    partial class ResumenPartida_frm
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
            this.JugadorGanador_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PtsJugador02_lbl = new System.Windows.Forms.Label();
            this.PtsJugador01_lbl = new System.Windows.Forms.Label();
            this.PtsJugador02Titulo_lbl = new System.Windows.Forms.Label();
            this.PtsJugador01Titulo_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TablaCategorias_dataGridView = new System.Windows.Forms.DataGridView();
            this.VolverJugar_btn = new System.Windows.Forms.Button();
            this.VolverInicio_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCategorias_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jugador Ganador:";
            // 
            // JugadorGanador_lbl
            // 
            this.JugadorGanador_lbl.AutoSize = true;
            this.JugadorGanador_lbl.Location = new System.Drawing.Point(110, 9);
            this.JugadorGanador_lbl.Name = "JugadorGanador_lbl";
            this.JugadorGanador_lbl.Size = new System.Drawing.Size(87, 13);
            this.JugadorGanador_lbl.TabIndex = 1;
            this.JugadorGanador_lbl.Text = "nombre_ganador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PtsJugador02_lbl);
            this.groupBox1.Controls.Add(this.PtsJugador01_lbl);
            this.groupBox1.Controls.Add(this.PtsJugador02Titulo_lbl);
            this.groupBox1.Controls.Add(this.PtsJugador01Titulo_lbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TablaCategorias_dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 373);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puntajes";
            // 
            // PtsJugador02_lbl
            // 
            this.PtsJugador02_lbl.AutoSize = true;
            this.PtsJugador02_lbl.Location = new System.Drawing.Point(149, 344);
            this.PtsJugador02_lbl.Name = "PtsJugador02_lbl";
            this.PtsJugador02_lbl.Size = new System.Drawing.Size(74, 13);
            this.PtsJugador02_lbl.TabIndex = 7;
            this.PtsJugador02_lbl.Text = "jugador02_pts";
            // 
            // PtsJugador01_lbl
            // 
            this.PtsJugador01_lbl.AutoSize = true;
            this.PtsJugador01_lbl.Location = new System.Drawing.Point(149, 321);
            this.PtsJugador01_lbl.Name = "PtsJugador01_lbl";
            this.PtsJugador01_lbl.Size = new System.Drawing.Size(74, 13);
            this.PtsJugador01_lbl.TabIndex = 6;
            this.PtsJugador01_lbl.Text = "jugador01_pts";
            // 
            // PtsJugador02Titulo_lbl
            // 
            this.PtsJugador02Titulo_lbl.AutoSize = true;
            this.PtsJugador02Titulo_lbl.Location = new System.Drawing.Point(6, 344);
            this.PtsJugador02Titulo_lbl.Name = "PtsJugador02Titulo_lbl";
            this.PtsJugador02Titulo_lbl.Size = new System.Drawing.Size(63, 13);
            this.PtsJugador02Titulo_lbl.TabIndex = 5;
            this.PtsJugador02Titulo_lbl.Text = "Pts jugador:";
            // 
            // PtsJugador01Titulo_lbl
            // 
            this.PtsJugador01Titulo_lbl.AutoSize = true;
            this.PtsJugador01Titulo_lbl.Location = new System.Drawing.Point(6, 321);
            this.PtsJugador01Titulo_lbl.Name = "PtsJugador01Titulo_lbl";
            this.PtsJugador01Titulo_lbl.Size = new System.Drawing.Size(63, 13);
            this.PtsJugador01Titulo_lbl.TabIndex = 4;
            this.PtsJugador01Titulo_lbl.Text = "Pts jugador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tabla de categorias";
            // 
            // TablaCategorias_dataGridView
            // 
            this.TablaCategorias_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCategorias_dataGridView.Location = new System.Drawing.Point(6, 42);
            this.TablaCategorias_dataGridView.Name = "TablaCategorias_dataGridView";
            this.TablaCategorias_dataGridView.Size = new System.Drawing.Size(401, 265);
            this.TablaCategorias_dataGridView.TabIndex = 0;
            // 
            // VolverJugar_btn
            // 
            this.VolverJugar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolverJugar_btn.Location = new System.Drawing.Point(74, 415);
            this.VolverJugar_btn.Name = "VolverJugar_btn";
            this.VolverJugar_btn.Size = new System.Drawing.Size(90, 40);
            this.VolverJugar_btn.TabIndex = 3;
            this.VolverJugar_btn.Text = "Volver a jugar";
            this.VolverJugar_btn.UseVisualStyleBackColor = true;
            this.VolverJugar_btn.Click += new System.EventHandler(this.VolverJugar_btn_Click);
            // 
            // VolverInicio_btn
            // 
            this.VolverInicio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolverInicio_btn.Location = new System.Drawing.Point(283, 415);
            this.VolverInicio_btn.Name = "VolverInicio_btn";
            this.VolverInicio_btn.Size = new System.Drawing.Size(90, 40);
            this.VolverInicio_btn.TabIndex = 4;
            this.VolverInicio_btn.Text = "Volver al inicio";
            this.VolverInicio_btn.UseVisualStyleBackColor = true;
            this.VolverInicio_btn.Click += new System.EventHandler(this.VolverInicio_btn_Click);
            // 
            // ResumenPartida_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 476);
            this.Controls.Add(this.VolverInicio_btn);
            this.Controls.Add(this.VolverJugar_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.JugadorGanador_lbl);
            this.Controls.Add(this.label1);
            this.Name = "ResumenPartida_frm";
            this.Text = "Resumen de la partida";
            this.Load += new System.EventHandler(this.ResumenPartida_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCategorias_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label JugadorGanador_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TablaCategorias_dataGridView;
        private System.Windows.Forms.Label PtsJugador02_lbl;
        private System.Windows.Forms.Label PtsJugador01_lbl;
        private System.Windows.Forms.Label PtsJugador02Titulo_lbl;
        private System.Windows.Forms.Label PtsJugador01Titulo_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VolverJugar_btn;
        private System.Windows.Forms.Button VolverInicio_btn;
    }
}