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
    public partial class FormTratamentoFiscal : Form
    {
        private TratamentoFiscal tratFiscal;
        private NotaFiscalService servico;
        public FormTratamentoFiscal(TratamentoFiscal tratFiscal, NotaFiscalService servico)
        {
            this.tratFiscal = tratFiscal;
            this.servico = servico;
            InitializeComponent();
            if (tratFiscal.Id > 0)
                CarregarCampos();
        }

        private void CarregarCampos()
        {
            textBoxId.Text = tratFiscal.Id.ToString();
            textBoxUfOrigem.Text = tratFiscal.EstadoOrigem.ToString();
            textBoxUfDestino.Text = tratFiscal.EstadoDestino.ToString();
            textBoxCfop.Text = tratFiscal.Cfop.ToString();
            textBoxTipoIcms.Text = tratFiscal.TipoIcms.ToString();
            textBoxAliqIcms.Text = tratFiscal.AliquotaIcms.ToString();
            textBoxAliqIpi.Text = tratFiscal.AliquotaIpi.ToString();
            textBoxReducaoBaseIcms.Text = tratFiscal.ReducaoBaseIcms.ToString();
            textBoxDesconto.Text = tratFiscal.Desconto.ToString();
            textBoxDataAlteracao.Text = tratFiscal.DataAlteracao.ToString();
            checkBoxBrinde.Checked = tratFiscal.Brinde;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tratFiscal.EstadoOrigem = textBoxUfOrigem.Text;
            tratFiscal.EstadoDestino = textBoxUfDestino.Text;
            tratFiscal.Cfop = textBoxCfop.Text;
            tratFiscal.TipoIcms = textBoxTipoIcms.Text;
            tratFiscal.AliquotaIcms = Convert.ToDouble(textBoxAliqIcms.Text);
            tratFiscal.AliquotaIpi = Convert.ToDouble(textBoxAliqIpi.Text);
            tratFiscal.ReducaoBaseIcms = Convert.ToDouble(textBoxReducaoBaseIcms.Text);
            tratFiscal.Desconto = Convert.ToDouble(textBoxDesconto.Text);

            tratFiscal.Id = Repository.GravarTratamentoFiscal(tratFiscal);
            textBoxId.Text = tratFiscal.Id.ToString();
        }
    }
}
