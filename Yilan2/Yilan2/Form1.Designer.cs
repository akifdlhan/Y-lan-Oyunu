namespace Yilan2
{
    partial class frm_yilanoyunu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_screen = new System.Windows.Forms.Panel();
            this.tmr_yilanHareket = new System.Windows.Forms.Timer(this.components);
            this.tmr_sure = new System.Windows.Forms.Timer(this.components);
            this.lbl_puan = new System.Windows.Forms.Label();
            this.lbl_puan1 = new System.Windows.Forms.Label();
            this.lbl_sure = new System.Windows.Forms.Label();
            this.lbl_sure1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_screen
            // 
            this.pnl_screen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_screen.Location = new System.Drawing.Point(12, 74);
            this.pnl_screen.Name = "pnl_screen";
            this.pnl_screen.Size = new System.Drawing.Size(527, 319);
            this.pnl_screen.TabIndex = 1;
            this.pnl_screen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tmr_yilanHareket
            // 
            this.tmr_yilanHareket.Tick += new System.EventHandler(this.tmr_yilanHareket_Tick);
            // 
            // tmr_sure
            // 
            this.tmr_sure.Interval = 1000;
            this.tmr_sure.Tick += new System.EventHandler(this.tmr_sure_Tick);
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.BackColor = System.Drawing.Color.Red;
            this.lbl_puan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_puan.Location = new System.Drawing.Point(26, 23);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(43, 16);
            this.lbl_puan.TabIndex = 2;
            this.lbl_puan.Text = "Skor:";
            // 
            // lbl_puan1
            // 
            this.lbl_puan1.AutoSize = true;
            this.lbl_puan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_puan1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_puan1.Location = new System.Drawing.Point(71, 23);
            this.lbl_puan1.Name = "lbl_puan1";
            this.lbl_puan1.Size = new System.Drawing.Size(15, 16);
            this.lbl_puan1.TabIndex = 3;
            this.lbl_puan1.Text = "0";
            // 
            // lbl_sure
            // 
            this.lbl_sure.AutoSize = true;
            this.lbl_sure.BackColor = System.Drawing.Color.Red;
            this.lbl_sure.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_sure.Location = new System.Drawing.Point(26, 55);
            this.lbl_sure.Name = "lbl_sure";
            this.lbl_sure.Size = new System.Drawing.Size(43, 16);
            this.lbl_sure.TabIndex = 4;
            this.lbl_sure.Text = "Süre:";
            // 
            // lbl_sure1
            // 
            this.lbl_sure1.AutoSize = true;
            this.lbl_sure1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_sure1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_sure1.Location = new System.Drawing.Point(71, 55);
            this.lbl_sure1.Name = "lbl_sure1";
            this.lbl_sure1.Size = new System.Drawing.Size(15, 16);
            this.lbl_sure1.TabIndex = 5;
            this.lbl_sure1.Text = "0";
            this.lbl_sure1.Click += new System.EventHandler(this.lbl_sure1_Click);
            // 
            // frm_yilanoyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 405);
            this.Controls.Add(this.lbl_sure1);
            this.Controls.Add(this.lbl_sure);
            this.Controls.Add(this.lbl_puan1);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.pnl_screen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_yilanoyunu";
            this.Text = "Yılan oyunu";
            this.Load += new System.EventHandler(this.frm_yilanoyunu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_yilanoyunu_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_screen;
        private System.Windows.Forms.Timer tmr_yilanHareket;
        private System.Windows.Forms.Timer tmr_sure;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Label lbl_puan1;
        private System.Windows.Forms.Label lbl_sure;
        private System.Windows.Forms.Label lbl_sure1;
    }
}

