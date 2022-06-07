namespace Delivery.WinApp1._1_Apresentacao.ModuloFuncionario
{
    partial class TelaCadastroFuncionarios
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
            this.lb_Nome = new System.Windows.Forms.Label();
            this.lb_Cargo = new System.Windows.Forms.Label();
            this.lb_Cpf = new System.Windows.Forms.Label();
            this.lb_Salario = new System.Windows.Forms.Label();
            this.lb_DataNascimento = new System.Windows.Forms.Label();
            this.maskedTextBox_Data = new System.Windows.Forms.MaskedTextBox();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.cbx_Cargo = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown_Salario = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Salario)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Nome.Location = new System.Drawing.Point(107, 30);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(57, 21);
            this.lb_Nome.TabIndex = 0;
            this.lb_Nome.Text = "Nome:";
            // 
            // lb_Cargo
            // 
            this.lb_Cargo.AutoSize = true;
            this.lb_Cargo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Cargo.Location = new System.Drawing.Point(106, 59);
            this.lb_Cargo.Name = "lb_Cargo";
            this.lb_Cargo.Size = new System.Drawing.Size(57, 21);
            this.lb_Cargo.TabIndex = 1;
            this.lb_Cargo.Text = "Cargo:";
            // 
            // lb_Cpf
            // 
            this.lb_Cpf.AutoSize = true;
            this.lb_Cpf.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Cpf.Location = new System.Drawing.Point(120, 86);
            this.lb_Cpf.Name = "lb_Cpf";
            this.lb_Cpf.Size = new System.Drawing.Size(43, 21);
            this.lb_Cpf.TabIndex = 2;
            this.lb_Cpf.Text = "CPF:";
            // 
            // lb_Salario
            // 
            this.lb_Salario.AutoSize = true;
            this.lb_Salario.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Salario.Location = new System.Drawing.Point(100, 115);
            this.lb_Salario.Name = "lb_Salario";
            this.lb_Salario.Size = new System.Drawing.Size(66, 21);
            this.lb_Salario.TabIndex = 3;
            this.lb_Salario.Text = "Salario:";
            // 
            // lb_DataNascimento
            // 
            this.lb_DataNascimento.AutoSize = true;
            this.lb_DataNascimento.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_DataNascimento.Location = new System.Drawing.Point(2, 144);
            this.lb_DataNascimento.Name = "lb_DataNascimento";
            this.lb_DataNascimento.Size = new System.Drawing.Size(164, 21);
            this.lb_DataNascimento.TabIndex = 4;
            this.lb_DataNascimento.Text = "Data de Nascimento:";
            // 
            // maskedTextBox_Data
            // 
            this.maskedTextBox_Data.Location = new System.Drawing.Point(170, 142);
            this.maskedTextBox_Data.Mask = "00/00/0000";
            this.maskedTextBox_Data.Name = "maskedTextBox_Data";
            this.maskedTextBox_Data.Size = new System.Drawing.Size(183, 23);
            this.maskedTextBox_Data.TabIndex = 7;
            this.maskedTextBox_Data.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Gravar.FlatAppearance.BorderSize = 10;
            this.btn_Gravar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Gravar.Location = new System.Drawing.Point(201, 9);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(90, 34);
            this.btn_Gravar.TabIndex = 9;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(294, 9);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(170, 28);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(185, 23);
            this.txt_Nome.TabIndex = 11;
            // 
            // cbx_Cargo
            // 
            this.cbx_Cargo.FormattingEnabled = true;
            this.cbx_Cargo.Location = new System.Drawing.Point(170, 57);
            this.cbx_Cargo.Name = "cbx_Cargo";
            this.cbx_Cargo.Size = new System.Drawing.Size(183, 23);
            this.cbx_Cargo.TabIndex = 12;
            // 
            // maskedTextBox_Cpf
            // 
            this.maskedTextBox_Cpf.Location = new System.Drawing.Point(170, 84);
            this.maskedTextBox_Cpf.Mask = "000.000.000-00";
            this.maskedTextBox_Cpf.Name = "maskedTextBox_Cpf";
            this.maskedTextBox_Cpf.Size = new System.Drawing.Size(183, 23);
            this.maskedTextBox_Cpf.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_Gravar);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Location = new System.Drawing.Point(-2, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 55);
            this.panel1.TabIndex = 16;
            // 
            // numericUpDown_Salario
            // 
            this.numericUpDown_Salario.Location = new System.Drawing.Point(172, 113);
            this.numericUpDown_Salario.Name = "numericUpDown_Salario";
            this.numericUpDown_Salario.Size = new System.Drawing.Size(183, 23);
            this.numericUpDown_Salario.TabIndex = 17;
            // 
            // TelaCadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.numericUpDown_Salario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maskedTextBox_Cpf);
            this.Controls.Add(this.cbx_Cargo);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.maskedTextBox_Data);
            this.Controls.Add(this.lb_DataNascimento);
            this.Controls.Add(this.lb_Salario);
            this.Controls.Add(this.lb_Cpf);
            this.Controls.Add(this.lb_Cargo);
            this.Controls.Add(this.lb_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroFuncionarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionarios";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Salario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.Label lb_Cargo;
        private System.Windows.Forms.Label lb_Cpf;
        private System.Windows.Forms.Label lb_Salario;
        private System.Windows.Forms.Label lb_DataNascimento;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Data;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.ComboBox cbx_Cargo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Cpf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Salario;
    }
}