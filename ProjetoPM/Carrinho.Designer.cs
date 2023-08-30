namespace ProjetoPM
{
    partial class Carrinho
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
            this.FinCompra = new System.Windows.Forms.Button();
            this.pcarrinho = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FinCompra
            // 
            this.FinCompra.Location = new System.Drawing.Point(798, 415);
            this.FinCompra.Name = "FinCompra";
            this.FinCompra.Size = new System.Drawing.Size(164, 23);
            this.FinCompra.TabIndex = 0;
            this.FinCompra.Text = "Finalizar Compra";
            this.FinCompra.UseVisualStyleBackColor = true;
            // 
            // pcarrinho
            // 
            this.pcarrinho.Location = new System.Drawing.Point(25, 41);
            this.pcarrinho.Name = "pcarrinho";
            this.pcarrinho.Size = new System.Drawing.Size(560, 121);
            this.pcarrinho.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pcarrinho);
            this.Controls.Add(this.FinCompra);
            this.Name = "Carrinho";
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.Carrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FinCompra;
        private System.Windows.Forms.Panel pcarrinho;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}