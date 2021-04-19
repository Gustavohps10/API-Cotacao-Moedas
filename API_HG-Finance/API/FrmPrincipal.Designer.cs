
namespace API
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ImgEuro = new System.Windows.Forms.PictureBox();
            this.ImgDolar = new System.Windows.Forms.PictureBox();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDolar)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgEuro
            // 
            this.ImgEuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgEuro.Image = ((System.Drawing.Image)(resources.GetObject("ImgEuro.Image")));
            this.ImgEuro.Location = new System.Drawing.Point(265, 51);
            this.ImgEuro.Name = "ImgEuro";
            this.ImgEuro.Size = new System.Drawing.Size(150, 150);
            this.ImgEuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgEuro.TabIndex = 0;
            this.ImgEuro.TabStop = false;
            this.ImgEuro.Click += new System.EventHandler(this.ImgEuro_Click);
            // 
            // ImgDolar
            // 
            this.ImgDolar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgDolar.Image = global::API.Properties.Resources.dolar;
            this.ImgDolar.Location = new System.Drawing.Point(48, 51);
            this.ImgDolar.Name = "ImgDolar";
            this.ImgDolar.Size = new System.Drawing.Size(150, 150);
            this.ImgDolar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgDolar.TabIndex = 1;
            this.ImgDolar.TabStop = false;
            this.ImgDolar.Click += new System.EventHandler(this.ImgDolar_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(62, 215);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(124, 20);
            this.lblDolar.TabIndex = 2;
            this.lblDolar.Text = "Cotação Dólar";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(280, 215);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(119, 20);
            this.lblEuro.TabIndex = 3;
            this.lblEuro.Text = "Cotação Euro";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(396, 296);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 331);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.ImgDolar);
            this.Controls.Add(this.ImgEuro);
            this.Name = "FrmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação de Moedas";
            ((System.ComponentModel.ISupportInitialize)(this.ImgEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgEuro;
        private System.Windows.Forms.PictureBox ImgDolar;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Button btnSair;
    }
}