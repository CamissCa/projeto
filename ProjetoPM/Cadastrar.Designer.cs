namespace ProjetoPM
{
    partial class cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrar));
            this.label1 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.textgmail = new System.Windows.Forms.TextBox();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttoncad = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(436, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(480, 212);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(419, 20);
            this.textname.TabIndex = 1;
            this.textname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textname.TextChanged += new System.EventHandler(this.textname_TextChanged);
            // 
            // textgmail
            // 
            this.textgmail.Location = new System.Drawing.Point(480, 294);
            this.textgmail.Name = "textgmail";
            this.textgmail.Size = new System.Drawing.Size(419, 20);
            this.textgmail.TabIndex = 2;
            this.textgmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textgmail.TextChanged += new System.EventHandler(this.textgmail_TextChanged);
            // 
            // textsenha
            // 
            this.textsenha.Location = new System.Drawing.Point(480, 381);
            this.textsenha.Name = "textsenha";
            this.textsenha.PasswordChar = '*';
            this.textsenha.Size = new System.Drawing.Size(419, 20);
            this.textsenha.TabIndex = 3;
            this.textsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textsenha.TextChanged += new System.EventHandler(this.textsenha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(436, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "gmail:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(436, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "senha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttoncad
            // 
            this.buttoncad.BackColor = System.Drawing.Color.Yellow;
            this.buttoncad.Location = new System.Drawing.Point(627, 491);
            this.buttoncad.Name = "buttoncad";
            this.buttoncad.Size = new System.Drawing.Size(113, 23);
            this.buttoncad.TabIndex = 6;
            this.buttoncad.Text = "terminar cadastro";
            this.buttoncad.UseVisualStyleBackColor = false;
            this.buttoncad.Click += new System.EventHandler(this.buttoncad_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cliente",
            "vendedor"});
            this.comboBox1.Location = new System.Drawing.Point(601, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "usuário";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(184, 143);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "voltar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1265, 650);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttoncad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textsenha);
            this.Controls.Add(this.textgmail);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label1);
            this.Name = "cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textgmail;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttoncad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}