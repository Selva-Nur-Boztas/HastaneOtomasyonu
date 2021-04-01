
namespace HastaneOtomasyonu
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btn_hasta = new System.Windows.Forms.Button();
            this.btn_doktor = new System.Windows.Forms.Button();
            this.btn_sekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hasta
            // 
            this.btn_hasta.BackColor = System.Drawing.Color.White;
            this.btn_hasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hasta.BackgroundImage")));
            this.btn_hasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hasta.Location = new System.Drawing.Point(42, 157);
            this.btn_hasta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hasta.Name = "btn_hasta";
            this.btn_hasta.Size = new System.Drawing.Size(119, 89);
            this.btn_hasta.TabIndex = 0;
            this.btn_hasta.UseVisualStyleBackColor = false;
            this.btn_hasta.Click += new System.EventHandler(this.btn_hasta_Click);
            // 
            // btn_doktor
            // 
            this.btn_doktor.BackColor = System.Drawing.Color.Gray;
            this.btn_doktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doktor.BackgroundImage")));
            this.btn_doktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doktor.Location = new System.Drawing.Point(213, 157);
            this.btn_doktor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_doktor.Name = "btn_doktor";
            this.btn_doktor.Size = new System.Drawing.Size(119, 89);
            this.btn_doktor.TabIndex = 1;
            this.btn_doktor.UseVisualStyleBackColor = false;
            this.btn_doktor.Click += new System.EventHandler(this.btn_doktor_Click);
            // 
            // btn_sekreter
            // 
            this.btn_sekreter.BackColor = System.Drawing.Color.Transparent;
            this.btn_sekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sekreter.BackgroundImage")));
            this.btn_sekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sekreter.Location = new System.Drawing.Point(382, 157);
            this.btn_sekreter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sekreter.Name = "btn_sekreter";
            this.btn_sekreter.Size = new System.Drawing.Size(119, 89);
            this.btn_sekreter.TabIndex = 2;
            this.btn_sekreter.UseVisualStyleBackColor = false;
            this.btn_sekreter.Click += new System.EventHandler(this.btn_sekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 51);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hayat Hastanesi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(546, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sekreter);
            this.Controls.Add(this.btn_doktor);
            this.Controls.Add(this.btn_hasta);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hayat Hastanesi Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hasta;
        private System.Windows.Forms.Button btn_doktor;
        private System.Windows.Forms.Button btn_sekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

