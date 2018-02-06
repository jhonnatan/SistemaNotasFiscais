using Imposto.Core.Data;
using Imposto.Core.Domain;
using Imposto.Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteImposto
{
    public partial class FormConsNotaFiscal : Form
    {
        NotaFiscalService service;
        public FormConsNotaFiscal(NotaFiscalService service)
        {
            this.service = service;
            InitializeComponent();            
            dataGridViewNotasFiscais.AutoGenerateColumns = true;
            dataGridViewNotasFiscais.DataSource = GetTableNotas();
            ResizeColumns();
        }
   
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            int nf = 0;
            nf = int.TryParse(textBoxNumeroNota.Text, out nf)? Convert.ToInt32(textBoxNumeroNota.Text) : 0;
            string cliente = textBoxCliente.Text;
            int opcaoFiltro = OpcaoFiltro(nf, cliente);        
            dataGridViewNotasFiscais.DataSource = Repository.ObterNotaFiscal(nf, cliente, opcaoFiltro);                        
        }

        private int OpcaoFiltro(int numeroNotaFiscal, string cliente)
        {
            int retorno = 0;
            if (numeroNotaFiscal == 0 && string.IsNullOrEmpty(cliente))
                retorno = 0;
            else if (numeroNotaFiscal > 0 && !string.IsNullOrEmpty(cliente))
                retorno = 1;
            else if (numeroNotaFiscal > 0 && string.IsNullOrEmpty(cliente))
                retorno = 2;
            else if (numeroNotaFiscal == 0 && !string.IsNullOrEmpty(cliente))
                retorno = 3;
            return retorno;
        }

        private object GetTableNotas()
        {
            DataTable table = new DataTable("notas");
            table.Columns.Add(new DataColumn("Id", typeof(int)));
            table.Columns.Add(new DataColumn("Nota Fiscal", typeof(int)));
            table.Columns.Add(new DataColumn("Serie", typeof(int)));
            table.Columns.Add(new DataColumn("Cliente", typeof(string)));
            table.Columns.Add(new DataColumn("UF Origem", typeof(string)));
            table.Columns.Add(new DataColumn("UF Destino", typeof(string)));

            return table;
        }

        private void ResizeColumns()
        {
            double mediaWidth = dataGridViewNotasFiscais.Width / dataGridViewNotasFiscais.Columns.GetColumnCount(DataGridViewElementStates.Visible);

            for (int i = dataGridViewNotasFiscais.Columns.Count - 1; i >= 0; i--)
            {
                var coluna = dataGridViewNotasFiscais.Columns[i];
                coluna.Width = Convert.ToInt32(mediaWidth);
            }
        }

        private void btnEmitirNotaFiscal_Click(object sender, EventArgs e)
        {                       
            FormNotaFiscal formNotaFiscal = new FormNotaFiscal(new NotaFiscal(), service);
            formNotaFiscal.Show();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.Id = (int)dataGridViewNotasFiscais.CurrentRow.Cells[0].Value;
            notaFiscal.NumeroNotaFiscal = (int)dataGridViewNotasFiscais.CurrentRow.Cells[1].Value;
            notaFiscal.Serie = (int)dataGridViewNotasFiscais.CurrentRow.Cells[2].Value;
            notaFiscal.NomeCliente = dataGridViewNotasFiscais.CurrentRow.Cells[3].Value.ToString();
            notaFiscal.EstadoOrigem = dataGridViewNotasFiscais.CurrentRow.Cells[4].Value.ToString();
            notaFiscal.EstadoDestino = dataGridViewNotasFiscais.CurrentRow.Cells[5].Value.ToString();

            FormNotaFiscal formNotaFiscal = new FormNotaFiscal(notaFiscal, service);
            formNotaFiscal.Show();
        }
    }
}
