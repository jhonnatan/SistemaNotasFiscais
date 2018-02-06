namespace TesteImposto
{
    partial class FormConsNotaFiscal
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
            this.dataGridViewNotasFiscais = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNumeroNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnEmitirNotaFiscal = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotasFiscais)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNotasFiscais
            // 
            this.dataGridViewNotasFiscais.AllowUserToAddRows = false;
            this.dataGridViewNotasFiscais.AllowUserToDeleteRows = false;
            this.dataGridViewNotasFiscais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotasFiscais.Location = new System.Drawing.Point(25, 123);
            this.dataGridViewNotasFiscais.Name = "dataGridViewNotasFiscais";
            this.dataGridViewNotasFiscais.ReadOnly = true;
            this.dataGridViewNotasFiscais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNotasFiscais.Size = new System.Drawing.Size(1028, 285);
            this.dataGridViewNotasFiscais.TabIndex = 15;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(25, 94);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 18;
            this.btnConsulta.Text = "Pesquisar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNumeroNota);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 76);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Nota Fiscal:";
            // 
            // textBoxNumeroNota
            // 
            this.textBoxNumeroNota.Location = new System.Drawing.Point(114, 24);
            this.textBoxNumeroNota.Name = "textBoxNumeroNota";
            this.textBoxNumeroNota.Size = new System.Drawing.Size(93, 20);
            this.textBoxNumeroNota.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nº Nota Fiscal";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(114, 46);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(354, 20);
            this.textBoxCliente.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome do Cliente";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(25, 414);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 20;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnEmitirNotaFiscal
            // 
            this.btnEmitirNotaFiscal.Location = new System.Drawing.Point(116, 414);
            this.btnEmitirNotaFiscal.Name = "btnEmitirNotaFiscal";
            this.btnEmitirNotaFiscal.Size = new System.Drawing.Size(148, 23);
            this.btnEmitirNotaFiscal.TabIndex = 21;
            this.btnEmitirNotaFiscal.Text = "Emitir Nova Nota Fiscal";
            this.btnEmitirNotaFiscal.UseVisualStyleBackColor = true;
            this.btnEmitirNotaFiscal.Click += new System.EventHandler(this.btnEmitirNotaFiscal_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(978, 414);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormConsNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 446);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEmitirNotaFiscal);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.dataGridViewNotasFiscais);
            this.Name = "FormConsNotaFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Notas Fiscais";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotasFiscais)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNotasFiscais;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNumeroNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnEmitirNotaFiscal;
        private System.Windows.Forms.Button btnSair;
    }
}