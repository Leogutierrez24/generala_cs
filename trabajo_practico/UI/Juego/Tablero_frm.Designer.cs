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
            this.label1 = new System.Windows.Forms.Label();
            this.Tablero_dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tablero_dataGridView)).BeginInit();
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
            this.Tablero_dataGridView.Location = new System.Drawing.Point(17, 72);
            this.Tablero_dataGridView.Name = "Tablero_dataGridView";
            this.Tablero_dataGridView.ReadOnly = true;
            this.Tablero_dataGridView.Size = new System.Drawing.Size(383, 292);
            this.Tablero_dataGridView.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tabla de Puntuaciones";
            // 
            // Tablero_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tablero_dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Tablero_frm";
            this.Text = "Tablero_frm";
            this.Load += new System.EventHandler(this.Tablero_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablero_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Tablero_dataGridView;
        private System.Windows.Forms.Label label2;
    }
}