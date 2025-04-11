namespace Comercio_02
{
    partial class CadProdutos
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
            this.txtPesquisaCadCli = new System.Windows.Forms.TextBox();
            this.dgCadClientes = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtdatacadproduto = new System.Windows.Forms.MaskedTextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtidCadproduto = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblidprod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaCadCli
            // 
            this.txtPesquisaCadCli.Location = new System.Drawing.Point(9, 161);
            this.txtPesquisaCadCli.Name = "txtPesquisaCadCli";
            this.txtPesquisaCadCli.Size = new System.Drawing.Size(296, 20);
            this.txtPesquisaCadCli.TabIndex = 38;
            // 
            // dgCadClientes
            // 
            this.dgCadClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCadClientes.Location = new System.Drawing.Point(9, 187);
            this.dgCadClientes.Name = "dgCadClientes";
            this.dgCadClientes.Size = new System.Drawing.Size(296, 150);
            this.dgCadClientes.TabIndex = 37;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(235, 352);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpar.TabIndex = 52;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluir.Location = new System.Drawing.Point(165, 352);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(56, 19);
            this.btnExcluir.TabIndex = 51;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(90, 352);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(56, 19);
            this.btnAlterar.TabIndex = 50;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInserir.Location = new System.Drawing.Point(20, 352);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(56, 19);
            this.btnInserir.TabIndex = 49;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // txtdatacadproduto
            // 
            this.txtdatacadproduto.Location = new System.Drawing.Point(63, 106);
            this.txtdatacadproduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdatacadproduto.Mask = "00/00/0000";
            this.txtdatacadproduto.Name = "txtdatacadproduto";
            this.txtdatacadproduto.Size = new System.Drawing.Size(97, 20);
            this.txtdatacadproduto.TabIndex = 48;
            this.txtdatacadproduto.ValidatingType = typeof(System.DateTime);
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(63, 79);
            this.txtmodelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(242, 20);
            this.txtmodelo.TabIndex = 47;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(63, 56);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(242, 20);
            this.txtmarca.TabIndex = 46;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(63, 33);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(242, 20);
            this.txtProduto.TabIndex = 45;
            // 
            // txtidCadproduto
            // 
            this.txtidCadproduto.Location = new System.Drawing.Point(63, 11);
            this.txtidCadproduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtidCadproduto.Name = "txtidCadproduto";
            this.txtidCadproduto.Size = new System.Drawing.Size(76, 20);
            this.txtidCadproduto.TabIndex = 44;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblData.Location = new System.Drawing.Point(6, 106);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 39;
            this.lblData.Text = "Data";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModelo.Location = new System.Drawing.Point(6, 83);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 40;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMarca.Location = new System.Drawing.Point(6, 60);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 41;
            this.lblMarca.Text = "Marca";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProduto.Location = new System.Drawing.Point(6, 37);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 42;
            this.lblProduto.Text = "Produto";
            // 
            // lblidprod
            // 
            this.lblidprod.AutoSize = true;
            this.lblidprod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblidprod.Location = new System.Drawing.Point(6, 15);
            this.lblidprod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidprod.Name = "lblidprod";
            this.lblidprod.Size = new System.Drawing.Size(18, 13);
            this.lblidprod.TabIndex = 43;
            this.lblidprod.Text = "ID";
            // 
            // CadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 379);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtdatacadproduto);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtidCadproduto);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblidprod);
            this.Controls.Add(this.txtPesquisaCadCli);
            this.Controls.Add(this.dgCadClientes);
            this.Name = "CadProdutos";
            this.Text = "CadProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgCadClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesquisaCadCli;
        private System.Windows.Forms.DataGridView dgCadClientes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.MaskedTextBox txtdatacadproduto;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtidCadproduto;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblidprod;
    }
}