namespace TesteImposto
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tratamentosFiscaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaFiscalToolStripMenuItem,
            this.tratamentosFiscaisToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // notaFiscalToolStripMenuItem
            // 
            this.notaFiscalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirNotaFiscalToolStripMenuItem,
            this.consultaNotaFiscalToolStripMenuItem});
            this.notaFiscalToolStripMenuItem.Name = "notaFiscalToolStripMenuItem";
            this.notaFiscalToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.notaFiscalToolStripMenuItem.Text = "Notas Fiscais";
            this.notaFiscalToolStripMenuItem.Click += new System.EventHandler(this.notaFiscalToolStripMenuItem_Click);
            // 
            // emitirNotaFiscalToolStripMenuItem
            // 
            this.emitirNotaFiscalToolStripMenuItem.Name = "emitirNotaFiscalToolStripMenuItem";
            this.emitirNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.emitirNotaFiscalToolStripMenuItem.Text = "Emitir Nota Fiscal";
            this.emitirNotaFiscalToolStripMenuItem.Click += new System.EventHandler(this.emitirNotaFiscalToolStripMenuItem_Click);
            // 
            // consultaNotaFiscalToolStripMenuItem
            // 
            this.consultaNotaFiscalToolStripMenuItem.Name = "consultaNotaFiscalToolStripMenuItem";
            this.consultaNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consultaNotaFiscalToolStripMenuItem.Text = "Consultar Nota Fiscal";
            this.consultaNotaFiscalToolStripMenuItem.Click += new System.EventHandler(this.consultaNotaFiscalToolStripMenuItem_Click);
            // 
            // tratamentosFiscaisToolStripMenuItem
            // 
            this.tratamentosFiscaisToolStripMenuItem.Name = "tratamentosFiscaisToolStripMenuItem";
            this.tratamentosFiscaisToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.tratamentosFiscaisToolStripMenuItem.Text = "Tratamentos Fiscais";
            this.tratamentosFiscaisToolStripMenuItem.Click += new System.EventHandler(this.tratamentosFiscaisToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Emissor de Notas Fiscais";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem notaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tratamentosFiscaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}