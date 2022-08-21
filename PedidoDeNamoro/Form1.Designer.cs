
namespace PedidoDeNamoro
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
            this.lbl_frase = new System.Windows.Forms.Label();
            this.btn_sim = new System.Windows.Forms.Button();
            this.btn_nao = new System.Windows.Forms.Button();
            this.pbx_coracao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_coracao)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_frase
            // 
            this.lbl_frase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_frase.AutoSize = true;
            this.lbl_frase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lbl_frase.Location = new System.Drawing.Point(108, 43);
            this.lbl_frase.Name = "lbl_frase";
            this.lbl_frase.Size = new System.Drawing.Size(206, 24);
            this.lbl_frase.TabIndex = 3;
            this.lbl_frase.Text = "Quer namorar comigo?";
            // 
            // btn_sim
            // 
            this.btn_sim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btn_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_sim.Location = new System.Drawing.Point(44, 263);
            this.btn_sim.Name = "btn_sim";
            this.btn_sim.Size = new System.Drawing.Size(129, 39);
            this.btn_sim.TabIndex = 4;
            this.btn_sim.Text = "Sim";
            this.btn_sim.UseVisualStyleBackColor = false;
            this.btn_sim.Click += new System.EventHandler(this.btn_sim_Click);
            // 
            // btn_nao
            // 
            this.btn_nao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btn_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_nao.Location = new System.Drawing.Point(250, 264);
            this.btn_nao.Name = "btn_nao";
            this.btn_nao.Size = new System.Drawing.Size(129, 38);
            this.btn_nao.TabIndex = 5;
            this.btn_nao.Text = "Não";
            this.btn_nao.UseVisualStyleBackColor = false;
            this.btn_nao.Click += new System.EventHandler(this.btn_nao_Click);
            // 
            // pbx_coracao
            // 
            this.pbx_coracao.Image = global::PedidoDeNamoro.Properties.Resources.coração;
            this.pbx_coracao.Location = new System.Drawing.Point(80, 85);
            this.pbx_coracao.Name = "pbx_coracao";
            this.pbx_coracao.Size = new System.Drawing.Size(271, 232);
            this.pbx_coracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_coracao.TabIndex = 6;
            this.pbx_coracao.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(442, 408);
            this.Controls.Add(this.btn_nao);
            this.Controls.Add(this.btn_sim);
            this.Controls.Add(this.pbx_coracao);
            this.Controls.Add(this.lbl_frase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Namoro";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_coracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_frase;
        private System.Windows.Forms.Button btn_sim;
        private System.Windows.Forms.Button btn_nao;
        private System.Windows.Forms.PictureBox pbx_coracao;
    }
}

