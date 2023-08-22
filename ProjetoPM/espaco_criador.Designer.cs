namespace ProjetoPM
{
    partial class espaco_criador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(espaco_criador));
            this.anunciar = new System.Windows.Forms.Button();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.btnfoto = new System.Windows.Forms.Button();
            this.lblfoto = new System.Windows.Forms.Label();
            this.ptbfoto = new System.Windows.Forms.PictureBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.text_preco = new System.Windows.Forms.TextBox();
            this.text_descricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // anunciar
            // 
            this.anunciar.Location = new System.Drawing.Point(662, 604);
            this.anunciar.Name = "anunciar";
            this.anunciar.Size = new System.Drawing.Size(75, 23);
            this.anunciar.TabIndex = 0;
            this.anunciar.Text = "anúnciar";
            this.anunciar.UseVisualStyleBackColor = true;
            this.anunciar.Click += new System.EventHandler(this.anunciar_Click);
            // 
            // TxtProduto
            // 
            this.TxtProduto.Location = new System.Drawing.Point(552, 437);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(287, 20);
            this.TxtProduto.TabIndex = 1;
            this.TxtProduto.Text = "insira o nome de seu produto...";
            this.TxtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtProduto.TextChanged += new System.EventHandler(this.TxtProduto_TextChanged);
            // 
            // btnfoto
            // 
            this.btnfoto.Location = new System.Drawing.Point(662, 393);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(75, 23);
            this.btnfoto.TabIndex = 3;
            this.btnfoto.Text = "importar foto";
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // lblfoto
            // 
            this.lblfoto.AutoSize = true;
            this.lblfoto.Location = new System.Drawing.Point(677, 366);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(35, 13);
            this.lblfoto.TabIndex = 4;
            this.lblfoto.Text = "label1";
            this.lblfoto.Click += new System.EventHandler(this.lblfoto_Click);
            // 
            // ptbfoto
            // 
            this.ptbfoto.BackColor = System.Drawing.Color.Azure;
            this.ptbfoto.Location = new System.Drawing.Point(517, 48);
            this.ptbfoto.Name = "ptbfoto";
            this.ptbfoto.Size = new System.Drawing.Size(361, 300);
            this.ptbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbfoto.TabIndex = 5;
            this.ptbfoto.TabStop = false;
            this.ptbfoto.Click += new System.EventHandler(this.ptbfoto_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(108, 202);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // text_preco
            // 
            this.text_preco.Location = new System.Drawing.Point(646, 549);
            this.text_preco.Name = "text_preco";
            this.text_preco.Size = new System.Drawing.Size(100, 20);
            this.text_preco.TabIndex = 7;
            this.text_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_preco.TextChanged += new System.EventHandler(this.text_preco_TextChanged);
            // 
            // text_descricao
            // 
            this.text_descricao.Location = new System.Drawing.Point(552, 487);
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.Size = new System.Drawing.Size(287, 20);
            this.text_descricao.TabIndex = 8;
            this.text_descricao.Text = "descreva o produto";
            this.text_descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_descricao.TextChanged += new System.EventHandler(this.text_descricao_TextChanged);
            // 
            // espaco_criador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 713);
            this.Controls.Add(this.text_descricao);
            this.Controls.Add(this.text_preco);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.ptbfoto);
            this.Controls.Add(this.lblfoto);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.TxtProduto);
            this.Controls.Add(this.anunciar);
            this.Name = "espaco_criador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "espaco_criador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.espaco_criador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anunciar;
        private System.Windows.Forms.TextBox TxtProduto;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.Label lblfoto;
        private System.Windows.Forms.PictureBox ptbfoto;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox text_preco;
        private System.Windows.Forms.TextBox text_descricao;
    }
}