namespace Comercio_02
{
    partial class CadClientes
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
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtsobrenome = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.lblDataCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.lblSobrenomeCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.dgCadClientes = new System.Windows.Forms.DataGridView();
            this.txtPesquisaCadCli = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(85, 126);
            this.txtdata.Mask = "00/00/0000";
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(122, 20);
            this.txtdata.TabIndex = 18;
            this.txtdata.ValidatingType = typeof(System.DateTime);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(85, 101);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(225, 20);
            this.txtemail.TabIndex = 17;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(85, 78);
            this.txttelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(225, 20);
            this.txttelefone.TabIndex = 16;
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.Location = new System.Drawing.Point(85, 55);
            this.txtsobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(225, 20);
            this.txtsobrenome.TabIndex = 15;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(85, 33);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(225, 20);
            this.txtcliente.TabIndex = 14;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(85, 8);
            this.txtidcliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(76, 20);
            this.txtidcliente.TabIndex = 13;
            // 
            // lblDataCliente
            // 
            this.lblDataCliente.AutoSize = true;
            this.lblDataCliente.Location = new System.Drawing.Point(12, 126);
            this.lblDataCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataCliente.Name = "lblDataCliente";
            this.lblDataCliente.Size = new System.Drawing.Size(30, 13);
            this.lblDataCliente.TabIndex = 7;
            this.lblDataCliente.Text = "Data";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(12, 103);
            this.lblEmailCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(32, 13);
            this.lblEmailCliente.TabIndex = 8;
            this.lblEmailCliente.Text = "Email";
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Location = new System.Drawing.Point(11, 82);
            this.lblTelefoneCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneCliente.TabIndex = 9;
            this.lblTelefoneCliente.Text = "Telefone";
            // 
            // lblSobrenomeCliente
            // 
            this.lblSobrenomeCliente.AutoSize = true;
            this.lblSobrenomeCliente.Location = new System.Drawing.Point(11, 58);
            this.lblSobrenomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSobrenomeCliente.Name = "lblSobrenomeCliente";
            this.lblSobrenomeCliente.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenomeCliente.TabIndex = 10;
            this.lblSobrenomeCliente.Text = "Sobrenome";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(11, 33);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(39, 13);
            this.lblNomeCliente.TabIndex = 11;
            this.lblNomeCliente.Text = "Cliente";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(12, 8);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 12;
            this.lblid.Text = "ID";
            // 
            // dgCadClientes
            // 
            this.dgCadClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCadClientes.Location = new System.Drawing.Point(14, 180);
            this.dgCadClientes.Name = "dgCadClientes";
            this.dgCadClientes.Size = new System.Drawing.Size(296, 150);
            this.dgCadClientes.TabIndex = 19;
            this.dgCadClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCadClientes_CellContentClick);
            // 
            // txtPesquisaCadCli
            // 
            this.txtPesquisaCadCli.Location = new System.Drawing.Point(14, 154);
            this.txtPesquisaCadCli.Name = "txtPesquisaCadCli";
            this.txtPesquisaCadCli.Size = new System.Drawing.Size(296, 20);
            this.txtPesquisaCadCli.TabIndex = 20;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(235, 335);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(167, 335);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(56, 19);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(97, 335);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(56, 19);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(29, 335);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(56, 19);
            this.btnInserir.TabIndex = 24;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // CadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 358);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtPesquisaCadCli);
            this.Controls.Add(this.dgCadClientes);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtsobrenome);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.lblDataCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.lblSobrenomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblid);
            this.Name = "CadClientes";
            this.Text = "CadClientes";
            this.Load += new System.EventHandler(this.CadClientes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgCadClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtdata;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtsobrenome;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Label lblDataCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.Label lblSobrenomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridView dgCadClientes;
        private System.Windows.Forms.TextBox txtPesquisaCadCli;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
    }
}