namespace Comercio_02
{
    partial class CadEstoque
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtDataEnt = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoUnit = new System.Windows.Forms.TextBox();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbldataSaida = new System.Windows.Forms.Label();
            this.lbldataEntr = new System.Windows.Forms.Label();
            this.lblprecoUnit = new System.Windows.Forms.Label();
            this.lblidprod = new System.Windows.Forms.Label();
            this.lblidestoque = new System.Windows.Forms.Label();
            this.txtPesquisaEstoque = new System.Windows.Forms.TextBox();
            this.dgCadEstoque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(274, 325);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(199, 325);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(56, 19);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(116, 325);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(56, 19);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(40, 325);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(56, 19);
            this.btnInserir.TabIndex = 18;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Location = new System.Drawing.Point(101, 114);
            this.txtDataSaida.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataSaida.Mask = "00/00/0000";
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(104, 20);
            this.txtDataSaida.TabIndex = 13;
            this.txtDataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataEnt
            // 
            this.txtDataEnt.Location = new System.Drawing.Point(101, 88);
            this.txtDataEnt.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataEnt.Mask = "00/00/0000";
            this.txtDataEnt.Name = "txtDataEnt";
            this.txtDataEnt.Size = new System.Drawing.Size(104, 20);
            this.txtDataEnt.TabIndex = 14;
            this.txtDataEnt.ValidatingType = typeof(System.DateTime);
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.Location = new System.Drawing.Point(101, 59);
            this.txtPrecoUnit.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.Size = new System.Drawing.Size(252, 20);
            this.txtPrecoUnit.TabIndex = 10;
            // 
            // txtIDProd
            // 
            this.txtIDProd.Location = new System.Drawing.Point(101, 33);
            this.txtIDProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(252, 20);
            this.txtIDProd.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(101, 11);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 20);
            this.txtID.TabIndex = 12;
            // 
            // lbldataSaida
            // 
            this.lbldataSaida.AutoSize = true;
            this.lbldataSaida.Location = new System.Drawing.Point(11, 116);
            this.lbldataSaida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldataSaida.Name = "lbldataSaida";
            this.lbldataSaida.Size = new System.Drawing.Size(62, 13);
            this.lbldataSaida.TabIndex = 5;
            this.lbldataSaida.Text = "Data Saída";
            // 
            // lbldataEntr
            // 
            this.lbldataEntr.AutoSize = true;
            this.lbldataEntr.Location = new System.Drawing.Point(11, 88);
            this.lbldataEntr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldataEntr.Name = "lbldataEntr";
            this.lbldataEntr.Size = new System.Drawing.Size(67, 13);
            this.lbldataEntr.TabIndex = 6;
            this.lbldataEntr.Text = "DataEntrada";
            // 
            // lblprecoUnit
            // 
            this.lblprecoUnit.AutoSize = true;
            this.lblprecoUnit.Location = new System.Drawing.Point(11, 62);
            this.lblprecoUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblprecoUnit.Name = "lblprecoUnit";
            this.lblprecoUnit.Size = new System.Drawing.Size(74, 13);
            this.lblprecoUnit.TabIndex = 7;
            this.lblprecoUnit.Text = "Preço Unitário";
            // 
            // lblidprod
            // 
            this.lblidprod.AutoSize = true;
            this.lblidprod.Location = new System.Drawing.Point(11, 36);
            this.lblidprod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidprod.Name = "lblidprod";
            this.lblidprod.Size = new System.Drawing.Size(58, 13);
            this.lblidprod.TabIndex = 8;
            this.lblidprod.Text = "ID Produto";
            // 
            // lblidestoque
            // 
            this.lblidestoque.AutoSize = true;
            this.lblidestoque.Location = new System.Drawing.Point(11, 13);
            this.lblidestoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidestoque.Name = "lblidestoque";
            this.lblidestoque.Size = new System.Drawing.Size(18, 13);
            this.lblidestoque.TabIndex = 9;
            this.lblidestoque.Text = "ID";
            // 
            // txtPesquisaEstoque
            // 
            this.txtPesquisaEstoque.Location = new System.Drawing.Point(12, 144);
            this.txtPesquisaEstoque.Name = "txtPesquisaEstoque";
            this.txtPesquisaEstoque.Size = new System.Drawing.Size(341, 20);
            this.txtPesquisaEstoque.TabIndex = 22;
            // 
            // dgCadEstoque
            // 
            this.dgCadEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCadEstoque.Location = new System.Drawing.Point(12, 170);
            this.dgCadEstoque.Name = "dgCadEstoque";
            this.dgCadEstoque.Size = new System.Drawing.Size(341, 150);
            this.dgCadEstoque.TabIndex = 21;
            // 
            // CadEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 361);
            this.Controls.Add(this.txtPesquisaEstoque);
            this.Controls.Add(this.dgCadEstoque);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtDataSaida);
            this.Controls.Add(this.txtDataEnt);
            this.Controls.Add(this.txtPrecoUnit);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbldataSaida);
            this.Controls.Add(this.lbldataEntr);
            this.Controls.Add(this.lblprecoUnit);
            this.Controls.Add(this.lblidprod);
            this.Controls.Add(this.lblidestoque);
            this.Name = "CadEstoque";
            this.Text = "CadEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgCadEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.MaskedTextBox txtDataSaida;
        private System.Windows.Forms.MaskedTextBox txtDataEnt;
        private System.Windows.Forms.TextBox txtPrecoUnit;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbldataSaida;
        private System.Windows.Forms.Label lbldataEntr;
        private System.Windows.Forms.Label lblprecoUnit;
        private System.Windows.Forms.Label lblidprod;
        private System.Windows.Forms.Label lblidestoque;
        private System.Windows.Forms.TextBox txtPesquisaEstoque;
        private System.Windows.Forms.DataGridView dgCadEstoque;
    }
}