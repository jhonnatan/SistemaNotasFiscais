using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imposto.Core.Domain;
using Imposto.Core.Service;

namespace TesteImposto
{
    public partial class FormPrincipal : Form
    {
        private NotaFiscalService service = new NotaFiscalService();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void notaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void emitirNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotaFiscal formNotaFiscal = new FormNotaFiscal(new NotaFiscal(), service);
            formNotaFiscal.Show();
        }

        private void consultaNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsNotaFiscal formConsNotaFiscal = new FormConsNotaFiscal(service);
            formConsNotaFiscal.Show();
        }

        private void tratamentosFiscaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsTratamentoFiscal formTratamentoFiscal = new FormConsTratamentoFiscal(service);
            formTratamentoFiscal.Show();
        }
    }
}
