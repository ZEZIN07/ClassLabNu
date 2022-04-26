namespace ComercialSys91
{
    partial class FrmPedidos
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgItens = new System.Windows.Forms.DataGridView();
            this.clnSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInserirItem = new System.Windows.Forms.Button();
            this.txtQtdProd = new System.Windows.Forms.TextBox();
            this.txtValorUnitProd = new System.Windows.Forms.TextBox();
            this.txtDescricaoProd = new System.Windows.Forms.TextBox();
            this.cmbCodProd = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataPed = new System.Windows.Forms.TextBox();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFechar);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(579, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 231);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operações";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(7, 178);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(115, 30);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar Pedido";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(449, 405);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(124, 26);
            this.txtValorTotal.TabIndex = 7;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor Total R$";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtgItens);
            this.groupBox2.Controls.Add(this.btnInserirItem);
            this.groupBox2.Controls.Add(this.txtQtdProd);
            this.groupBox2.Controls.Add(this.txtValorUnitProd);
            this.groupBox2.Controls.Add(this.txtDescricaoProd);
            this.groupBox2.Controls.Add(this.cmbCodProd);
            this.groupBox2.Location = new System.Drawing.Point(24, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 270);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens de Pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Unitário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cod. Produto";
            // 
            // dtgItens
            // 
            this.dtgItens.AllowUserToAddRows = false;
            this.dtgItens.AllowUserToDeleteRows = false;
            this.dtgItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSeq,
            this.clnIdProd,
            this.clnDescricao,
            this.clnValorUnit,
            this.clnQtd,
            this.clnTotalItem});
            this.dtgItens.Location = new System.Drawing.Point(13, 107);
            this.dtgItens.Name = "dtgItens";
            this.dtgItens.ReadOnly = true;
            this.dtgItens.RowHeadersVisible = false;
            this.dtgItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgItens.Size = new System.Drawing.Size(525, 150);
            this.dtgItens.TabIndex = 5;
            // 
            // clnSeq
            // 
            this.clnSeq.Frozen = true;
            this.clnSeq.HeaderText = "#";
            this.clnSeq.Name = "clnSeq";
            this.clnSeq.ReadOnly = true;
            this.clnSeq.Width = 25;
            // 
            // clnIdProd
            // 
            this.clnIdProd.Frozen = true;
            this.clnIdProd.HeaderText = "ID";
            this.clnIdProd.Name = "clnIdProd";
            this.clnIdProd.ReadOnly = true;
            this.clnIdProd.Width = 50;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Frozen = true;
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 200;
            // 
            // clnValorUnit
            // 
            this.clnValorUnit.Frozen = true;
            this.clnValorUnit.HeaderText = "Valor Unitário";
            this.clnValorUnit.Name = "clnValorUnit";
            this.clnValorUnit.ReadOnly = true;
            this.clnValorUnit.Width = 75;
            // 
            // clnQtd
            // 
            this.clnQtd.Frozen = true;
            this.clnQtd.HeaderText = "Quantidade";
            this.clnQtd.Name = "clnQtd";
            this.clnQtd.ReadOnly = true;
            this.clnQtd.Width = 75;
            // 
            // clnTotalItem
            // 
            this.clnTotalItem.Frozen = true;
            this.clnTotalItem.HeaderText = "Total Item";
            this.clnTotalItem.Name = "clnTotalItem";
            this.clnTotalItem.ReadOnly = true;
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.Location = new System.Drawing.Point(487, 57);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(51, 23);
            this.btnInserirItem.TabIndex = 4;
            this.btnInserirItem.Text = "&Inserir";
            this.btnInserirItem.UseVisualStyleBackColor = true;
            // 
            // txtQtdProd
            // 
            this.txtQtdProd.Location = new System.Drawing.Point(412, 60);
            this.txtQtdProd.Name = "txtQtdProd";
            this.txtQtdProd.Size = new System.Drawing.Size(69, 20);
            this.txtQtdProd.TabIndex = 3;
            // 
            // txtValorUnitProd
            // 
            this.txtValorUnitProd.Location = new System.Drawing.Point(304, 60);
            this.txtValorUnitProd.Name = "txtValorUnitProd";
            this.txtValorUnitProd.Size = new System.Drawing.Size(102, 20);
            this.txtValorUnitProd.TabIndex = 2;
            // 
            // txtDescricaoProd
            // 
            this.txtDescricaoProd.Location = new System.Drawing.Point(107, 60);
            this.txtDescricaoProd.Name = "txtDescricaoProd";
            this.txtDescricaoProd.Size = new System.Drawing.Size(191, 20);
            this.txtDescricaoProd.TabIndex = 1;
            // 
            // cmbCodProd
            // 
            this.cmbCodProd.FormattingEnabled = true;
            this.cmbCodProd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbCodProd.Location = new System.Drawing.Point(13, 60);
            this.cmbCodProd.Name = "cmbCodProd";
            this.cmbCodProd.Size = new System.Drawing.Size(88, 21);
            this.cmbCodProd.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCriar);
            this.groupBox1.Controls.Add(this.cmbVendedor);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDataPed);
            this.groupBox1.Controls.Add(this.txtIdPedido);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pedido";
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(487, 71);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(51, 23);
            this.btnCriar.TabIndex = 7;
            this.btnCriar.Text = "&Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbVendedor.Location = new System.Drawing.Point(15, 73);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(266, 21);
            this.cmbVendedor.TabIndex = 8;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbCliente.Location = new System.Drawing.Point(15, 34);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(266, 21);
            this.cmbCliente.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID PEDIDO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nome Usuário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome Cliente";
            // 
            // txtDataPed
            // 
            this.txtDataPed.Location = new System.Drawing.Point(332, 34);
            this.txtDataPed.Name = "txtDataPed";
            this.txtDataPed.ReadOnly = true;
            this.txtDataPed.Size = new System.Drawing.Size(100, 20);
            this.txtDataPed.TabIndex = 0;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPedido.Location = new System.Drawing.Point(438, 34);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(100, 29);
            this.txtIdPedido.TabIndex = 0;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotalItem;
        private System.Windows.Forms.Button btnInserirItem;
        private System.Windows.Forms.TextBox txtQtdProd;
        private System.Windows.Forms.TextBox txtValorUnitProd;
        private System.Windows.Forms.TextBox txtDescricaoProd;
        private System.Windows.Forms.ComboBox cmbCodProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDataPed;
        private System.Windows.Forms.TextBox txtIdPedido;
    }
}