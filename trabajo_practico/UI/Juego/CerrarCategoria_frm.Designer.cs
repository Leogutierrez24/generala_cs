
namespace UI.Juego
{
    partial class CerrarCategoria_frm
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
            this.Categorias_listBox = new System.Windows.Forms.ListBox();
            this.DadosObtenidos_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CerrarCategoria_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Categorias_listBox
            // 
            this.Categorias_listBox.FormattingEnabled = true;
            this.Categorias_listBox.Location = new System.Drawing.Point(12, 26);
            this.Categorias_listBox.Name = "Categorias_listBox";
            this.Categorias_listBox.Size = new System.Drawing.Size(153, 147);
            this.Categorias_listBox.TabIndex = 0;
            // 
            // DadosObtenidos_listBox
            // 
            this.DadosObtenidos_listBox.FormattingEnabled = true;
            this.DadosObtenidos_listBox.Location = new System.Drawing.Point(212, 26);
            this.DadosObtenidos_listBox.Name = "DadosObtenidos_listBox";
            this.DadosObtenidos_listBox.Size = new System.Drawing.Size(153, 147);
            this.DadosObtenidos_listBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categorias disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dados obtenidos";
            // 
            // CerrarCategoria_btn
            // 
            this.CerrarCategoria_btn.Location = new System.Drawing.Point(13, 180);
            this.CerrarCategoria_btn.Name = "CerrarCategoria_btn";
            this.CerrarCategoria_btn.Size = new System.Drawing.Size(93, 31);
            this.CerrarCategoria_btn.TabIndex = 4;
            this.CerrarCategoria_btn.Text = "Cerrar Categoria";
            this.CerrarCategoria_btn.UseVisualStyleBackColor = true;
            this.CerrarCategoria_btn.Click += new System.EventHandler(this.CerrarCategoria_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(212, 180);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(93, 31);
            this.Cancelar_btn.TabIndex = 5;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // CerrarCategoria_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 237);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.CerrarCategoria_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DadosObtenidos_listBox);
            this.Controls.Add(this.Categorias_listBox);
            this.Name = "CerrarCategoria_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerrar Categoria";
            this.Load += new System.EventHandler(this.CerrarCategoria_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Categorias_listBox;
        private System.Windows.Forms.ListBox DadosObtenidos_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CerrarCategoria_btn;
        private System.Windows.Forms.Button Cancelar_btn;
    }
}