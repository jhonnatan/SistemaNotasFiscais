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
using Imposto.Core.Domain;
using Imposto.Core.Data;

namespace TesteImposto
{
    public partial class FormNotaFiscal: Form
    {
        private NotaFiscal notaFiscal; 
        private Pedido pedido = new Pedido();
        private NotaFiscalService service;
        
        public FormNotaFiscal(NotaFiscal notaFiscal, NotaFiscalService service)
        {
            this.notaFiscal = notaFiscal;
            this.service = service;       
            InitializeComponent();
            dataGridViewPedidos.AutoGenerateColumns = true;
            dataGridViewPedidos.DataSource = GetTablePedidos();
            ResizeColumns();
            CarregarDadosNotaFiscal(notaFiscal);
            ControleBotoes(this.notaFiscal.Id == 0);
        }

        private void ResizeColumns()
        {
            double mediaWidth = dataGridViewPedidos.Width / dataGridViewPedidos.Columns.GetColumnCount(DataGridViewElementStates.Visible);

            for (int i = dataGridViewPedidos.Columns.Count - 1; i >= 0; i--)
            {
                var coluna = dataGridViewPedidos.Columns[i];
                coluna.Width = Convert.ToInt32(mediaWidth);
            }   
        }

        private object GetTablePedidos()
        {
            DataTable table = new DataTable("pedidos");
            table.Columns.Add(new DataColumn("Nome do produto", typeof(string)));
            table.Columns.Add(new DataColumn("Codigo do produto", typeof(string)));
            table.Columns.Add(new DataColumn("Valor", typeof(decimal)));
            table.Columns.Add(new DataColumn("Brinde", typeof(bool)));           
                     
            return table;
        }

        private void buttonGerarNotaFiscal_Click(object sender, EventArgs e)
        {            
            if (!Validacao())                            
                return;
                        
            pedido.EstadoOrigem = txtEstadoOrigem.Text;
            pedido.EstadoDestino = txtEstadoDestino.Text;
            pedido.NomeCliente = textBoxNomeCliente.Text;

            DataTable table = (DataTable)dataGridViewPedidos.DataSource;

            foreach (DataRow row in table.Rows)
            {
                var boolValue = false;
                pedido.ItensDoPedido.Add(
                    new PedidoItem()
                    {                        
                        Brinde = bool.TryParse(row["Brinde"].ToString(), out boolValue),
                        CodigoProduto =  row["Codigo do produto"].ToString(),
                        NomeProduto = row["Nome do produto"].ToString(),
                        ValorItemPedido = Convert.ToDouble(row["Valor"].ToString())            
                    });
            }

            string retorno = service.GerarNotaFiscal(pedido);
            if (string.IsNullOrEmpty(retorno))
            {
                MessageBox.Show("Operação efetuada com sucesso");
                LimparTela();
            }
            else
                MessageBox.Show(retorno, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimparTela()
        {
            txtEstadoOrigem.Text = string.Empty;
            txtEstadoDestino.Text = string.Empty;
            textBoxNomeCliente.Text = string.Empty;
            DataTable table = (DataTable)dataGridViewPedidos.DataSource;
            table.Clear();
        }               

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {            
            LimparTela();
        }

        private bool Validacao()
        {
            if (!Util.ValidaCliente(textBoxNomeCliente.Text))
            {
                MessageBox.Show("É necessário informar um Cliente válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Util.ValidaUF(txtEstadoOrigem.Text) || !Util.ValidaUF(txtEstadoDestino.Text))
            {
                MessageBox.Show("É necessário informar UFs válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CarregarDadosNotaFiscal(NotaFiscal notaFiscal)
        {
            if (notaFiscal.NumeroNotaFiscal > 0)
            {
                textBoxNomeCliente.Text = notaFiscal.NomeCliente;
                txtEstadoOrigem.Text = notaFiscal.EstadoOrigem;
                txtEstadoDestino.Text = notaFiscal.EstadoDestino;
                dataGridViewPedidos.DataSource = Repository.ObterNotaFiscalItens(notaFiscal.NumeroNotaFiscal); 
            }
        }

        private void ControleBotoes(bool habilita)
        {
            textBoxNomeCliente.Enabled = habilita;
            txtEstadoOrigem.Enabled = habilita;
            txtEstadoDestino.Enabled = habilita;
            dataGridViewPedidos.ReadOnly = habilita;
            buttonGerarNotaFiscal.Visible = habilita;
            buttonCancelar.Visible = habilita;
        }
    }
}
