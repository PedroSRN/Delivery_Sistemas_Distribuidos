namespace TelaCadastroPessoasWinApp1
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip_Rodape = new System.Windows.Forms.StatusStrip();
            this.label_Rodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Inicio = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Inserir = new System.Windows.Forms.ToolStripButton();
            this.btn_Editar = new System.Windows.Forms.ToolStripButton();
            this.btn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip_Rodape.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_Rodape
            // 
            this.statusStrip_Rodape.BackColor = System.Drawing.Color.Gray;
            this.statusStrip_Rodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_Rodape});
            this.statusStrip_Rodape.Location = new System.Drawing.Point(0, 428);
            this.statusStrip_Rodape.Name = "statusStrip_Rodape";
            this.statusStrip_Rodape.Size = new System.Drawing.Size(688, 22);
            this.statusStrip_Rodape.TabIndex = 0;
            this.statusStrip_Rodape.Text = "StatusStrip";
            // 
            // label_Rodape
            // 
            this.label_Rodape.BackColor = System.Drawing.Color.White;
            this.label_Rodape.Name = "label_Rodape";
            this.label_Rodape.Size = new System.Drawing.Size(47, 17);
            this.label_Rodape.Text = "Rodapé";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosMenuItem,
            this.clientesMenuItem,
            this.produtosMenuItem,
            this.pedidosMenuItem});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.testeToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionariosMenuItem
            // 
            this.funcionariosMenuItem.Name = "funcionariosMenuItem";
            this.funcionariosMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionariosMenuItem.Text = "Funcionarios";
            // 
            // clientesMenuItem
            // 
            this.clientesMenuItem.Name = "clientesMenuItem";
            this.clientesMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clientesMenuItem.Text = "Clientes";
            // 
            // produtosMenuItem
            // 
            this.produtosMenuItem.Name = "produtosMenuItem";
            this.produtosMenuItem.Size = new System.Drawing.Size(142, 22);
            this.produtosMenuItem.Text = "Produtos";
            // 
            // pedidosMenuItem
            // 
            this.pedidosMenuItem.Name = "pedidosMenuItem";
            this.pedidosMenuItem.Size = new System.Drawing.Size(142, 22);
            this.pedidosMenuItem.Text = "Pedidos";
            // 
            // panel_Inicio
            // 
            this.panel_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_Inicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Inicio.Location = new System.Drawing.Point(0, 24);
            this.panel_Inicio.Name = "panel_Inicio";
            this.panel_Inicio.Size = new System.Drawing.Size(688, 404);
            this.panel_Inicio.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Inserir,
            this.btn_Editar,
            this.btn_Excluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(688, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Image = global::Delivery.WinApp1.Properties.Resources.inserir__1_;
            this.btn_Inserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(59, 22);
            this.btn_Inserir.Text = "Inserir";
            // 
            // btn_Editar
            // 
            this.btn_Editar.Image = global::Delivery.WinApp1.Properties.Resources.editar_arquivo__1_;
            this.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(57, 22);
            this.btn_Editar.Text = "Editar";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Image = global::Delivery.WinApp1.Properties.Resources.excluir__1_;
            this.btn_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(62, 22);
            this.btn_Excluir.Text = "Excluir";
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel_Inicio);
            this.Controls.Add(this.statusStrip_Rodape);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery ";
            this.statusStrip_Rodape.ResumeLayout(false);
            this.statusStrip_Rodape.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_Rodape;
        private System.Windows.Forms.ToolStripStatusLabel label_Rodape;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosMenuItem;
        private System.Windows.Forms.Panel panel_Inicio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Inserir;
        private System.Windows.Forms.ToolStripButton btn_Editar;
        private System.Windows.Forms.ToolStripButton btn_Excluir;
    }
}
