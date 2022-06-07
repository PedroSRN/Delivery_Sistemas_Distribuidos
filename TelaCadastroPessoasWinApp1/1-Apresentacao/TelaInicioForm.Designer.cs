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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Central = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Inserir = new System.Windows.Forms.ToolStripButton();
            this.btn_Editar = new System.Windows.Forms.ToolStripButton();
            this.btn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_Defundo.SuspendLayout();
            this.panel_Lateral.SuspendLayout();
            this.panel_Central.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.panel_Lateral.Controls.Add(this.label1);
            this.panel_Lateral.Controls.Add(this.button3);
            this.panel_Lateral.Controls.Add(this.button4);
            this.panel_Lateral.Controls.Add(this.button2);
            this.panel_Lateral.Controls.Add(this.button1);
            this.panel_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_Lateral.Name = "panel_Lateral";
            this.panel_Lateral.Size = new System.Drawing.Size(163, 493);
            this.panel_Lateral.TabIndex = 3;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::Delivery.WinApp1.Properties.Resources.produtos;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "Produtos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = global::Delivery.WinApp1.Properties.Resources.pedido;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Pedidos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::Delivery.WinApp1.Properties.Resources.revisao_do_cliente;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clientes";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::Delivery.WinApp1.Properties.Resources.carteira_de_identidade;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Funcionarios";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel_Central
            // 
            this.panel_Central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Central.Controls.Add(this.toolStrip1);
            this.panel_Central.Controls.Add(this.statusStrip1);
            this.panel_Central.Location = new System.Drawing.Point(163, 0);
            this.panel_Central.Name = "panel_Central";
            this.panel_Central.Size = new System.Drawing.Size(707, 493);
            this.panel_Central.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Inserir,
            this.btn_Editar,
            this.btn_Excluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 25);
            this.toolStrip1.TabIndex = 4;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(707, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(52, 17);
            this.labelRodape.Text = "[rodapé]";
            // 
            // TelaInicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(870, 493);
            this.Controls.Add(this.panel_Central);
            this.Controls.Add(this.panel_Defundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaInicioForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.panel_Defundo.ResumeLayout(false);
            this.panel_Lateral.ResumeLayout(false);
            this.panel_Lateral.PerformLayout();
            this.panel_Central.ResumeLayout(false);
            this.panel_Central.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Defundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Lateral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_Central;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelRodape;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Inserir;
        private System.Windows.Forms.ToolStripButton btn_Editar;
        private System.Windows.Forms.ToolStripButton btn_Excluir;
    }
}