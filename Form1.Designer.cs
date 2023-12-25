namespace WindowsFormsApp1
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
            this.pictureBox_bird = new System.Windows.Forms.PictureBox();
            this.pictureBox_top = new System.Windows.Forms.PictureBox();
            this.pictureBox_bottom = new System.Windows.Forms.PictureBox();
            this.pictureBox_ground = new System.Windows.Forms.PictureBox();
            this.timer_gAMEcONTROL = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_bird
            // 
            this.pictureBox_bird.Image = global::WindowsFormsApp1.Properties.Resources.indir;
            this.pictureBox_bird.Location = new System.Drawing.Point(396, 244);
            this.pictureBox_bird.Name = "pictureBox_bird";
            this.pictureBox_bird.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bird.TabIndex = 0;
            this.pictureBox_bird.TabStop = false;
            // 
            // pictureBox_top
            // 
            this.pictureBox_top.Image = global::WindowsFormsApp1.Properties.Resources.boru;
            this.pictureBox_top.Location = new System.Drawing.Point(957, -4);
            this.pictureBox_top.Name = "pictureBox_top";
            this.pictureBox_top.Size = new System.Drawing.Size(60, 122);
            this.pictureBox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_top.TabIndex = 1;
            this.pictureBox_top.TabStop = false;
            // 
            // pictureBox_bottom
            // 
            this.pictureBox_bottom.Image = global::WindowsFormsApp1.Properties.Resources.boru2;
            this.pictureBox_bottom.Location = new System.Drawing.Point(691, 428);
            this.pictureBox_bottom.Name = "pictureBox_bottom";
            this.pictureBox_bottom.Size = new System.Drawing.Size(61, 126);
            this.pictureBox_bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bottom.TabIndex = 2;
            this.pictureBox_bottom.TabStop = false;
            // 
            // pictureBox_ground
            // 
            this.pictureBox_ground.Image = global::WindowsFormsApp1.Properties.Resources.fb_4;
            this.pictureBox_ground.Location = new System.Drawing.Point(0, 550);
            this.pictureBox_ground.Name = "pictureBox_ground";
            this.pictureBox_ground.Size = new System.Drawing.Size(1350, 178);
            this.pictureBox_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ground.TabIndex = 3;
            this.pictureBox_ground.TabStop = false;
            // 
            // timer_gAMEcONTROL
            // 
            this.timer_gAMEcONTROL.Enabled = true;
            this.timer_gAMEcONTROL.Interval = 20;
            this.timer_gAMEcONTROL.Tick += new System.EventHandler(this.GameTimer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-9, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1347, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_ground);
            this.Controls.Add(this.pictureBox_bottom);
            this.Controls.Add(this.pictureBox_top);
            this.Controls.Add(this.pictureBox_bird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_bird;
        private System.Windows.Forms.PictureBox pictureBox_top;
        private System.Windows.Forms.PictureBox pictureBox_bottom;
        private System.Windows.Forms.PictureBox pictureBox_ground;
        private System.Windows.Forms.Timer timer_gAMEcONTROL;
        private System.Windows.Forms.Label label1;
    }
}

