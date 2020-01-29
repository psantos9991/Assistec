namespace login
{
    partial class faturaçao
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
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblAsuntos = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtSerNum = new System.Windows.Forms.TextBox();
            this.labelPrecoTotal = new System.Windows.Forms.Label();
            this.checkIva = new System.Windows.Forms.CheckBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelSerNum = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNif = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinatario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.lblDestinatario.Location = new System.Drawing.Point(17, 117);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(72, 23);
            this.lblDestinatario.TabIndex = 10;
            this.lblDestinatario.Text = "Destinatario:";
            // 
            // lblAsuntos
            // 
            this.lblAsuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsuntos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.lblAsuntos.Location = new System.Drawing.Point(17, 150);
            this.lblAsuntos.Name = "lblAsuntos";
            this.lblAsuntos.Size = new System.Drawing.Size(54, 23);
            this.lblAsuntos.TabIndex = 11;
            this.lblAsuntos.Text = "Assunto:";
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.White;
            this.gbCliente.Controls.Add(this.txtSerNum);
            this.gbCliente.Controls.Add(this.labelPrecoTotal);
            this.gbCliente.Controls.Add(this.checkIva);
            this.gbCliente.Controls.Add(this.labelPreco);
            this.gbCliente.Controls.Add(this.txtPreco);
            this.gbCliente.Controls.Add(this.txtMarca);
            this.gbCliente.Controls.Add(this.labelMarca);
            this.gbCliente.Controls.Add(this.labelSerNum);
            this.gbCliente.Controls.Add(this.txtNif);
            this.gbCliente.Controls.Add(this.txtNome);
            this.gbCliente.Controls.Add(this.labelNif);
            this.gbCliente.Controls.Add(this.labelNome);
            this.gbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.gbCliente.Location = new System.Drawing.Point(9, 212);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(461, 192);
            this.gbCliente.TabIndex = 27;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txtSerNum
            // 
            this.txtSerNum.Location = new System.Drawing.Point(257, 76);
            this.txtSerNum.Name = "txtSerNum";
            this.txtSerNum.Size = new System.Drawing.Size(187, 20);
            this.txtSerNum.TabIndex = 6;
            // 
            // labelPrecoTotal
            // 
            this.labelPrecoTotal.BackColor = System.Drawing.SystemColors.Window;
            this.labelPrecoTotal.Location = new System.Drawing.Point(281, 137);
            this.labelPrecoTotal.Name = "labelPrecoTotal";
            this.labelPrecoTotal.Size = new System.Drawing.Size(82, 20);
            this.labelPrecoTotal.TabIndex = 34;
            this.labelPrecoTotal.Text = "0 €";
            this.labelPrecoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkIva
            // 
            this.checkIva.AutoSize = true;
            this.checkIva.Location = new System.Drawing.Point(211, 140);
            this.checkIva.Name = "checkIva";
            this.checkIva.Size = new System.Drawing.Size(40, 17);
            this.checkIva.TabIndex = 33;
            this.checkIva.Text = "iva";
            this.checkIva.UseVisualStyleBackColor = true;
            this.checkIva.CheckedChanged += new System.EventHandler(this.checkIva_CheckedChanged);
            // 
            // labelPreco
            // 
            this.labelPreco.Location = new System.Drawing.Point(11, 136);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(42, 21);
            this.labelPreco.TabIndex = 32;
            this.labelPreco.Text = "Preço";
            this.labelPreco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(59, 140);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(108, 20);
            this.txtPreco.TabIndex = 7;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(58, 76);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(160, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // labelMarca
            // 
            this.labelMarca.Location = new System.Drawing.Point(11, 74);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(41, 21);
            this.labelMarca.TabIndex = 29;
            this.labelMarca.Text = "Marca";
            this.labelMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSerNum
            // 
            this.labelSerNum.Location = new System.Drawing.Point(224, 75);
            this.labelSerNum.Name = "labelSerNum";
            this.labelSerNum.Size = new System.Drawing.Size(27, 20);
            this.labelSerNum.TabIndex = 28;
            this.labelSerNum.Text = "S/N";
            this.labelSerNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(321, 39);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(123, 20);
            this.txtNif.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 20);
            this.txtNome.TabIndex = 3;
            // 
            // labelNif
            // 
            this.labelNif.Location = new System.Drawing.Point(295, 39);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(31, 21);
            this.labelNif.TabIndex = 25;
            this.labelNif.Text = "NIF";
            this.labelNif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNome
            // 
            this.labelNome.Location = new System.Drawing.Point(11, 40);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(41, 21);
            this.labelNome.TabIndex = 24;
            this.labelNome.Text = "Nome";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.BtnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.BtnEnviar.ForeColor = System.Drawing.Color.White;
            this.BtnEnviar.Location = new System.Drawing.Point(343, 444);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(110, 30);
            this.BtnEnviar.TabIndex = 28;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(180, 444);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 30);
            this.btnLimpar.TabIndex = 29;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 59);
            this.panel1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fatura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPara
            // 
            this.txtPara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.txtPara.Location = new System.Drawing.Point(95, 114);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(335, 20);
            this.txtPara.TabIndex = 31;
            // 
            // txtAssunto
            // 
            this.txtAssunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.txtAssunto.Location = new System.Drawing.Point(95, 147);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(335, 20);
            this.txtAssunto.TabIndex = 32;
            this.txtAssunto.Text = "Dados do cliente";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 547);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(479, 2);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 488);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(477, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 488);
            this.panel3.TabIndex = 35;
            // 
            // faturaçao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.lblAsuntos);
            this.Controls.Add(this.lblDestinatario);
            this.Name = "faturaçao";
            this.Size = new System.Drawing.Size(479, 549);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblAsuntos;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtSerNum;
        private System.Windows.Forms.Label labelPrecoTotal;
        private System.Windows.Forms.CheckBox checkIva;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelSerNum;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNif;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
