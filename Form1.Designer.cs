
namespace ConverterPDF3
{
    partial class ConverterPDF
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminhoArquivoPDF = new System.Windows.Forms.TextBox();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConverte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(315, 77);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione um arquivo PDF para converter:";
            // 
            // txtCaminhoArquivoPDF
            // 
            this.txtCaminhoArquivoPDF.Location = new System.Drawing.Point(15, 78);
            this.txtCaminhoArquivoPDF.Name = "txtCaminhoArquivoPDF";
            this.txtCaminhoArquivoPDF.Size = new System.Drawing.Size(294, 20);
            this.txtCaminhoArquivoPDF.TabIndex = 2;
            // 
            // ofd1
            // 
            this.ofd1.FilterIndex = 2;
            this.ofd1.ReadOnlyChecked = true;
            this.ofd1.RestoreDirectory = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Converta arquivos PDF para .DOCX!";
            // 
            // btnConverte
            // 
            this.btnConverte.BackColor = System.Drawing.Color.LightCoral;
            this.btnConverte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverte.Location = new System.Drawing.Point(15, 105);
            this.btnConverte.Name = "btnConverte";
            this.btnConverte.Size = new System.Drawing.Size(294, 33);
            this.btnConverte.TabIndex = 4;
            this.btnConverte.Text = "Converter";
            this.btnConverte.UseVisualStyleBackColor = false;
            this.btnConverte.Click += new System.EventHandler(this.btnConverte_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "O arquivo será salvo no mesmo Diretório do arquivo original e abrirá automaticame" +
    "nte.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ConverterPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConverte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaminhoArquivoPDF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcurar);
            this.Name = "ConverterPDF";
            this.Text = "ConverterPDF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminhoArquivoPDF;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConverte;
        private System.Windows.Forms.Label label3;
    }
}

