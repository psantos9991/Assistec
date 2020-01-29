namespace login
{
    partial class formulario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelemovel = new System.Windows.Forms.TextBox();
            this.groupCLiente = new System.Windows.Forms.GroupBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTelemovel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboAcessorios = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.comboAparelho = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboEstadoCor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumObra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServiços = new System.Windows.Forms.RichTextBox();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.lblFolhaObra = new System.Windows.Forms.Label();
            this.lblNObra = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupCLiente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(52, 502);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 85);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(9, 67);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 24);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(674, 502);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(92, 32);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Atualizar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(151, 502);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 85);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(379, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtTelemovel
            // 
            this.txtTelemovel.Location = new System.Drawing.Point(71, 60);
            this.txtTelemovel.Name = "txtTelemovel";
            this.txtTelemovel.Size = new System.Drawing.Size(149, 20);
            this.txtTelemovel.TabIndex = 2;
            // 
            // groupCLiente
            // 
            this.groupCLiente.Controls.Add(this.txtMorada);
            this.groupCLiente.Controls.Add(this.label1);
            this.groupCLiente.Controls.Add(this.txtNif);
            this.groupCLiente.Controls.Add(this.label2);
            this.groupCLiente.Controls.Add(this.txtTelemovel);
            this.groupCLiente.Controls.Add(this.lblTelemovel);
            this.groupCLiente.Controls.Add(this.lblNome);
            this.groupCLiente.Controls.Add(this.txtNome);
            this.groupCLiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCLiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.groupCLiente.Location = new System.Drawing.Point(52, 34);
            this.groupCLiente.Name = "groupCLiente";
            this.groupCLiente.Size = new System.Drawing.Size(449, 133);
            this.groupCLiente.TabIndex = 8;
            this.groupCLiente.TabStop = false;
            this.groupCLiente.Text = "Informação sobre o cliente";
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(54, 100);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(379, 20);
            this.txtMorada.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Morada:";
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(281, 60);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(152, 20);
            this.txtNif.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "NIF:";
            // 
            // lblTelemovel
            // 
            this.lblTelemovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelemovel.Location = new System.Drawing.Point(6, 63);
            this.lblTelemovel.Name = "lblTelemovel";
            this.lblTelemovel.Size = new System.Drawing.Size(68, 23);
            this.lblTelemovel.TabIndex = 10;
            this.lblTelemovel.Text = "Telemovel:";
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 23);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboAcessorios);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboEstado);
            this.groupBox1.Controls.Add(this.comboAparelho);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSerNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.groupBox1.Location = new System.Drawing.Point(52, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 129);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação sobre o aparelho";
            // 
            // comboAcessorios
            // 
            this.comboAcessorios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAcessorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAcessorios.FormattingEnabled = true;
            this.comboAcessorios.ItemHeight = 13;
            this.comboAcessorios.Items.AddRange(new object[] {
            "Nenhum",
            "Carregador",
            "Rato",
            "Teclado",
            "Colunas",
            "Auscultadores",
            "Headphones"});
            this.comboAcessorios.Location = new System.Drawing.Point(319, 92);
            this.comboAcessorios.Name = "comboAcessorios";
            this.comboAcessorios.Size = new System.Drawing.Size(114, 21);
            this.comboAcessorios.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(258, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Acessorios:";
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.ItemHeight = 13;
            this.comboEstado.Items.AddRange(new object[] {
            "Marcas normais de uso",
            "Riscado",
            "Ecrã partido",
            "Outros"});
            this.comboEstado.Location = new System.Drawing.Point(106, 92);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(146, 21);
            this.comboEstado.TabIndex = 9;
            // 
            // comboAparelho
            // 
            this.comboAparelho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAparelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAparelho.ItemHeight = 13;
            this.comboAparelho.Items.AddRange(new object[] {
            "Portátil",
            "Desktop",
            "Telemovel",
            "Tablet",
            "Impressora",
            "Smartwatch",
            "Colunas",
            "Monitor",
            "Televisão"});
            this.comboAparelho.Location = new System.Drawing.Point(261, 61);
            this.comboAparelho.Name = "comboAparelho";
            this.comboAparelho.Size = new System.Drawing.Size(172, 21);
            this.comboAparelho.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(251, 29);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(182, 20);
            this.txtModelo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estado do aparelho:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Aparelho:";
            // 
            // txtSerNum
            // 
            this.txtSerNum.Location = new System.Drawing.Point(54, 62);
            this.txtSerNum.Name = "txtSerNum";
            this.txtSerNum.Size = new System.Drawing.Size(150, 20);
            this.txtSerNum.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "S/N:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(54, 29);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(143, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboEstadoCor);
            this.groupBox2.Controls.Add(this.lblColor);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtNumObra);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(545, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 177);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ficha de cliente";
            // 
            // comboEstadoCor
            // 
            this.comboEstadoCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstadoCor.FormattingEnabled = true;
            this.comboEstadoCor.Items.AddRange(new object[] {
            "Recebido mas não visto",
            "Visto a aguardar peças",
            "Reparado",
            "Sem reparo",
            "Reparado e entregue",
            "Sem reparo e entregue"});
            this.comboEstadoCor.Location = new System.Drawing.Point(9, 141);
            this.comboEstadoCor.Name = "comboEstadoCor";
            this.comboEstadoCor.Size = new System.Drawing.Size(173, 21);
            this.comboEstadoCor.TabIndex = 11;
            this.comboEstadoCor.SelectedIndexChanged += new System.EventHandler(this.comboEstadoCor_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(6, 110);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(176, 23);
            this.lblColor.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(1, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 1);
            this.panel1.TabIndex = 13;
            // 
            // txtNumObra
            // 
            this.txtNumObra.Location = new System.Drawing.Point(107, 25);
            this.txtNumObra.Name = "txtNumObra";
            this.txtNumObra.Size = new System.Drawing.Size(106, 20);
            this.txtNumObra.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Numero de Obra:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(129, 67);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(84, 24);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 23);
            this.label13.TabIndex = 21;
            this.label13.Text = "Avaria reportada pelo cliente";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(52, 363);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(455, 117);
            this.txtDescricao.TabIndex = 22;
            this.txtDescricao.Text = "";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(542, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Avaria reportada pelos serviços técnicos";
            // 
            // txtServiços
            // 
            this.txtServiços.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiços.Location = new System.Drawing.Point(544, 272);
            this.txtServiços.Name = "txtServiços";
            this.txtServiços.Size = new System.Drawing.Size(232, 208);
            this.txtServiços.TabIndex = 24;
            this.txtServiços.Text = "";
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.documento_PrintPage);
            // 
            // lblFolhaObra
            // 
            this.lblFolhaObra.AutoSize = true;
            this.lblFolhaObra.BackColor = System.Drawing.Color.White;
            this.lblFolhaObra.Location = new System.Drawing.Point(736, 5);
            this.lblFolhaObra.Name = "lblFolhaObra";
            this.lblFolhaObra.Size = new System.Drawing.Size(41, 13);
            this.lblFolhaObra.TabIndex = 27;
            this.lblFolhaObra.Text = "label10";
            // 
            // lblNObra
            // 
            this.lblNObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNObra.Location = new System.Drawing.Point(632, 5);
            this.lblNObra.Name = "lblNObra";
            this.lblNObra.Size = new System.Drawing.Size(95, 23);
            this.lblNObra.TabIndex = 14;
            this.lblNObra.Text = "Número de obra:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(544, 501);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(92, 32);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblNObra);
            this.Controls.Add(this.lblFolhaObra);
            this.Controls.Add(this.txtServiços);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupCLiente);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "formulario";
            this.Size = new System.Drawing.Size(856, 604);
            this.groupCLiente.ResumeLayout(false);
            this.groupCLiente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelemovel;
        private System.Windows.Forms.GroupBox groupCLiente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTelemovel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboAparelho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumObra;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboAcessorios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.ComboBox comboEstadoCor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtServiços;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.Label lblFolhaObra;
        private System.Windows.Forms.Label lblNObra;
        private System.Windows.Forms.Button btnLimpar;
    }
}
