using System.Windows.Forms;

namespace ProcessSchedulingSimulatorWinForms
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProcesses = new System.Windows.Forms.TabPage();
            this.dgvProcessos = new System.Windows.Forms.DataGridView();
            this.btnLimparProcessos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGerarAleatorios = new System.Windows.Forms.Button();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarProcesso = new System.Windows.Forms.Button();
            this.numPrioridade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numTempoCPU = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numTempoChegada = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeProcesso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSimulation = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblMetricas = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAlgoritmo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstHistoricoExecucao = new System.Windows.Forms.ListBox();
            this.btnExecutarSimulacao = new System.Windows.Forms.Button();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSalvarRelatorio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvComparacao = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQuantidadeProcessos = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPageProcesses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrioridade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoChegada)).BeginInit();
            this.tabPageSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparacao)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProcesses);
            this.tabControl1.Controls.Add(this.tabPageSimulation);
            this.tabControl1.Controls.Add(this.tabPageResults);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 440);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageProcesses
            // 
            this.tabPageProcesses.Controls.Add(this.dgvProcessos);
            this.tabPageProcesses.Controls.Add(this.btnLimparProcessos);
            this.tabPageProcesses.Controls.Add(this.groupBox2);
            this.tabPageProcesses.Controls.Add(this.groupBox1);
            this.tabPageProcesses.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcesses.Name = "tabPageProcesses";
            this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tabPageProcesses.Size = new System.Drawing.Size(835, 414);
            this.tabPageProcesses.TabIndex = 0;
            this.tabPageProcesses.Text = "Gerenciar Processos";
            this.tabPageProcesses.UseVisualStyleBackColor = true;
            // 
            // dgvProcessos
            // 
            this.dgvProcessos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcessos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcessos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessos.Location = new System.Drawing.Point(11, 173);
            this.dgvProcessos.Name = "dgvProcessos";
            this.dgvProcessos.ReadOnly = true;
            this.dgvProcessos.Size = new System.Drawing.Size(814, 205);
            this.dgvProcessos.TabIndex = 3;
            // 
            // btnLimparProcessos
            // 
            this.btnLimparProcessos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimparProcessos.BackColor = System.Drawing.Color.LightCoral;
            this.btnLimparProcessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparProcessos.Location = new System.Drawing.Point(11, 384);
            this.btnLimparProcessos.Name = "btnLimparProcessos";
            this.btnLimparProcessos.Size = new System.Drawing.Size(103, 26);
            this.btnLimparProcessos.TabIndex = 2;
            this.btnLimparProcessos.Text = "Limpar Processos";
            this.btnLimparProcessos.UseVisualStyleBackColor = false;
            this.btnLimparProcessos.Click += new System.EventHandler(this.BtnLimparProcessos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnGerarAleatorios);
            this.groupBox2.Controls.Add(this.numQuantidade);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(429, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerar Processos Aleatórios";
            // 
            // btnGerarAleatorios
            // 
            this.btnGerarAleatorios.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGerarAleatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarAleatorios.Location = new System.Drawing.Point(129, 87);
            this.btnGerarAleatorios.Name = "btnGerarAleatorios";
            this.btnGerarAleatorios.Size = new System.Drawing.Size(129, 30);
            this.btnGerarAleatorios.TabIndex = 2;
            this.btnGerarAleatorios.Text = "Gerar Processos";
            this.btnGerarAleatorios.UseVisualStyleBackColor = false;
            this.btnGerarAleatorios.Click += new System.EventHandler(this.BtnGerarAleatorios_Click);
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(129, 43);
            this.numQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(129, 20);
            this.numQuantidade.TabIndex = 1;
            this.numQuantidade.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantidade:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionarProcesso);
            this.groupBox1.Controls.Add(this.numPrioridade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numTempoCPU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numTempoChegada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomeProcesso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Processo Manualmente";
            // 
            // btnAdicionarProcesso
            // 
            this.btnAdicionarProcesso.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdicionarProcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProcesso.Location = new System.Drawing.Point(129, 121);
            this.btnAdicionarProcesso.Name = "btnAdicionarProcesso";
            this.btnAdicionarProcesso.Size = new System.Drawing.Size(129, 30);
            this.btnAdicionarProcesso.TabIndex = 8;
            this.btnAdicionarProcesso.Text = "Adicionar Processo";
            this.btnAdicionarProcesso.UseVisualStyleBackColor = false;
            this.btnAdicionarProcesso.Click += new System.EventHandler(this.BtnAdicionarProcesso_Click);
            // 
            // numPrioridade
            // 
            this.numPrioridade.Location = new System.Drawing.Point(129, 95);
            this.numPrioridade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrioridade.Name = "numPrioridade";
            this.numPrioridade.Size = new System.Drawing.Size(129, 20);
            this.numPrioridade.TabIndex = 7;
            this.numPrioridade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prioridade:";
            // 
            // numTempoCPU
            // 
            this.numTempoCPU.Location = new System.Drawing.Point(129, 69);
            this.numTempoCPU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTempoCPU.Name = "numTempoCPU";
            this.numTempoCPU.Size = new System.Drawing.Size(129, 20);
            this.numTempoCPU.TabIndex = 5;
            this.numTempoCPU.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tempo CPU:";
            // 
            // numTempoChegada
            // 
            this.numTempoChegada.Location = new System.Drawing.Point(129, 43);
            this.numTempoChegada.Name = "numTempoChegada";
            this.numTempoChegada.Size = new System.Drawing.Size(129, 20);
            this.numTempoChegada.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo Chegada:";
            // 
            // txtNomeProcesso
            // 
            this.txtNomeProcesso.Location = new System.Drawing.Point(129, 17);
            this.txtNomeProcesso.Name = "txtNomeProcesso";
            this.txtNomeProcesso.Size = new System.Drawing.Size(129, 20);
            this.txtNomeProcesso.TabIndex = 1;
            this.txtNomeProcesso.Text = "Ex: P1, ProcessoA";
            this.txtNomeProcesso.TextChanged += new System.EventHandler(this.txtNomeProcesso_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabPageSimulation
            // 
            this.tabPageSimulation.Controls.Add(this.splitContainer1);
            this.tabPageSimulation.Controls.Add(this.btnExecutarSimulacao);
            this.tabPageSimulation.Location = new System.Drawing.Point(4, 22);
            this.tabPageSimulation.Name = "tabPageSimulation";
            this.tabPageSimulation.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tabPageSimulation.Size = new System.Drawing.Size(835, 414);
            this.tabPageSimulation.TabIndex = 1;
            this.tabPageSimulation.Text = "Simulação";
            this.tabPageSimulation.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(11, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblMetricas);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(814, 352);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblMetricas
            // 
            this.lblMetricas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMetricas.BackColor = System.Drawing.SystemColors.Info;
            this.lblMetricas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetricas.Location = new System.Drawing.Point(3, 69);
            this.lblMetricas.Name = "lblMetricas";
            this.lblMetricas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblMetricas.Size = new System.Drawing.Size(265, 281);
            this.lblMetricas.TabIndex = 1;
            this.lblMetricas.Text = "Execute a simulação para ver as métricas...";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmbAlgoritmo);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 62);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleção de Algoritmo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Algoritmo:";
            // 
            // cmbAlgoritmo
            // 
            this.cmbAlgoritmo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgoritmo.FormattingEnabled = true;
            this.cmbAlgoritmo.Location = new System.Drawing.Point(65, 25);
            this.cmbAlgoritmo.Name = "cmbAlgoritmo";
            this.cmbAlgoritmo.Size = new System.Drawing.Size(195, 21);
            this.cmbAlgoritmo.TabIndex = 0;
            this.cmbAlgoritmo.SelectedIndexChanged += new System.EventHandler(this.CmbAlgoritmo_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lstHistoricoExecucao);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 347);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Histórico de Execução";
            // 
            // lstHistoricoExecucao
            // 
            this.lstHistoricoExecucao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHistoricoExecucao.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstHistoricoExecucao.FormattingEnabled = true;
            this.lstHistoricoExecucao.ItemHeight = 14;
            this.lstHistoricoExecucao.Location = new System.Drawing.Point(5, 19);
            this.lstHistoricoExecucao.Name = "lstHistoricoExecucao";
            this.lstHistoricoExecucao.Size = new System.Drawing.Size(524, 312);
            this.lstHistoricoExecucao.TabIndex = 0;
            // 
            // btnExecutarSimulacao
            // 
            this.btnExecutarSimulacao.BackColor = System.Drawing.Color.Gold;
            this.btnExecutarSimulacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutarSimulacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExecutarSimulacao.Location = new System.Drawing.Point(11, 11);
            this.btnExecutarSimulacao.Name = "btnExecutarSimulacao";
            this.btnExecutarSimulacao.Size = new System.Drawing.Size(129, 36);
            this.btnExecutarSimulacao.TabIndex = 0;
            this.btnExecutarSimulacao.Text = "Executar Simulação";
            this.btnExecutarSimulacao.UseVisualStyleBackColor = false;
            this.btnExecutarSimulacao.Click += new System.EventHandler(this.BtnExecutarSimulacao_Click);
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.splitContainer2);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tabPageResults.Size = new System.Drawing.Size(835, 414);
            this.tabPageResults.TabIndex = 2;
            this.tabPageResults.Text = "Resultados e Comparação";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(9, 9);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnSalvarRelatorio);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvComparacao);
            this.splitContainer2.Size = new System.Drawing.Size(817, 396);
            this.splitContainer2.SplitterDistance = 51;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnSalvarRelatorio
            // 
            this.btnSalvarRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarRelatorio.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalvarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarRelatorio.Location = new System.Drawing.Point(684, 13);
            this.btnSalvarRelatorio.Name = "btnSalvarRelatorio";
            this.btnSalvarRelatorio.Size = new System.Drawing.Size(129, 30);
            this.btnSalvarRelatorio.TabIndex = 1;
            this.btnSalvarRelatorio.Text = "Salvar Relatório";
            this.btnSalvarRelatorio.UseVisualStyleBackColor = false;
            this.btnSalvarRelatorio.Click += new System.EventHandler(this.BtnSalvarRelatorio_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Comparação entre Algoritmos:";
            // 
            // dgvComparacao
            // 
            this.dgvComparacao.AllowUserToAddRows = false;
            this.dgvComparacao.AllowUserToDeleteRows = false;
            this.dgvComparacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComparacao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvComparacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComparacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComparacao.Location = new System.Drawing.Point(0, 0);
            this.dgvComparacao.Name = "dgvComparacao";
            this.dgvComparacao.ReadOnly = true;
            this.dgvComparacao.RowHeadersVisible = false;
            this.dgvComparacao.Size = new System.Drawing.Size(817, 342);
            this.dgvComparacao.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblQuantidadeProcessos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(843, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = "Processos na lista:";
            // 
            // lblQuantidadeProcessos
            // 
            this.lblQuantidadeProcessos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuantidadeProcessos.Name = "lblQuantidadeProcessos";
            this.lblQuantidadeProcessos.Size = new System.Drawing.Size(14, 17);
            this.lblQuantidadeProcessos.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 462);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(859, 501);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Escalonamento de Processos";
            this.tabControl1.ResumeLayout(false);
            this.tabPageProcesses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrioridade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoChegada)).EndInit();
            this.tabPageSimulation.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPageResults.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparacao)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageProcesses;
        private TabPage tabPageSimulation;
        private TabPage tabPageResults;
        private GroupBox groupBox1;
        private TextBox txtNomeProcesso;
        private Label label1;
        private Button btnAdicionarProcesso;
        private NumericUpDown numPrioridade;
        private Label label4;
        private NumericUpDown numTempoCPU;
        private Label label3;
        private NumericUpDown numTempoChegada;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnGerarAleatorios;
        private NumericUpDown numQuantidade;
        private Label label5;
        private DataGridView dgvProcessos;
        private Button btnLimparProcessos;
        private Button btnExecutarSimulacao;
        private ComboBox cmbAlgoritmo;
        private Label label6;
        private ListBox lstHistoricoExecucao;
        private SplitContainer splitContainer1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label lblMetricas;
        private SplitContainer splitContainer2;
        private Label label7;
        private DataGridView dgvComparacao;
        private Button btnSalvarRelatorio;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblQuantidadeProcessos;
    }
}