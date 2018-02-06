namespace TesteImposto
{
    partial class FormConsTratamentoFiscal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxUfOrigem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUfDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dataGridViewTratamentosFiscais = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamentosFiscais)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxUfOrigem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxUfDestino);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 55);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Tratamento Fiscal:";
            // 
            // textBoxUfOrigem
            // 
            this.textBoxUfOrigem.Location = new System.Drawing.Point(85, 22);
            this.textBoxUfOrigem.Name = "textBoxUfOrigem";
            this.textBoxUfOrigem.Size = new System.Drawing.Size(93, 20);
            this.textBoxUfOrigem.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "UF Origem";
            // 
            // textBoxUfDestino
            // 
            this.textBoxUfDestino.Location = new System.Drawing.Point(259, 22);
            this.textBoxUfDestino.Name = "textBoxUfDestino";
            this.textBoxUfDestino.Size = new System.Drawing.Size(93, 20);
            this.textBoxUfDestino.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "UF Destino";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(726, 405);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(23, 405);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(87, 23);
            this.btnNovo.TabIndex = 27;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(23, 84);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Pesquisar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dataGridViewTratamentosFiscais
            // 
            this.dataGridViewTratamentosFiscais.AllowUserToAddRows = false;
            this.dataGridViewTratamentosFiscais.AllowUserToDeleteRows = false;
            this.dataGridViewTratamentosFiscais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTratamentosFiscais.Location = new System.Drawing.Point(23, 114);
            this.dataGridViewTratamentosFiscais.Name = "dataGridViewTratamentosFiscais";
            this.dataGridViewTratamentosFiscais.ReadOnly = true;
            this.dataGridViewTratamentosFiscais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTratamentosFiscais.Size = new System.Drawing.Size(778, 285);
            this.dataGridViewTratamentosFiscais.TabIndex = 23;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(126, 405);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 23);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FormConsTratamentoFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.dataGridViewTratamentosFiscais);
            this.Name = "FormConsTratamentoFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Tratamentos Fiscais";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamentosFiscais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxUfOrigem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUfDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.DataGridView dataGridViewTratamentosFiscais;
        private System.Windows.Forms.Button btnEditar;
    }
}