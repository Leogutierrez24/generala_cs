namespace UI.Juego
{
    partial class Tablero_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Tablero_dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Tiros_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cubilete_listBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DadosApartados_listBox = new System.Windows.Forms.ListBox();
            this.DadosEnTablero_listBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Jugador_groupBox = new System.Windows.Forms.GroupBox();
            this.TerminarTurno_btn = new System.Windows.Forms.Button();
            this.CerrarCategoria_btn = new System.Windows.Forms.Button();
            this.TirarDados_btn = new System.Windows.Forms.Button();
            this.ApartarDados_btn = new System.Windows.Forms.Button();
            this.PonerDados_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PonerTodos_btn = new System.Windows.Forms.Button();
            this.Ayuda_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero_dataGridView)).BeginInit();
            this.Jugador_groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generala";
            // 
            // Tablero_dataGridView
            // 
            this.Tablero_dataGridView.AllowUserToDeleteRows = false;
            this.Tablero_dataGridView.AllowUserToResizeRows = false;
            this.Tablero_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablero_dataGridView.Location = new System.Drawing.Point(16, 35);
            this.Tablero_dataGridView.Name = "Tablero_dataGridView";
            this.Tablero_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tablero_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Tablero_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Tablero_dataGridView.Size = new System.Drawing.Size(388, 338);
            this.Tablero_dataGridView.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tabla de Puntuaciones";
            // 
            // Tiros_lbl
            // 
            this.Tiros_lbl.AutoSize = true;
            this.Tiros_lbl.Location = new System.Drawing.Point(97, 19);
            this.Tiros_lbl.Name = "Tiros_lbl";
            this.Tiros_lbl.Size = new System.Drawing.Size(13, 13);
            this.Tiros_lbl.TabIndex = 2;
            this.Tiros_lbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tiros restantes:";
            // 
            // Cubilete_listBox
            // 
            this.Cubilete_listBox.FormattingEnabled = true;
            this.Cubilete_listBox.Location = new System.Drawing.Point(15, 50);
            this.Cubilete_listBox.Name = "Cubilete_listBox";
            this.Cubilete_listBox.Size = new System.Drawing.Size(120, 160);
            this.Cubilete_listBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cubilete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dados apartados";
            // 
            // DadosApartados_listBox
            // 
            this.DadosApartados_listBox.FormattingEnabled = true;
            this.DadosApartados_listBox.Location = new System.Drawing.Point(422, 288);
            this.DadosApartados_listBox.Name = "DadosApartados_listBox";
            this.DadosApartados_listBox.Size = new System.Drawing.Size(233, 160);
            this.DadosApartados_listBox.TabIndex = 5;
            // 
            // DadosEnTablero_listBox
            // 
            this.DadosEnTablero_listBox.FormattingEnabled = true;
            this.DadosEnTablero_listBox.Location = new System.Drawing.Point(422, 48);
            this.DadosEnTablero_listBox.Name = "DadosEnTablero_listBox";
            this.DadosEnTablero_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.DadosEnTablero_listBox.Size = new System.Drawing.Size(233, 121);
            this.DadosEnTablero_listBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dados en juego";
            // 
            // Jugador_groupBox
            // 
            this.Jugador_groupBox.Controls.Add(this.TerminarTurno_btn);
            this.Jugador_groupBox.Controls.Add(this.CerrarCategoria_btn);
            this.Jugador_groupBox.Controls.Add(this.TirarDados_btn);
            this.Jugador_groupBox.Controls.Add(this.label4);
            this.Jugador_groupBox.Controls.Add(this.Tiros_lbl);
            this.Jugador_groupBox.Controls.Add(this.Cubilete_listBox);
            this.Jugador_groupBox.Controls.Add(this.label6);
            this.Jugador_groupBox.Location = new System.Drawing.Point(692, 38);
            this.Jugador_groupBox.Name = "Jugador_groupBox";
            this.Jugador_groupBox.Size = new System.Drawing.Size(249, 260);
            this.Jugador_groupBox.TabIndex = 9;
            this.Jugador_groupBox.TabStop = false;
            this.Jugador_groupBox.Text = "Jugador en juego";
            // 
            // TerminarTurno_btn
            // 
            this.TerminarTurno_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TerminarTurno_btn.Location = new System.Drawing.Point(141, 126);
            this.TerminarTurno_btn.Name = "TerminarTurno_btn";
            this.TerminarTurno_btn.Size = new System.Drawing.Size(95, 32);
            this.TerminarTurno_btn.TabIndex = 11;
            this.TerminarTurno_btn.Text = "Terminar Turno";
            this.TerminarTurno_btn.UseVisualStyleBackColor = true;
            this.TerminarTurno_btn.Click += new System.EventHandler(this.TerminarTurno_btn_Click);
            // 
            // CerrarCategoria_btn
            // 
            this.CerrarCategoria_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarCategoria_btn.Location = new System.Drawing.Point(141, 88);
            this.CerrarCategoria_btn.Name = "CerrarCategoria_btn";
            this.CerrarCategoria_btn.Size = new System.Drawing.Size(95, 32);
            this.CerrarCategoria_btn.TabIndex = 10;
            this.CerrarCategoria_btn.Text = "Cerrar Categoria";
            this.CerrarCategoria_btn.UseVisualStyleBackColor = true;
            this.CerrarCategoria_btn.Click += new System.EventHandler(this.CerrarCategoria_btn_Click);
            // 
            // TirarDados_btn
            // 
            this.TirarDados_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TirarDados_btn.Location = new System.Drawing.Point(141, 50);
            this.TirarDados_btn.Name = "TirarDados_btn";
            this.TirarDados_btn.Size = new System.Drawing.Size(95, 32);
            this.TirarDados_btn.TabIndex = 7;
            this.TirarDados_btn.Text = "Tirar Dados";
            this.TirarDados_btn.UseVisualStyleBackColor = true;
            this.TirarDados_btn.Click += new System.EventHandler(this.TirarDados_btn_Click);
            // 
            // ApartarDados_btn
            // 
            this.ApartarDados_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApartarDados_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ApartarDados_btn.Location = new System.Drawing.Point(566, 175);
            this.ApartarDados_btn.Name = "ApartarDados_btn";
            this.ApartarDados_btn.Size = new System.Drawing.Size(89, 32);
            this.ApartarDados_btn.TabIndex = 9;
            this.ApartarDados_btn.Text = "Apartar Dados";
            this.ApartarDados_btn.UseVisualStyleBackColor = true;
            this.ApartarDados_btn.Click += new System.EventHandler(this.ApartarDados_btn_Click);
            // 
            // PonerDados_btn
            // 
            this.PonerDados_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PonerDados_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PonerDados_btn.Location = new System.Drawing.Point(422, 175);
            this.PonerDados_btn.Name = "PonerDados_btn";
            this.PonerDados_btn.Size = new System.Drawing.Size(89, 41);
            this.PonerDados_btn.TabIndex = 8;
            this.PonerDados_btn.Text = "Agregar dados al cubilete";
            this.PonerDados_btn.UseVisualStyleBackColor = true;
            this.PonerDados_btn.Click += new System.EventHandler(this.PonerDados_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::UI.Properties.Resources.tablero_background;
            this.groupBox2.Controls.Add(this.PonerTodos_btn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DadosEnTablero_listBox);
            this.groupBox2.Controls.Add(this.PonerDados_btn);
            this.groupBox2.Controls.Add(this.ApartarDados_btn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Tablero_dataGridView);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DadosApartados_listBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(12, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 462);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tablero";
            // 
            // PonerTodos_btn
            // 
            this.PonerTodos_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PonerTodos_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PonerTodos_btn.Location = new System.Drawing.Point(422, 222);
            this.PonerTodos_btn.Name = "PonerTodos_btn";
            this.PonerTodos_btn.Size = new System.Drawing.Size(89, 41);
            this.PonerTodos_btn.TabIndex = 10;
            this.PonerTodos_btn.Text = "Agregar todos";
            this.PonerTodos_btn.UseVisualStyleBackColor = true;
            this.PonerTodos_btn.Click += new System.EventHandler(this.PonerTodos_btn_Click);
            // 
            // Ayuda_btn
            // 
            this.Ayuda_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ayuda_btn.Location = new System.Drawing.Point(866, 477);
            this.Ayuda_btn.Name = "Ayuda_btn";
            this.Ayuda_btn.Size = new System.Drawing.Size(75, 23);
            this.Ayuda_btn.TabIndex = 11;
            this.Ayuda_btn.Text = "Ayuda";
            this.Ayuda_btn.UseVisualStyleBackColor = true;
            this.Ayuda_btn.Click += new System.EventHandler(this.Ayuda_btn_Click);
            // 
            // Tablero_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 545);
            this.Controls.Add(this.Ayuda_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Jugador_groupBox);
            this.Controls.Add(this.label1);
            this.Name = "Tablero_frm";
            this.Text = "Generala";
            this.Load += new System.EventHandler(this.Tablero_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablero_dataGridView)).EndInit();
            this.Jugador_groupBox.ResumeLayout(false);
            this.Jugador_groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Tablero_dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tiros_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Cubilete_listBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox DadosApartados_listBox;
        private System.Windows.Forms.ListBox DadosEnTablero_listBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox Jugador_groupBox;
        private System.Windows.Forms.Button TerminarTurno_btn;
        private System.Windows.Forms.Button CerrarCategoria_btn;
        private System.Windows.Forms.Button ApartarDados_btn;
        private System.Windows.Forms.Button PonerDados_btn;
        private System.Windows.Forms.Button TirarDados_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Ayuda_btn;
        private System.Windows.Forms.Button PonerTodos_btn;
    }
}