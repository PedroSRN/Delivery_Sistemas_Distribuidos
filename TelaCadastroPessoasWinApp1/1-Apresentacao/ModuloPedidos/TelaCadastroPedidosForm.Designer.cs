﻿namespace Delivery.WinApp1._1_Apresentacao.ModuloPedidos
{
    partial class TelaCadastroPedidosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_clientes = new System.Windows.Forms.ComboBox();
            this.cbx_Produtos = new System.Windows.Forms.ComboBox();
            this.cbx_bebidas = new System.Windows.Forms.ComboBox();
            this.list_Observacao = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_Bebida_Nao = new System.Windows.Forms.CheckBox();
            this.checkBox_Bebida_Sim = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_EnderecoCliente = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bebida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(68, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Observação:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(291, 3);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 37);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Gravar.Location = new System.Drawing.Point(191, 3);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(94, 37);
            this.btn_Gravar.TabIndex = 10;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Gravar);
            this.panel1.Location = new System.Drawing.Point(1, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 55);
            this.panel1.TabIndex = 18;
            // 
            // cbx_clientes
            // 
            this.cbx_clientes.FormattingEnabled = true;
            this.cbx_clientes.Location = new System.Drawing.Point(174, 34);
            this.cbx_clientes.Name = "cbx_clientes";
            this.cbx_clientes.Size = new System.Drawing.Size(187, 23);
            this.cbx_clientes.TabIndex = 19;
            // 
            // cbx_Produtos
            // 
            this.cbx_Produtos.FormattingEnabled = true;
            this.cbx_Produtos.Location = new System.Drawing.Point(173, 146);
            this.cbx_Produtos.Name = "cbx_Produtos";
            this.cbx_Produtos.Size = new System.Drawing.Size(187, 23);
            this.cbx_Produtos.TabIndex = 20;
            // 
            // cbx_bebidas
            // 
            this.cbx_bebidas.FormattingEnabled = true;
            this.cbx_bebidas.Location = new System.Drawing.Point(173, 192);
            this.cbx_bebidas.Name = "cbx_bebidas";
            this.cbx_bebidas.Size = new System.Drawing.Size(187, 23);
            this.cbx_bebidas.TabIndex = 21;
            // 
            // list_Observacao
            // 
            this.list_Observacao.FormattingEnabled = true;
            this.list_Observacao.ItemHeight = 15;
            this.list_Observacao.Location = new System.Drawing.Point(173, 270);
            this.list_Observacao.Name = "list_Observacao";
            this.list_Observacao.Size = new System.Drawing.Size(187, 109);
            this.list_Observacao.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 23);
            this.comboBox1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nome do Funcionario:";
            // 
            // checkBox_Bebida_Nao
            // 
            this.checkBox_Bebida_Nao.AutoSize = true;
            this.checkBox_Bebida_Nao.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Bebida_Nao.Location = new System.Drawing.Point(265, 221);
            this.checkBox_Bebida_Nao.Name = "checkBox_Bebida_Nao";
            this.checkBox_Bebida_Nao.Size = new System.Drawing.Size(57, 25);
            this.checkBox_Bebida_Nao.TabIndex = 31;
            this.checkBox_Bebida_Nao.Text = "Não";
            this.checkBox_Bebida_Nao.UseVisualStyleBackColor = true;
            // 
            // checkBox_Bebida_Sim
            // 
            this.checkBox_Bebida_Sim.AutoSize = true;
            this.checkBox_Bebida_Sim.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Bebida_Sim.Location = new System.Drawing.Point(176, 221);
            this.checkBox_Bebida_Sim.Name = "checkBox_Bebida_Sim";
            this.checkBox_Bebida_Sim.Size = new System.Drawing.Size(55, 25);
            this.checkBox_Bebida_Sim.TabIndex = 30;
            this.checkBox_Bebida_Sim.Text = "Sim";
            this.checkBox_Bebida_Sim.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(36, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Escolher bebida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(7, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Endereço do Cliente:";
            // 
            // cbx_EnderecoCliente
            // 
            this.cbx_EnderecoCliente.FormattingEnabled = true;
            this.cbx_EnderecoCliente.Location = new System.Drawing.Point(174, 70);
            this.cbx_EnderecoCliente.Name = "cbx_EnderecoCliente";
            this.cbx_EnderecoCliente.Size = new System.Drawing.Size(187, 23);
            this.cbx_EnderecoCliente.TabIndex = 33;
            // 
            // TelaCadastroPedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(397, 441);
            this.Controls.Add(this.cbx_EnderecoCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox_Bebida_Nao);
            this.Controls.Add(this.checkBox_Bebida_Sim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.list_Observacao);
            this.Controls.Add(this.cbx_bebidas);
            this.Controls.Add(this.cbx_Produtos);
            this.Controls.Add(this.cbx_clientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroPedidosForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedidos ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_clientes;
        private System.Windows.Forms.ComboBox cbx_Produtos;
        private System.Windows.Forms.ComboBox cbx_bebidas;
        private System.Windows.Forms.ListBox list_Observacao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_Bebida_Nao;
        private System.Windows.Forms.CheckBox checkBox_Bebida_Sim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_EnderecoCliente;
    }
}