namespace Top_SEktirme_Oyunu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_BASLA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.top = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_BASLA
            // 
            this.BTN_BASLA.Location = new System.Drawing.Point(56, 146);
            this.BTN_BASLA.Name = "BTN_BASLA";
            this.BTN_BASLA.Size = new System.Drawing.Size(254, 72);
            this.BTN_BASLA.TabIndex = 0;
            this.BTN_BASLA.Text = "BASLA";
            this.BTN_BASLA.UseVisualStyleBackColor = true;
            this.BTN_BASLA.Click += new System.EventHandler(this.BTN_BASLA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "DURDUR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 431);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(803, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tahmin Et Kaç Defa Top Sekecek?";
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Transparent;
            this.top.Image = ((System.Drawing.Image)(resources.GetObject("top.Image")));
            this.top.Location = new System.Drawing.Point(658, 190);
            this.top.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(96, 98);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 4;
            this.top.TabStop = false;
            this.top.Click += new System.EventHandler(this.top_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sektirilen Top Sayısı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1067, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1067, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1327, 603);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.top);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_BASLA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_BASLA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

