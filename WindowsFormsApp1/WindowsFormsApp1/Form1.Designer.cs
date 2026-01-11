namespace WindowsFormsApp1
{
    partial class buneya
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
            this.etiket = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butonnnn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etiket
            // 
            this.etiket.AutoSize = true;
            this.etiket.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.etiket.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.etiket.Location = new System.Drawing.Point(12, 27);
            this.etiket.Name = "etiket";
            this.etiket.Size = new System.Drawing.Size(103, 24);
            this.etiket.TabIndex = 1;
            this.etiket.Text = "ADI SOYADI";
            this.etiket.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Location = new System.Drawing.Point(139, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butonnnn
            // 
            this.butonnnn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butonnnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonnnn.ForeColor = System.Drawing.Color.IndianRed;
            this.butonnnn.Location = new System.Drawing.Point(148, 53);
            this.butonnnn.Name = "butonnnn";
            this.butonnnn.Size = new System.Drawing.Size(80, 25);
            this.butonnnn.TabIndex = 3;
            this.butonnnn.Text = "KAYDET";
            this.butonnnn.UseVisualStyleBackColor = false;
            this.butonnnn.Click += new System.EventHandler(this.butonnnn_Click);
            // 
            // buneya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(354, 361);
            this.Controls.Add(this.butonnnn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.etiket);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "buneya";
            this.Text = "İLK PROJEM";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.buneya_FormClosed);
            this.Load += new System.EventHandler(this.buneya_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiket;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butonnnn;
    }
}

