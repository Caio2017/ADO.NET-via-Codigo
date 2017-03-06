namespace WindowsFormsApplication1
{
    partial class frmMain
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
            if(disposing && (components != null))
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rdoFeminino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cboNomesClientes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnDataReaderGrid1 = new System.Windows.Forms.Button();
            this.btnDataAdapterGrid1 = new System.Windows.Forms.Button();
            this.btnDataReaderDataTableGrid1 = new System.Windows.Forms.Button();
            this.btnDataSetGrid1 = new System.Windows.Forms.Button();
            this.btnDataAdapterGrid2 = new System.Windows.Forms.Button();
            this.btnExibirListView = new System.Windows.Forms.Button();
            this.btnDRcbo = new System.Windows.Forms.Button();
            this.btnDTcbo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(260, 299);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(236, 130);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(236, 146);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(288, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 23);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar por ID";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnsCreateSelectUpdateDelete_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(196, 43);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnsCreateSelectUpdateDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(196, 70);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnsCreateSelectUpdateDelete_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(196, 15);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnsCreateSelectUpdateDelete_Click);
            // 
            // rdoFeminino
            // 
            this.rdoFeminino.AutoSize = true;
            this.rdoFeminino.Location = new System.Drawing.Point(120, 75);
            this.rdoFeminino.Name = "rdoFeminino";
            this.rdoFeminino.Size = new System.Drawing.Size(31, 17);
            this.rdoFeminino.TabIndex = 16;
            this.rdoFeminino.Text = "F";
            this.rdoFeminino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Checked = true;
            this.rdoMasculino.Location = new System.Drawing.Point(80, 75);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(34, 17);
            this.rdoMasculino.TabIndex = 15;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "M";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(80, 48);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.dtpDataNascimento.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.PowderBlue;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colSexo,
            this.colNasc});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Location = new System.Drawing.Point(260, 118);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(236, 146);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 67.66593F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.FillWeight = 125.5579F;
            this.colNome.HeaderText = "NOME";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colSexo
            // 
            this.colSexo.DataPropertyName = "Sexo";
            this.colSexo.FillWeight = 81.21828F;
            this.colSexo.HeaderText = "SEXO";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            // 
            // colNasc
            // 
            this.colNasc.DataPropertyName = "DataNascimento";
            this.colNasc.FillWeight = 125.5579F;
            this.colNasc.HeaderText = "Nascimento";
            this.colNasc.Name = "colNasc";
            this.colNasc.ReadOnly = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 360);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 69);
            this.listBox1.TabIndex = 27;
            // 
            // cboNomesClientes
            // 
            this.cboNomesClientes.FormattingEnabled = true;
            this.cboNomesClientes.Location = new System.Drawing.Point(15, 333);
            this.cboNomesClientes.Name = "cboNomesClientes";
            this.cboNomesClientes.Size = new System.Drawing.Size(233, 21);
            this.cboNomesClientes.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.dtpDataNascimento);
            this.groupBox1.Controls.Add(this.rdoMasculino);
            this.groupBox1.Controls.Add(this.rdoFeminino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 100);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(337, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 20);
            this.txtId.TabIndex = 40;
            // 
            // btnDataReaderGrid1
            // 
            this.btnDataReaderGrid1.Location = new System.Drawing.Point(160, 270);
            this.btnDataReaderGrid1.Name = "btnDataReaderGrid1";
            this.btnDataReaderGrid1.Size = new System.Drawing.Size(89, 23);
            this.btnDataReaderGrid1.TabIndex = 32;
            this.btnDataReaderGrid1.Tag = "DataReader";
            this.btnDataReaderGrid1.Text = "Exibir(DR)";
            this.btnDataReaderGrid1.UseVisualStyleBackColor = true;
            this.btnDataReaderGrid1.Click += new System.EventHandler(this.btnsDoGridView1_Click);
            // 
            // btnDataAdapterGrid1
            // 
            this.btnDataAdapterGrid1.Location = new System.Drawing.Point(12, 270);
            this.btnDataAdapterGrid1.Name = "btnDataAdapterGrid1";
            this.btnDataAdapterGrid1.Size = new System.Drawing.Size(106, 23);
            this.btnDataAdapterGrid1.TabIndex = 31;
            this.btnDataAdapterGrid1.Tag = "DataAdapter";
            this.btnDataAdapterGrid1.Text = "Exibir(DataAdapter)";
            this.btnDataAdapterGrid1.UseVisualStyleBackColor = true;
            this.btnDataAdapterGrid1.Click += new System.EventHandler(this.btnsDoGridView1_Click);
            // 
            // btnDataReaderDataTableGrid1
            // 
            this.btnDataReaderDataTableGrid1.Location = new System.Drawing.Point(160, 299);
            this.btnDataReaderDataTableGrid1.Name = "btnDataReaderDataTableGrid1";
            this.btnDataReaderDataTableGrid1.Size = new System.Drawing.Size(89, 23);
            this.btnDataReaderDataTableGrid1.TabIndex = 34;
            this.btnDataReaderDataTableGrid1.Tag = "DataReaderEDataTable";
            this.btnDataReaderDataTableGrid1.Text = "Exibir(DR,DT)";
            this.btnDataReaderDataTableGrid1.UseVisualStyleBackColor = true;
            this.btnDataReaderDataTableGrid1.Click += new System.EventHandler(this.btnsDoGridView1_Click);
            // 
            // btnDataSetGrid1
            // 
            this.btnDataSetGrid1.Location = new System.Drawing.Point(12, 299);
            this.btnDataSetGrid1.Name = "btnDataSetGrid1";
            this.btnDataSetGrid1.Size = new System.Drawing.Size(106, 23);
            this.btnDataSetGrid1.TabIndex = 33;
            this.btnDataSetGrid1.Tag = "DataSet";
            this.btnDataSetGrid1.Text = "Exibir(DataSet)";
            this.btnDataSetGrid1.UseVisualStyleBackColor = true;
            this.btnDataSetGrid1.Click += new System.EventHandler(this.btnsDoGridView1_Click);
            // 
            // btnDataAdapterGrid2
            // 
            this.btnDataAdapterGrid2.Location = new System.Drawing.Point(390, 270);
            this.btnDataAdapterGrid2.Name = "btnDataAdapterGrid2";
            this.btnDataAdapterGrid2.Size = new System.Drawing.Size(106, 23);
            this.btnDataAdapterGrid2.TabIndex = 35;
            this.btnDataAdapterGrid2.Text = "Exibir(DataAdapter)";
            this.btnDataAdapterGrid2.UseVisualStyleBackColor = true;
            this.btnDataAdapterGrid2.Click += new System.EventHandler(this.btnDataAdapterGrid2_Click);
            // 
            // btnExibirListView
            // 
            this.btnExibirListView.Location = new System.Drawing.Point(407, 435);
            this.btnExibirListView.Name = "btnExibirListView";
            this.btnExibirListView.Size = new System.Drawing.Size(89, 23);
            this.btnExibirListView.TabIndex = 36;
            this.btnExibirListView.Text = "Exibir(DR)";
            this.btnExibirListView.UseVisualStyleBackColor = true;
            this.btnExibirListView.Click += new System.EventHandler(this.btnExibirListView_Click);
            // 
            // btnDRcbo
            // 
            this.btnDRcbo.Location = new System.Drawing.Point(16, 438);
            this.btnDRcbo.Name = "btnDRcbo";
            this.btnDRcbo.Size = new System.Drawing.Size(42, 20);
            this.btnDRcbo.TabIndex = 37;
            this.btnDRcbo.Text = "DR";
            this.btnDRcbo.UseVisualStyleBackColor = true;
            this.btnDRcbo.Click += new System.EventHandler(this.btnsCarregarComboEListBox_Click);
            // 
            // btnDTcbo
            // 
            this.btnDTcbo.Location = new System.Drawing.Point(64, 438);
            this.btnDTcbo.Name = "btnDTcbo";
            this.btnDTcbo.Size = new System.Drawing.Size(44, 20);
            this.btnDTcbo.TabIndex = 38;
            this.btnDTcbo.Text = "DT";
            this.btnDTcbo.UseVisualStyleBackColor = true;
            this.btnDTcbo.Click += new System.EventHandler(this.btnsCarregarComboEListBox_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 464);
            this.Controls.Add(this.btnDTcbo);
            this.Controls.Add(this.btnDRcbo);
            this.Controls.Add(this.btnExibirListView);
            this.Controls.Add(this.btnDataAdapterGrid2);
            this.Controls.Add(this.btnDataReaderDataTableGrid1);
            this.Controls.Add(this.btnDataSetGrid1);
            this.Controls.Add(this.btnDataReaderGrid1);
            this.Controls.Add(this.btnDataAdapterGrid1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboNomesClientes);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ref ADO .NET via Codigo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton rdoFeminino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cboNomesClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDataReaderGrid1;
        private System.Windows.Forms.Button btnDataAdapterGrid1;
        private System.Windows.Forms.Button btnDataReaderDataTableGrid1;
        private System.Windows.Forms.Button btnDataSetGrid1;
        private System.Windows.Forms.Button btnDataAdapterGrid2;
        private System.Windows.Forms.Button btnExibirListView;
        private System.Windows.Forms.Button btnDRcbo;
        private System.Windows.Forms.Button btnDTcbo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNasc;
    }
}

