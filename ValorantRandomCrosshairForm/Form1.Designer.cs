
namespace ValorantRandomCrosshairForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.anacizgikalinlik = new System.Windows.Forms.Label();
            this.anacizgisaydam = new System.Windows.Forms.Label();
            this.anacizgi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nokta = new System.Windows.Forms.Label();
            this.noktasaydam = new System.Windows.Forms.Label();
            this.noktakalin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.iccizgi = new System.Windows.Forms.Label();
            this.iccizgisaydam = new System.Windows.Forms.Label();
            this.iccizgiuzun = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.iccizgikalin = new System.Windows.Forms.Label();
            this.iccizgiuzaklik = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.discizgikalin = new System.Windows.Forms.Label();
            this.discizgiuzaklik = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.discizgi = new System.Windows.Forms.Label();
            this.discizgisaydam = new System.Windows.Forms.Label();
            this.discizgiuzun = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ana Çizgi Açık/Kapalı : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.anacizgi);
            this.groupBox1.Controls.Add(this.anacizgisaydam);
            this.groupBox1.Controls.Add(this.anacizgikalinlik);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ana Çizgi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saydamlık : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalınlık : ";
            // 
            // anacizgikalinlik
            // 
            this.anacizgikalinlik.AutoSize = true;
            this.anacizgikalinlik.Location = new System.Drawing.Point(97, 126);
            this.anacizgikalinlik.Name = "anacizgikalinlik";
            this.anacizgikalinlik.Size = new System.Drawing.Size(22, 28);
            this.anacizgikalinlik.TabIndex = 3;
            this.anacizgikalinlik.Text = "0";
            // 
            // anacizgisaydam
            // 
            this.anacizgisaydam.AutoSize = true;
            this.anacizgisaydam.Location = new System.Drawing.Point(125, 82);
            this.anacizgisaydam.Name = "anacizgisaydam";
            this.anacizgisaydam.Size = new System.Drawing.Size(22, 28);
            this.anacizgisaydam.TabIndex = 4;
            this.anacizgisaydam.Text = "0";
            // 
            // anacizgi
            // 
            this.anacizgi.AutoSize = true;
            this.anacizgi.Location = new System.Drawing.Point(212, 38);
            this.anacizgi.Name = "anacizgi";
            this.anacizgi.Size = new System.Drawing.Size(21, 28);
            this.anacizgi.TabIndex = 5;
            this.anacizgi.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nokta);
            this.groupBox2.Controls.Add(this.noktasaydam);
            this.groupBox2.Controls.Add(this.noktakalin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(514, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 179);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nokta";
            // 
            // nokta
            // 
            this.nokta.AutoSize = true;
            this.nokta.Location = new System.Drawing.Point(184, 38);
            this.nokta.Name = "nokta";
            this.nokta.Size = new System.Drawing.Size(21, 28);
            this.nokta.TabIndex = 5;
            this.nokta.Text = "-";
            // 
            // noktasaydam
            // 
            this.noktasaydam.AutoSize = true;
            this.noktasaydam.Location = new System.Drawing.Point(125, 82);
            this.noktasaydam.Name = "noktasaydam";
            this.noktasaydam.Size = new System.Drawing.Size(22, 28);
            this.noktasaydam.TabIndex = 4;
            this.noktasaydam.Text = "0";
            // 
            // noktakalin
            // 
            this.noktakalin.AutoSize = true;
            this.noktakalin.Location = new System.Drawing.Point(97, 126);
            this.noktakalin.Name = "noktakalin";
            this.noktakalin.Size = new System.Drawing.Size(22, 28);
            this.noktakalin.TabIndex = 3;
            this.noktakalin.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "Kalınlık : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Saydamlık : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nokta Açık/Kapalı : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.iccizgikalin);
            this.groupBox4.Controls.Add(this.iccizgiuzaklik);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.iccizgi);
            this.groupBox4.Controls.Add(this.iccizgisaydam);
            this.groupBox4.Controls.Add(this.iccizgiuzun);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(37, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 288);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İç Çizgi";
            // 
            // iccizgi
            // 
            this.iccizgi.AutoSize = true;
            this.iccizgi.Location = new System.Drawing.Point(184, 38);
            this.iccizgi.Name = "iccizgi";
            this.iccizgi.Size = new System.Drawing.Size(21, 28);
            this.iccizgi.TabIndex = 5;
            this.iccizgi.Text = "-";
            // 
            // iccizgisaydam
            // 
            this.iccizgisaydam.AutoSize = true;
            this.iccizgisaydam.Location = new System.Drawing.Point(125, 82);
            this.iccizgisaydam.Name = "iccizgisaydam";
            this.iccizgisaydam.Size = new System.Drawing.Size(22, 28);
            this.iccizgisaydam.TabIndex = 4;
            this.iccizgisaydam.Text = "0";
            // 
            // iccizgiuzun
            // 
            this.iccizgiuzun.AutoSize = true;
            this.iccizgiuzun.Location = new System.Drawing.Point(97, 138);
            this.iccizgiuzun.Name = "iccizgiuzun";
            this.iccizgiuzun.Size = new System.Drawing.Size(22, 28);
            this.iccizgiuzun.TabIndex = 3;
            this.iccizgiuzun.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 138);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 28);
            this.label22.TabIndex = 2;
            this.label22.Text = "Uzunluk : ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 28);
            this.label23.TabIndex = 1;
            this.label23.Text = "Saydamlık : ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 38);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(175, 28);
            this.label24.TabIndex = 0;
            this.label24.Text = "İç Çizgi Açık/Kapalı : ";
            // 
            // iccizgikalin
            // 
            this.iccizgikalin.AutoSize = true;
            this.iccizgikalin.Location = new System.Drawing.Point(97, 194);
            this.iccizgikalin.Name = "iccizgikalin";
            this.iccizgikalin.Size = new System.Drawing.Size(22, 28);
            this.iccizgikalin.TabIndex = 9;
            this.iccizgikalin.Text = "0";
            // 
            // iccizgiuzaklik
            // 
            this.iccizgiuzaklik.AutoSize = true;
            this.iccizgiuzaklik.Location = new System.Drawing.Point(97, 250);
            this.iccizgiuzaklik.Name = "iccizgiuzaklik";
            this.iccizgiuzaklik.Size = new System.Drawing.Size(22, 28);
            this.iccizgiuzaklik.TabIndex = 8;
            this.iccizgiuzaklik.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(13, 250);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 28);
            this.label27.TabIndex = 7;
            this.label27.Text = "Uzaklık : ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(13, 194);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 28);
            this.label28.TabIndex = 6;
            this.label28.Text = "Kalınlık : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.discizgikalin);
            this.groupBox3.Controls.Add(this.discizgiuzaklik);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.discizgi);
            this.groupBox3.Controls.Add(this.discizgisaydam);
            this.groupBox3.Controls.Add(this.discizgiuzun);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Location = new System.Drawing.Point(514, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 288);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dış Çizgi";
            // 
            // discizgikalin
            // 
            this.discizgikalin.AutoSize = true;
            this.discizgikalin.Location = new System.Drawing.Point(97, 194);
            this.discizgikalin.Name = "discizgikalin";
            this.discizgikalin.Size = new System.Drawing.Size(22, 28);
            this.discizgikalin.TabIndex = 9;
            this.discizgikalin.Text = "0";
            // 
            // discizgiuzaklik
            // 
            this.discizgiuzaklik.AutoSize = true;
            this.discizgiuzaklik.Location = new System.Drawing.Point(97, 250);
            this.discizgiuzaklik.Name = "discizgiuzaklik";
            this.discizgiuzaklik.Size = new System.Drawing.Size(22, 28);
            this.discizgiuzaklik.TabIndex = 8;
            this.discizgiuzaklik.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 28);
            this.label15.TabIndex = 7;
            this.label15.Text = "Uzaklık : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 28);
            this.label16.TabIndex = 6;
            this.label16.Text = "Kalınlık : ";
            // 
            // discizgi
            // 
            this.discizgi.AutoSize = true;
            this.discizgi.Location = new System.Drawing.Point(194, 38);
            this.discizgi.Name = "discizgi";
            this.discizgi.Size = new System.Drawing.Size(21, 28);
            this.discizgi.TabIndex = 5;
            this.discizgi.Text = "-";
            // 
            // discizgisaydam
            // 
            this.discizgisaydam.AutoSize = true;
            this.discizgisaydam.Location = new System.Drawing.Point(125, 82);
            this.discizgisaydam.Name = "discizgisaydam";
            this.discizgisaydam.Size = new System.Drawing.Size(22, 28);
            this.discizgisaydam.TabIndex = 4;
            this.discizgisaydam.Text = "0";
            // 
            // discizgiuzun
            // 
            this.discizgiuzun.AutoSize = true;
            this.discizgiuzun.Location = new System.Drawing.Point(97, 138);
            this.discizgiuzun.Name = "discizgiuzun";
            this.discizgiuzun.Size = new System.Drawing.Size(22, 28);
            this.discizgiuzun.TabIndex = 3;
            this.discizgiuzun.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(13, 138);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 28);
            this.label30.TabIndex = 2;
            this.label30.Text = "Uzunluk : ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(13, 82);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(106, 28);
            this.label31.TabIndex = 1;
            this.label31.Text = "Saydamlık : ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(13, 38);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(184, 28);
            this.label32.TabIndex = 0;
            this.label32.Text = "Dış Çizgi Açık/Kapalı : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(37, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(835, 78);
            this.button1.TabIndex = 11;
            this.button1.Text = "RANDOM CROSSHAIR AYARLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(894, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label anacizgi;
        private System.Windows.Forms.Label anacizgisaydam;
        private System.Windows.Forms.Label anacizgikalinlik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label nokta;
        private System.Windows.Forms.Label noktasaydam;
        private System.Windows.Forms.Label noktakalin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label iccizgikalin;
        private System.Windows.Forms.Label iccizgiuzaklik;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label iccizgi;
        private System.Windows.Forms.Label iccizgisaydam;
        private System.Windows.Forms.Label iccizgiuzun;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label discizgikalin;
        private System.Windows.Forms.Label discizgiuzaklik;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label discizgi;
        private System.Windows.Forms.Label discizgisaydam;
        private System.Windows.Forms.Label discizgiuzun;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button button1;
    }
}

