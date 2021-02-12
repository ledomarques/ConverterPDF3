using System;
using System.IO;
using System.Windows.Forms;

namespace ConverterPDF3
{
    public partial class ConverterPDF : Form
    {
        public ConverterPDF()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            this.ofd1.Multiselect = false;
            this.ofd1.Title = "Selecionar PDF";
            ofd1.InitialDirectory = "C:\\";
            ofd1.Filter = "Files (*.PDF)|*.PDF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = false;

            DialogResult dr = ofd1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtCaminhoArquivoPDF.Text = ofd1.FileName;
            }
        }

        private void btnConverte_Click(object sender, EventArgs e)
        {
            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();

            string pdfFile = txtCaminhoArquivoPDF.Text;
            string wordFile = Path.ChangeExtension(pdfFile, ".docx");

            f.OpenPdf(pdfFile);

            if (f.PageCount > 0)
            {
                int result = f.ToWord(wordFile);

                if (result == 0)
                {
                    System.Diagnostics.Process.Start(wordFile);
                }
            }
        }
    }
}
