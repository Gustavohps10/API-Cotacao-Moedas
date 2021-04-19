
namespace API
{
    partial class FrmBitcoin
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
            this.lblBitcoin = new System.Windows.Forms.Label();
            this.lblMstVariacao = new System.Windows.Forms.Label();
            this.lblMstVenda = new System.Windows.Forms.Label();
            this.lblMstCompra = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblVariacao = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBitcoin
            // 
            this.lblBitcoin.BackColor = System.Drawing.Color.Orange;
            this.lblBitcoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitcoin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBitcoin.Location = new System.Drawing.Point(0, 0);
            this.lblBitcoin.Name = "lblBitcoin";
            this.lblBitcoin.Size = new System.Drawing.Size(429, 55);
            this.lblBitcoin.TabIndex = 5;
            this.lblBitcoin.Text = "BITCOIN";
            this.lblBitcoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMstVariacao
            // 
            this.lblMstVariacao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMstVariacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstVariacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMstVariacao.Location = new System.Drawing.Point(165, 190);
            this.lblMstVariacao.Name = "lblMstVariacao";
            this.lblMstVariacao.Size = new System.Drawing.Size(179, 33);
            this.lblMstVariacao.TabIndex = 21;
            this.lblMstVariacao.Text = "0,00";
            this.lblMstVariacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMstVenda
            // 
            this.lblMstVenda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMstVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMstVenda.Location = new System.Drawing.Point(165, 141);
            this.lblMstVenda.Name = "lblMstVenda";
            this.lblMstVenda.Size = new System.Drawing.Size(179, 33);
            this.lblMstVenda.TabIndex = 20;
            this.lblMstVenda.Text = "0,00";
            this.lblMstVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMstCompra
            // 
            this.lblMstCompra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMstCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMstCompra.Location = new System.Drawing.Point(165, 91);
            this.lblMstCompra.Name = "lblMstCompra";
            this.lblMstCompra.Size = new System.Drawing.Size(179, 33);
            this.lblMstCompra.TabIndex = 19;
            this.lblMstCompra.Text = "0,00";
            this.lblMstCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(306, 273);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 34);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblVariacao
            // 
            this.lblVariacao.AutoSize = true;
            this.lblVariacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariacao.Location = new System.Drawing.Point(57, 198);
            this.lblVariacao.Name = "lblVariacao";
            this.lblVariacao.Size = new System.Drawing.Size(80, 20);
            this.lblVariacao.TabIndex = 17;
            this.lblVariacao.Text = "Variação";
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.Location = new System.Drawing.Point(57, 149);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(61, 20);
            this.lblVenda.TabIndex = 16;
            this.lblVenda.Text = "Venda";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.Location = new System.Drawing.Point(57, 99);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(71, 20);
            this.lblCompra.TabIndex = 15;
            this.lblCompra.Text = "Compra";
            // 
            // FrmBitcoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 319);
            this.Controls.Add(this.lblMstVariacao);
            this.Controls.Add(this.lblMstVenda);
            this.Controls.Add(this.lblMstCompra);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblVariacao);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.lblBitcoin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBitcoin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação Bitcoin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBitcoin;
        private System.Windows.Forms.Label lblMstVariacao;
        private System.Windows.Forms.Label lblMstVenda;
        private System.Windows.Forms.Label lblMstCompra;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblVariacao;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lblCompra;
    }
}