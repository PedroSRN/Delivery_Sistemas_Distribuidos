namespace Delivery.WinApp1
{
    partial class TelaInicioForm
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
            this.panel_Defundo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Lateral = new System.Windows.Forms.Panel();
            this.panelComplemento = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Produtos = new System.Windows.Forms.Button();
            this.btn_Pedidos = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Funcionarios = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolbox = new System.Windows.Forms.ToolStrip();
            this.btn_Inserir = new System.Windows.Forms.ToolStripButton();
            this.btn_Editar = new System.Windows.Forms.ToolStripButton();
            this.btn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.panel_Defundo.SuspendLayout();
            this.panel_Lateral.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Defundo
            // 
            this.panel_Defundo.Controls.Add(this.panel1);
            this.panel_Defundo.Controls.Add(this.panel_Lateral);
            this.panel_Defundo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Defundo.Location = new System.Drawing.Point(0, 0);
            this.panel_Defundo.Name = "panel_Defundo";
            this.panel_Defundo.Size = new System.Drawing.Size(163, 493);
            this.panel_Defundo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(167, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 100);
            this.panel1.TabIndex = 4;
            // 
            // panel_Lateral
            // 
            this.panel_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Lateral.Controls.Add(this.panelComplemento);
            this.panel_Lateral.Controls.Add(this.label1);
            this.panel_Lateral.Controls.Add(this.btn_Produtos);
            this.panel_Lateral.Controls.Add(this.btn_Pedidos);
            this.panel_Lateral.Controls.Add(this.btn_Clientes);
            this.panel_Lateral.Controls.Add(this.btn_Funcionarios);
            this.panel_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_Lateral.Name = "panel_Lateral";
            this.panel_Lateral.Size = new System.Drawing.Size(164, 493);
            this.panel_Lateral.TabIndex = 3;
            // 
            // panelComplemento
            // 
            this.panelComplemento.Location = new System.Drawing.Point(163, 28);
            this.panelComplemento.Name = "panelComplemento";
            this.panelComplemento.Size = new System.Drawing.Size(200, 34);
            this.panelComplemento.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "PODRÃO \r\n     GOURMET\r\n";
            // 
            // btn_Produtos
            // 
            this.btn_Produtos.BackColor = System.Drawing.Color.DimGray;
            this.btn_Produtos.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Produtos.Image = global::Delivery.WinApp1.Properties.Resources.produtos;
            this.btn_Produtos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Produtos.Location = new System.Drawing.Point(12, 288);
            this.btn_Produtos.Name = "btn_Produtos";
            this.btn_Produtos.Size = new System.Drawing.Size(141, 48);
            this.btn_Produtos.TabIndex = 4;
            this.btn_Produtos.Text = "Produtos";
            this.btn_Produtos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Produtos.UseVisualStyleBackColor = false;
            this.btn_Produtos.Click += new System.EventHandler(this.btn_Produtos_Click);
            // 
            // btn_Pedidos
            // 
            this.btn_Pedidos.BackColor = System.Drawing.Color.DimGray;
            this.btn_Pedidos.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Pedidos.Image = global::Delivery.WinApp1.Properties.Resources.pedido;
            this.btn_Pedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pedidos.Location = new System.Drawing.Point(12, 361);
            this.btn_Pedidos.Name = "btn_Pedidos";
            this.btn_Pedidos.Size = new System.Drawing.Size(141, 48);
            this.btn_Pedidos.TabIndex = 3;
            this.btn_Pedidos.Text = "Pedidos";
            this.btn_Pedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Pedidos.UseVisualStyleBackColor = false;
            this.btn_Pedidos.Click += new System.EventHandler(this.btn_Pedidos_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.DimGray;
            this.btn_Clientes.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Clientes.Image = global::Delivery.WinApp1.Properties.Resources.revisao_do_cliente;
            this.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes.Location = new System.Drawing.Point(12, 210);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(141, 48);
            this.btn_Clientes.TabIndex = 2;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clientes.UseVisualStyleBackColor = false;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_Funcionarios
            // 
            this.btn_Funcionarios.BackColor = System.Drawing.Color.DimGray;
            this.btn_Funcionarios.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Funcionarios.Image = global::Delivery.WinApp1.Properties.Resources.carteira_de_identidade;
            this.btn_Funcionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Funcionarios.Location = new System.Drawing.Point(12, 135);
            this.btn_Funcionarios.Name = "btn_Funcionarios";
            this.btn_Funcionarios.Size = new System.Drawing.Size(141, 48);
            this.btn_Funcionarios.TabIndex = 1;
            this.btn_Funcionarios.Text = "Funcionarios";
            this.btn_Funcionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Funcionarios.UseVisualStyleBackColor = false;
            this.btn_Funcionarios.Click += new System.EventHandler(this.btn_Funcionarios_Click);
            // 
            // tela
            // 
            this.tela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tela.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tela.Location = new System.Drawing.Point(163, 49);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(707, 422);
            this.tela.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStrip1.Location = new System.Drawing.Point(163, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(707, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(52, 17);
            this.labelRodape.Text = "[rodapé]";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.toolbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(163, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 49);
            this.panel2.TabIndex = 11;
            // 
            // toolbox
            // 
            this.toolbox.BackColor = System.Drawing.Color.White;
            this.toolbox.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Inserir,
            this.btn_Editar,
            this.btn_Excluir,
            this.labelTipoCadastro});
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(705, 30);
            this.toolbox.TabIndex = 11;
            this.toolbox.Text = "toolStrip1";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Enabled = false;
            this.btn_Inserir.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Inserir.Image = global::Delivery.WinApp1.Properties.Resources.inserir__1_;
            this.btn_Inserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(68, 27);
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.Image = global::Delivery.WinApp1.Properties.Resources.editar_arquivo__1_;
            this.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(64, 27);
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click_1);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Excluir.Image = global::Delivery.WinApp1.Properties.Resources.excluir__1_;
            this.btn_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(66, 27);
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click_1);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(184, 27);
            this.labelTipoCadastro.Text = "[Tipo de Cadastro]";
            // 
            // TelaInicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 493);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_Defundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaInicioForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.panel_Defundo.ResumeLayout(false);
            this.panel_Lateral.ResumeLayout(false);
            this.panel_Lateral.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Defundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Lateral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Produtos;
        private System.Windows.Forms.Button btn_Pedidos;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Funcionarios;
        private System.Windows.Forms.Panel tela;
        private System.Windows.Forms.Panel panelComplemento;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelRodape;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolbox;
        private System.Windows.Forms.ToolStripButton btn_Inserir;
        private System.Windows.Forms.ToolStripButton btn_Editar;
        private System.Windows.Forms.ToolStripButton btn_Excluir;
        private System.Windows.Forms.ToolStripLabel labelTipoCadastro;
    }
}