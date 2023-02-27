namespace CADASTRO_COMPLETO
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
            this.BtnNovo = new System.Windows.Forms.Button();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExibir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnNovo.Location = new System.Drawing.Point(12, 172);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(89, 36);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // DgvDados
            // 
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Location = new System.Drawing.Point(12, 214);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.Size = new System.Drawing.Size(487, 150);
            this.DgvDados.TabIndex = 1;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtID.Location = new System.Drawing.Point(120, 6);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(150, 31);
            this.TxtID.TabIndex = 2;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblID.Location = new System.Drawing.Point(12, 9);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(38, 25);
            this.LblID.TabIndex = 3;
            this.LblID.Text = "ID:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblNome.Location = new System.Drawing.Point(12, 46);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(74, 25);
            this.LblNome.TabIndex = 5;
            this.LblNome.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtNome.Location = new System.Drawing.Point(120, 43);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(150, 31);
            this.TxtNome.TabIndex = 4;
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblTelefone.Location = new System.Drawing.Point(12, 83);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(102, 25);
            this.LblTelefone.TabIndex = 7;
            this.LblTelefone.Text = "Telefone:";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtTelefone.Location = new System.Drawing.Point(120, 80);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(150, 31);
            this.TxtTelefone.TabIndex = 6;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnEditar.Location = new System.Drawing.Point(107, 172);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(89, 36);
            this.BtnEditar.TabIndex = 8;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExibir
            // 
            this.BtnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnExibir.Location = new System.Drawing.Point(315, 172);
            this.BtnExibir.Name = "BtnExibir";
            this.BtnExibir.Size = new System.Drawing.Size(89, 36);
            this.BtnExibir.TabIndex = 10;
            this.BtnExibir.Text = "Exibir";
            this.BtnExibir.UseVisualStyleBackColor = true;
            this.BtnExibir.Click += new System.EventHandler(this.BtnExibir_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnConsultar.Location = new System.Drawing.Point(202, 172);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(107, 36);
            this.BtnConsultar.TabIndex = 9;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnExcluir.Location = new System.Drawing.Point(410, 172);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(89, 36);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 380);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnExibir);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.DgvDados);
            this.Controls.Add(this.BtnNovo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExibir;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnExcluir;
    }
}

