namespace ProjetoPM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.email = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.paracadastro = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(427, 181);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 0;
            this.email.Text = "Email:";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.BackColor = System.Drawing.Color.Transparent;
            this.senha.ForeColor = System.Drawing.Color.White;
            this.senha.Location = new System.Drawing.Point(427, 270);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(41, 13);
            this.senha.TabIndex = 1;
            this.senha.Text = "Senha:";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.Gold;
            this.btn_entrar.Location = new System.Drawing.Point(663, 363);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(45, 23);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(499, 181);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(359, 20);
            this.txt_email.TabIndex = 4;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(499, 270);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(359, 20);
            this.txt_senha.TabIndex = 5;
            this.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // paracadastro
            // 
            this.paracadastro.AutoSize = true;
            this.paracadastro.LinkColor = System.Drawing.Color.White;
            this.paracadastro.Location = new System.Drawing.Point(634, 418);
            this.paracadastro.Name = "paracadastro";
            this.paracadastro.Size = new System.Drawing.Size(108, 13);
            this.paracadastro.TabIndex = 9;
            this.paracadastro.TabStop = true;
            this.paracadastro.Text = "não possui cadastro?";
            this.paracadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.paracadastro_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(101, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 113);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paracadastro);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.email);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.LinkLabel paracadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

