namespace ValidaCPFeCNPJ
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboEstados = new System.Windows.Forms.ComboBox();
            this.txtDocumentoGerado = new System.Windows.Forms.TextBox();
            this.radioGerarCPF = new System.Windows.Forms.RadioButton();
            this.radioGerarCNPJ = new System.Windows.Forms.RadioButton();
            this.BtnGerador = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioTitular = new System.Windows.Forms.RadioButton();
            this.RadioCNPJ = new System.Windows.Forms.RadioButton();
            this.RadioCPF = new System.Windows.Forms.RadioButton();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(256, 183);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboEstados);
            this.tabPage1.Controls.Add(this.txtDocumentoGerado);
            this.tabPage1.Controls.Add(this.radioGerarCPF);
            this.tabPage1.Controls.Add(this.radioGerarCNPJ);
            this.tabPage1.Controls.Add(this.BtnGerador);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(248, 157);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gerador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Escolha um estado para o CPF";
            // 
            // comboEstados
            // 
            this.comboEstados.FormattingEnabled = true;
            this.comboEstados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "TE",
            "TO"});
            this.comboEstados.Location = new System.Drawing.Point(68, 74);
            this.comboEstados.Name = "comboEstados";
            this.comboEstados.Size = new System.Drawing.Size(100, 21);
            this.comboEstados.TabIndex = 11;
            // 
            // txtDocumentoGerado
            // 
            this.txtDocumentoGerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoGerado.Location = new System.Drawing.Point(43, 129);
            this.txtDocumentoGerado.Name = "txtDocumentoGerado";
            this.txtDocumentoGerado.Size = new System.Drawing.Size(167, 22);
            this.txtDocumentoGerado.TabIndex = 10;
            // 
            // radioGerarCPF
            // 
            this.radioGerarCPF.AutoSize = true;
            this.radioGerarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGerarCPF.Location = new System.Drawing.Point(56, 12);
            this.radioGerarCPF.Name = "radioGerarCPF";
            this.radioGerarCPF.Size = new System.Drawing.Size(52, 20);
            this.radioGerarCPF.TabIndex = 8;
            this.radioGerarCPF.TabStop = true;
            this.radioGerarCPF.Text = "CPF";
            this.radioGerarCPF.UseVisualStyleBackColor = true;
            // 
            // radioGerarCNPJ
            // 
            this.radioGerarCNPJ.AutoSize = true;
            this.radioGerarCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGerarCNPJ.Location = new System.Drawing.Point(120, 12);
            this.radioGerarCNPJ.Name = "radioGerarCNPJ";
            this.radioGerarCNPJ.Size = new System.Drawing.Size(61, 20);
            this.radioGerarCNPJ.TabIndex = 9;
            this.radioGerarCNPJ.TabStop = true;
            this.radioGerarCNPJ.Text = "CNPJ";
            this.radioGerarCNPJ.UseVisualStyleBackColor = true;
            // 
            // btnGerador
            // 
            this.BtnGerador.Location = new System.Drawing.Point(68, 101);
            this.BtnGerador.Name = "BtnGerador";
            this.BtnGerador.Size = new System.Drawing.Size(100, 22);
            this.BtnGerador.TabIndex = 7;
            this.BtnGerador.Text = "Gerar";
            this.BtnGerador.UseVisualStyleBackColor = true;
            this.BtnGerador.Click += new System.EventHandler(this.BtnGerador_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioTitular);
            this.tabPage2.Controls.Add(this.RadioCNPJ);
            this.tabPage2.Controls.Add(this.RadioCPF);
            this.tabPage2.Controls.Add(this.btnVerifica);
            this.tabPage2.Controls.Add(this.txtDocumento);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(248, 157);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Validador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioTitular
            // 
            this.radioTitular.AutoSize = true;
            this.radioTitular.Location = new System.Drawing.Point(146, 76);
            this.radioTitular.Name = "radioTitular";
            this.radioTitular.Size = new System.Drawing.Size(54, 17);
            this.radioTitular.TabIndex = 11;
            this.radioTitular.TabStop = true;
            this.radioTitular.Text = "Titular";
            this.radioTitular.UseVisualStyleBackColor = true;
            // 
            // RadioCNPJ
            // 
            this.RadioCNPJ.AutoSize = true;
            this.RadioCNPJ.Location = new System.Drawing.Point(88, 76);
            this.RadioCNPJ.Name = "RadioCNPJ";
            this.RadioCNPJ.Size = new System.Drawing.Size(52, 17);
            this.RadioCNPJ.TabIndex = 10;
            this.RadioCNPJ.TabStop = true;
            this.RadioCNPJ.Text = "CNPJ";
            this.RadioCNPJ.UseVisualStyleBackColor = true;
            // 
            // RadioCPF
            // 
            this.RadioCPF.AutoSize = true;
            this.RadioCPF.Location = new System.Drawing.Point(37, 76);
            this.RadioCPF.Name = "RadioCPF";
            this.RadioCPF.Size = new System.Drawing.Size(45, 17);
            this.RadioCPF.TabIndex = 9;
            this.RadioCPF.TabStop = true;
            this.RadioCPF.Text = "CPF";
            this.RadioCPF.UseVisualStyleBackColor = true;
            // 
            // btnVerifica
            // 
            this.btnVerifica.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVerifica.Location = new System.Drawing.Point(130, 106);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(85, 28);
            this.btnVerifica.TabIndex = 0;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.BtnVerifica_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(37, 50);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(150, 20);
            this.txtDocumento.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite seu CPF ou CNPJ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(277, 202);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valida CPF/CNPJ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton RadioCNPJ;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.RadioButton RadioCPF;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumentoGerado;
        private System.Windows.Forms.RadioButton radioGerarCPF;
        private System.Windows.Forms.RadioButton radioGerarCNPJ;
        private System.Windows.Forms.Button BtnGerador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboEstados;
        private System.Windows.Forms.RadioButton radioTitular;
    }
}

