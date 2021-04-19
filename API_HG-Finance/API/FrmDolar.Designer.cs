
namespace API
{
    partial class FrmDolar
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
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblVariacao = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblMstCompra = new System.Windows.Forms.Label();
            this.lblMstVenda = new System.Windows.Forms.Label();
            this.lblMstVariacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.Location = new System.Drawing.Point(53, 95);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(71, 20);
            this.lblCompra.TabIndex = 0;
            this.lblCompra.Text = "Compra";
            this.lblCompra.Click += new System.EventHandler(this.lblCompra_Click);
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.Location = new System.Drawing.Point(53, 145);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(61, 20);
            this.lblVenda.TabIndex = 1;
            this.lblVenda.Text = "Venda";
            this.lblVenda.Click += new System.EventHandler(this.lblVenda_Click);
            // 
            // lblVariacao
            // 
            this.lblVariacao.AutoSize = true;
            this.lblVariacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariacao.Location = new System.Drawing.Point(53, 194);
            this.lblVariacao.Name = "lblVariacao";
            this.lblVariacao.Size = new System.Drawing.Size(80, 20);
            this.lblVariacao.TabIndex = 2;
            this.lblVariacao.Text = "Variação";
            this.lblVariacao.Click += new System.EventHandler(this.lblVariacao_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.BackColor = System.Drawing.Color.ForestGreen;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDolar.Location = new System.Drawing.Point(0, 0);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(429, 55);
            this.lblDolar.TabIndex = 3;
            this.lblDolar.Text = "DÓLAR";
            this.lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(302, 269);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 34);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblMstCompra
            // 
            this.lblMstCompra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMstCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMstCompra.Location = new System.Drawing.Point(161, 87);
            this.lblMstCompra.Name = "lblMstCompra";
            this.lblMstCompra.Size = new System.Drawing.Size(179, 33);
            this.lblMstCompra.TabIndex = 5;
            this.lblMstCompra.Text = "0,00";
            this.lblMstCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMstCompra.Click += new System.EventHandler(this.lblMstCompra_Click);
            // 
            // lblMstVenda
            // 
            this.lblMstVenda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMstVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMstVenda.Location = new System.Drawing.Point(161, 137);
            this.lblMstVenda.Name = "lblMstVenda";
            this.lblMstVenda.Size = new System.Drawing.Size(179, 33);
            this.lblMstVenda.TabIndex = 6;
            this.lblMstVenda.Text = "0,00";
            this.lblMstVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMstVenda.Click += new System.EventHandler(this.lblMstVenda_Click);
            // 
            // lblMstVariacao
            // 
            this.lblMstVariacao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMstVariacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstVariacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMstVariacao.Location = new System.Drawing.Point(161, 186);
            this.lblMstVariacao.Name = "lblMstVariacao";
            this.lblMstVariacao.Size = new System.Drawing.Size(179, 33);
            this.lblMstVariacao.TabIndex = 7;
            this.lblMstVariacao.Text = "0,00";
            this.lblMstVariacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMstVariacao.Click += new System.EventHandler(this.lblMstVariacao_Click);
            // 
            // FrmDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 315);
            this.Controls.Add(this.lblMstVariacao);
            this.Controls.Add(this.lblMstVenda);
            this.Controls.Add(this.lblMstCompra);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblVariacao);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.lblCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação Dólar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lblVariacao;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblMstCompra;
        private System.Windows.Forms.Label lblMstVenda;
        private System.Windows.Forms.Label lblMstVariacao;
    }
}

