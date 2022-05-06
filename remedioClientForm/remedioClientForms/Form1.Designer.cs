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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAPI = new System.Windows.Forms.Button();
            this.txtDados = new System.Windows.Forms.RichTextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelInput.SuspendLayout();
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
            this.lblVal1.Location = new System.Drawing.Point(2, 69);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(40, 13);
            this.lblVal1.TabIndex = 1;
            this.lblVal1.Text = "Valor 1";
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Location = new System.Drawing.Point(3, 126);
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
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(3, 20);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 5;
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(2, 86);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(100, 20);
            this.txtVal1.TabIndex = 6;
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(3, 143);
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
            this.btnAPI.Location = new System.Drawing.Point(139, 164);
            this.btnAPI.Name = "btnAPI";
            this.btnAPI.Size = new System.Drawing.Size(97, 23);
            this.btnAPI.TabIndex = 10;
            this.btnAPI.Text = "Chama API";
            this.btnAPI.UseVisualStyleBackColor = true;
            this.btnAPI.Click += new System.EventHandler(this.btnAPI_Click);
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(287, 24);
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(190, 210);
            this.txtDados.TabIndex = 11;
            this.txtDados.Text = "";
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.txtVal2);
            this.panelInput.Controls.Add(this.lblCod);
            this.panelInput.Controls.Add(this.lblVal1);
            this.panelInput.Controls.Add(this.lblVal2);
            this.panelInput.Controls.Add(this.txtCod);
            this.panelInput.Controls.Add(this.txtVal1);
            this.panelInput.Location = new System.Drawing.Point(12, 24);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(116, 186);
            this.panelInput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 246);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.btnAPI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxAcao);
            this.Controls.Add(this.cbxTabela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.ComboBox cbxTabela;
        private System.Windows.Forms.ComboBox cbxAcao;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAPI;
        private System.Windows.Forms.RichTextBox txtDados;
        private System.Windows.Forms.Panel panelInput;
    }
}

