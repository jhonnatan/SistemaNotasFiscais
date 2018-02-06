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
    public partial class FormConsTratamentoFiscal : Form
    {
        NotaFiscalService service;
        public FormConsTratamentoFiscal(NotaFiscalService service)
        {
            this.service = service;
            InitializeComponent();
            dataGridViewTratamentosFiscais.AutoGenerateColumns = true;
            dataGridViewTratamentosFiscais.DataSource = GetTableNotas();
            ResizeColumns();
        }

        private void ResizeColumns()
        {
            double mediaWidth = dataGridViewTratamentosFiscais.Width / dataGridViewTratamentosFiscais.Columns.GetColumnCount(DataGridViewElementStates.Visible);

            for (int i = dataGridViewTratamentosFiscais.Columns.Count - 1; i >= 0; i--)
            {
                var coluna = dataGridViewTratamentosFiscais.Columns[i];
                coluna.Width = Convert.ToInt32(mediaWidth);
            }
        }

        private object GetTableNotas()
        {
            DataTable table = new DataTable("tratamentos fiscais");
            table.Columns.Add(new DataColumn("Id", typeof(int)));
            table.Columns.Add(new DataColumn("UF Origem", typeof(string)));
            table.Columns.Add(new DataColumn("UF Destino", typeof(string)));
            table.Columns.Add(new DataColumn("Cfop", typeof(string)));
            table.Columns.Add(new DataColumn("Tipo Icms", typeof(string)));
            table.Columns.Add(new DataColumn("Aliquota Icms", typeof(double)));
            table.Columns.Add(new DataColumn("Aliquota Ipi", typeof(double)));
            table.Columns.Add(new DataColumn("Redução Base Icms %", typeof(double)));
            table.Columns.Add(new DataColumn("Brinde", typeof(bool)));
            table.Columns.Add(new DataColumn("Desconto %", typeof(double)));
            table.Columns.Add(new DataColumn("Data Alteração", typeof(DateTime)));
     
            return table;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            int opcaoFiltro = OpcaoFiltro(textBoxUfOrigem.Text, textBoxUfDestino.Text);
            dataGridViewTratamentosFiscais.DataSource = Repository.CarregarTratamentosFiscais(textBoxUfOrigem.Text, textBoxUfDestino.Text, opcaoFiltro);
        }

        private int OpcaoFiltro(string ufOrigem, string ufDestino)
        {
            int retorno = 0;
            if (string.IsNullOrEmpty(ufOrigem) && string.IsNullOrEmpty(ufDestino))
                retorno = 0;
            else if (!string.IsNullOrEmpty(ufOrigem) && !string.IsNullOrEmpty(ufDestino))
                retorno = 1;
            else if (!string.IsNullOrEmpty(ufOrigem) && string.IsNullOrEmpty(ufDestino))
                retorno = 2;
            else if (string.IsNullOrEmpty(ufOrigem) && !string.IsNullOrEmpty(ufDestino))
                retorno = 3;
            return retorno;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {           
            FormTratamentoFiscal formTratamentoFiscal = new FormTratamentoFiscal(new TratamentoFiscal(), service);
            formTratamentoFiscal.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TratamentoFiscal tratFiscal = new TratamentoFiscal();
            tratFiscal.Id = (int)dataGridViewTratamentosFiscais.CurrentRow.Cells[0].Value;
            tratFiscal.EstadoOrigem = dataGridViewTratamentosFiscais.CurrentRow.Cells[1].Value.ToString();
            tratFiscal.EstadoDestino = dataGridViewTratamentosFiscais.CurrentRow.Cells[2].Value.ToString();
            tratFiscal.Cfop = dataGridViewTratamentosFiscais.CurrentRow.Cells[3].Value.ToString();
            tratFiscal.TipoIcms = dataGridViewTratamentosFiscais.CurrentRow.Cells[4].Value.ToString();
            tratFiscal.AliquotaIcms = Convert.ToDouble(dataGridViewTratamentosFiscais.CurrentRow.Cells[5].Value);
            tratFiscal.AliquotaIpi = Convert.ToDouble(dataGridViewTratamentosFiscais.CurrentRow.Cells[6].Value);
            tratFiscal.ReducaoBaseIcms = Convert.ToDouble(dataGridViewTratamentosFiscais.CurrentRow.Cells[7].Value);
            tratFiscal.Brinde = Convert.ToBoolean(dataGridViewTratamentosFiscais.CurrentRow.Cells[8].Value);
            tratFiscal.Desconto = Convert.ToDouble(dataGridViewTratamentosFiscais.CurrentRow.Cells[9].Value);
            tratFiscal.DataAlteracao = Convert.ToDateTime(dataGridViewTratamentosFiscais.CurrentRow.Cells[10].Value);

            FormTratamentoFiscal formTratamentoFiscal = new FormTratamentoFiscal(tratFiscal, service);
            formTratamentoFiscal.Show();
        }
    }
}
