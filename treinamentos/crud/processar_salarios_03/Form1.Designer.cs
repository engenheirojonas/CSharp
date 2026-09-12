namespace conexao_mysql_01
{
    partial class Form1
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
            label1 = new Label();
            txtID = new TextBox();
            txtBonus = new TextBox();
            label2 = new Label();
            txtSalarioBruto = new TextBox();
            label3 = new Label();
            txtDepartamento = new TextBox();
            label4 = new Label();
            txtCargo = new TextBox();
            label5 = new Label();
            txtNome = new TextBox();
            label6 = new Label();
            dgvFuncionarios = new DataGridView();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnImprimir = new Button();
            cmbFiltroDepartamento = new ComboBox();
            cmbFiltroMes = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            numFiltroAno = new NumericUpDown();
            btnFiltrar = new Button();
            btnLimparFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFiltroAno).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT Condensed", 12F);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtID
            // 
            txtID.Font = new Font("Bodoni MT Condensed", 12F);
            txtID.Location = new Point(56, 23);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(129, 26);
            txtID.TabIndex = 1;
            // 
            // txtBonus
            // 
            txtBonus.Font = new Font("Bodoni MT Condensed", 12F);
            txtBonus.Location = new Point(55, 240);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(235, 26);
            txtBonus.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT Condensed", 12F);
            label2.Location = new Point(12, 243);
            label2.Name = "label2";
            label2.Size = new Size(37, 19);
            label2.TabIndex = 2;
            label2.Text = "Bonus";
            // 
            // txtSalarioBruto
            // 
            txtSalarioBruto.Font = new Font("Bodoni MT Condensed", 12F);
            txtSalarioBruto.Location = new Point(86, 192);
            txtSalarioBruto.Name = "txtSalarioBruto";
            txtSalarioBruto.Size = new Size(204, 26);
            txtSalarioBruto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT Condensed", 12F);
            label3.Location = new Point(12, 195);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 4;
            label3.Text = "Salario Bruto";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Font = new Font("Bodoni MT Condensed", 12F);
            txtDepartamento.Location = new Point(90, 151);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(200, 26);
            txtDepartamento.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT Condensed", 12F);
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 6;
            label4.Text = "Departamento";
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Bodoni MT Condensed", 12F);
            txtCargo.Location = new Point(56, 107);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(234, 26);
            txtCargo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bodoni MT Condensed", 12F);
            label5.Location = new Point(12, 110);
            label5.Name = "label5";
            label5.Size = new Size(35, 19);
            label5.TabIndex = 8;
            label5.Text = "Cargo";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Bodoni MT Condensed", 12F);
            txtNome.Location = new Point(56, 64);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(234, 26);
            txtNome.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bodoni MT Condensed", 12F);
            label6.Location = new Point(12, 67);
            label6.Name = "label6";
            label6.Size = new Size(36, 19);
            label6.TabIndex = 10;
            label6.Text = "Nome";
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(309, 52);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.Size = new Size(671, 214);
            dgvFuncionarios.TabIndex = 12;
            dgvFuncionarios.CellClick += dgvFuncionarios_CellClick;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(203, 288);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(360, 288);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Atualizar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(509, 288);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(652, 288);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(774, 288);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(163, 23);
            btnImprimir.TabIndex = 17;
            btnImprimir.Text = "Imprimir folha de salario";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // cmbFiltroDepartamento
            // 
            cmbFiltroDepartamento.FormattingEnabled = true;
            cmbFiltroDepartamento.Items.AddRange(new object[] { "", "Opera", "Administraçao", "Finanças" });
            cmbFiltroDepartamento.Location = new Point(332, 12);
            cmbFiltroDepartamento.Name = "cmbFiltroDepartamento";
            cmbFiltroDepartamento.Size = new Size(121, 23);
            cmbFiltroDepartamento.TabIndex = 18;
            // 
            // cmbFiltroMes
            // 
            cmbFiltroMes.FormattingEnabled = true;
            cmbFiltroMes.Items.AddRange(new object[] { "", "1", "2", "3" });
            cmbFiltroMes.Location = new Point(536, 12);
            cmbFiltroMes.Name = "cmbFiltroMes";
            cmbFiltroMes.Size = new Size(121, 23);
            cmbFiltroMes.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 15);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 20;
            label7.Text = "Filtro Departamento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(471, 15);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 21;
            label8.Text = "Filtro Mês";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(680, 17);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 23;
            label9.Text = "Filtro Mês";
            // 
            // numFiltroAno
            // 
            numFiltroAno.Location = new Point(745, 13);
            numFiltroAno.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numFiltroAno.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            numFiltroAno.Name = "numFiltroAno";
            numFiltroAno.Size = new Size(68, 23);
            numFiltroAno.TabIndex = 24;
            numFiltroAno.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(819, 13);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(59, 23);
            btnFiltrar.TabIndex = 25;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click_1;
            // 
            // btnLimparFiltrar
            // 
            btnLimparFiltrar.Location = new Point(884, 15);
            btnLimparFiltrar.Name = "btnLimparFiltrar";
            btnLimparFiltrar.Size = new Size(96, 23);
            btnLimparFiltrar.TabIndex = 26;
            btnLimparFiltrar.Text = "Limpar Filtros";
            btnLimparFiltrar.UseVisualStyleBackColor = true;
            btnLimparFiltrar.Click += btnLimparFiltrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 321);
            Controls.Add(btnLimparFiltrar);
            Controls.Add(btnFiltrar);
            Controls.Add(numFiltroAno);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbFiltroMes);
            Controls.Add(cmbFiltroDepartamento);
            Controls.Add(btnImprimir);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(dgvFuncionarios);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(txtCargo);
            Controls.Add(label5);
            Controls.Add(txtDepartamento);
            Controls.Add(label4);
            Controls.Add(txtSalarioBruto);
            Controls.Add(label3);
            Controls.Add(txtBonus);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFiltroAno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtBonus;
        private Label label2;
        private TextBox txtSalarioBruto;
        private Label label3;
        private TextBox txtDepartamento;
        private Label label4;
        private TextBox txtCargo;
        private Label label5;
        private TextBox txtNome;
        private Label label6;
        private DataGridView dgvFuncionarios;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnImprimir;
        private ComboBox cmbFiltroDepartamento;
        private ComboBox cmbFiltroMes;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown numFiltroAno;
        private Button btnFiltrar;
        private Button btnLimparFiltrar;
    }
}
