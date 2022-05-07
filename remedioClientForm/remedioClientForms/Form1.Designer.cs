namespace remedioClientForms
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
            this.lblCod = new System.Windows.Forms.Label();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.cbxTabela = new System.Windows.Forms.ComboBox();
            this.cbxAcao = new System.Windows.Forms.ComboBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAPI = new System.Windows.Forms.Button();
            this.txtDados = new System.Windows.Forms.RichTextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelValor = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.NumericUpDown();
            this.panelInput.SuspendLayout();
            this.panelValor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(3, 3);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código";
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Location = new System.Drawing.Point(2, 20);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(40, 13);
            this.lblVal1.TabIndex = 1;
            this.lblVal1.Text = "Valor 1";
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Location = new System.Drawing.Point(3, 77);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(40, 13);
            this.lblVal2.TabIndex = 2;
            this.lblVal2.Text = "Valor 2";
            // 
            // cbxTabela
            // 
            this.cbxTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTabela.FormattingEnabled = true;
            this.cbxTabela.Items.AddRange(new object[] {
            "Remedio",
            "Efeitos Colaterais",
            "Relações remedios e efeitos"});
            this.cbxTabela.Location = new System.Drawing.Point(139, 43);
            this.cbxTabela.Name = "cbxTabela";
            this.cbxTabela.Size = new System.Drawing.Size(121, 21);
            this.cbxTabela.TabIndex = 3;
            this.cbxTabela.SelectedIndexChanged += new System.EventHandler(this.cbxTabela_SelectedIndexChanged);
            // 
            // cbxAcao
            // 
            this.cbxAcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAcao.Enabled = false;
            this.cbxAcao.FormattingEnabled = true;
            this.cbxAcao.Items.AddRange(new object[] {
            "Post",
            "Put",
            "Get",
            "Delete",
            "Get all"});
            this.cbxAcao.Location = new System.Drawing.Point(139, 109);
            this.cbxAcao.Name = "cbxAcao";
            this.cbxAcao.Size = new System.Drawing.Size(121, 21);
            this.cbxAcao.TabIndex = 4;
            this.cbxAcao.SelectedIndexChanged += new System.EventHandler(this.cbxAcao_SelectedIndexChanged);
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(2, 37);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(100, 20);
            this.txtVal1.TabIndex = 6;
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(3, 94);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(100, 20);
            this.txtVal2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tabela";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ação";
            // 
            // btnAPI
            // 
            this.btnAPI.Enabled = false;
            this.btnAPI.Location = new System.Drawing.Point(139, 187);
            this.btnAPI.Name = "btnAPI";
            this.btnAPI.Size = new System.Drawing.Size(97, 23);
            this.btnAPI.TabIndex = 10;
            this.btnAPI.Text = "Chama API";
            this.btnAPI.UseVisualStyleBackColor = true;
            this.btnAPI.Click += new System.EventHandler(this.btnAPI_Click);
            // 
            // txtDados
            // 
            this.txtDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDados.Location = new System.Drawing.Point(284, 24);
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(250, 210);
            this.txtDados.TabIndex = 11;
            this.txtDados.Text = "";
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.txtCodigo);
            this.panelInput.Controls.Add(this.panelValor);
            this.panelInput.Controls.Add(this.lblCod);
            this.panelInput.Enabled = false;
            this.panelInput.Location = new System.Drawing.Point(12, 24);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(116, 186);
            this.panelInput.TabIndex = 12;
            this.panelInput.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInput_Paint);
            // 
            // panelValor
            // 
            this.panelValor.Controls.Add(this.txtVal2);
            this.panelValor.Controls.Add(this.txtVal1);
            this.panelValor.Controls.Add(this.lblVal2);
            this.panelValor.Controls.Add(this.lblVal1);
            this.panelValor.Location = new System.Drawing.Point(3, 46);
            this.panelValor.Name = "panelValor";
            this.panelValor.Size = new System.Drawing.Size(110, 137);
            this.panelValor.TabIndex = 13;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(139, 161);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(139, 20);
            this.txtUrl.TabIndex = 13;
            this.txtUrl.Text = "http://localhost:56236/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Endereço base";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(5, 19);
            this.txtCodigo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(108, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.btnAPI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxAcao);
            this.Controls.Add(this.cbxTabela);
            this.Name = "Form1";
            this.Text = "Client";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelValor.ResumeLayout(false);
            this.panelValor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.ComboBox cbxTabela;
        private System.Windows.Forms.ComboBox cbxAcao;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAPI;
        private System.Windows.Forms.RichTextBox txtDados;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelValor;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtCodigo;
    }
}

