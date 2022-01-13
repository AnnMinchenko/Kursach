
namespace Kursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tb_ParticlesCount = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.tb_pfish = new System.Windows.Forms.TrackBar();
            this.tb_yfish = new System.Windows.Forms.TrackBar();
            this.tb_bfish = new System.Windows.Forms.TrackBar();
            this.lbl_yfish = new System.Windows.Forms.Label();
            this.lbl_pfish = new System.Windows.Forms.Label();
            this.lbl_bfish = new System.Windows.Forms.Label();
            this.lbl_ = new System.Windows.Forms.Label();
            this.tb_ygravity = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pgravity = new System.Windows.Forms.TrackBar();
            this.tb_bgravity = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ParticlesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pfish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_yfish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bfish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ygravity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pgravity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bgravity)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tb_ParticlesCount
            // 
            this.tb_ParticlesCount.Location = new System.Drawing.Point(1244, 167);
            this.tb_ParticlesCount.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ParticlesCount.Maximum = 20;
            this.tb_ParticlesCount.Name = "tb_ParticlesCount";
            this.tb_ParticlesCount.Size = new System.Drawing.Size(232, 56);
            this.tb_ParticlesCount.TabIndex = 2;
            this.tb_ParticlesCount.Scroll += new System.EventHandler(this.tb_ParticlesCount_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1251, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество корма";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.checkBox1.Location = new System.Drawing.Point(1244, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "розовый корм";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.ForeColor = System.Drawing.Color.Navy;
            this.checkBox2.Location = new System.Drawing.Point(1244, 93);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "синий корм";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.ForeColor = System.Drawing.Color.Yellow;
            this.checkBox3.Location = new System.Drawing.Point(1244, 21);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(127, 21);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "желтый корм";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // picDisplay
            // 
            this.picDisplay.BackgroundImage = global::Kursach.Properties.Resources.fon;
            this.picDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDisplay.Location = new System.Drawing.Point(3, 1);
            this.picDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1224, 795);
            this.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // tb_pfish
            // 
            this.tb_pfish.Location = new System.Drawing.Point(1244, 444);
            this.tb_pfish.Maximum = 300;
            this.tb_pfish.Minimum = 50;
            this.tb_pfish.Name = "tb_pfish";
            this.tb_pfish.Size = new System.Drawing.Size(224, 56);
            this.tb_pfish.TabIndex = 7;
            this.tb_pfish.Value = 50;
            this.tb_pfish.Scroll += new System.EventHandler(this.tb_pfish_Scroll);
            // 
            // tb_yfish
            // 
            this.tb_yfish.Location = new System.Drawing.Point(1244, 250);
            this.tb_yfish.Maximum = 300;
            this.tb_yfish.Minimum = 50;
            this.tb_yfish.Name = "tb_yfish";
            this.tb_yfish.Size = new System.Drawing.Size(224, 56);
            this.tb_yfish.TabIndex = 8;
            this.tb_yfish.Value = 50;
            this.tb_yfish.Scroll += new System.EventHandler(this.tb_yfish_Scroll);
            // 
            // tb_bfish
            // 
            this.tb_bfish.Location = new System.Drawing.Point(1246, 625);
            this.tb_bfish.Maximum = 300;
            this.tb_bfish.Minimum = 50;
            this.tb_bfish.Name = "tb_bfish";
            this.tb_bfish.Size = new System.Drawing.Size(224, 56);
            this.tb_bfish.TabIndex = 9;
            this.tb_bfish.Value = 50;
            this.tb_bfish.Scroll += new System.EventHandler(this.tb_bfish_Scroll);
            // 
            // lbl_yfish
            // 
            this.lbl_yfish.AutoSize = true;
            this.lbl_yfish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_yfish.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_yfish.Location = new System.Drawing.Point(1255, 221);
            this.lbl_yfish.Name = "lbl_yfish";
            this.lbl_yfish.Size = new System.Drawing.Size(219, 17);
            this.lbl_yfish.TabIndex = 11;
            this.lbl_yfish.Text = "Максимальная сытость: 200";
            // 
            // lbl_pfish
            // 
            this.lbl_pfish.AutoSize = true;
            this.lbl_pfish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_pfish.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_pfish.Location = new System.Drawing.Point(1255, 415);
            this.lbl_pfish.Name = "lbl_pfish";
            this.lbl_pfish.Size = new System.Drawing.Size(210, 17);
            this.lbl_pfish.TabIndex = 12;
            this.lbl_pfish.Text = "Максимальная сытость: 50";
            // 
            // lbl_bfish
            // 
            this.lbl_bfish.AutoSize = true;
            this.lbl_bfish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_bfish.ForeColor = System.Drawing.Color.Navy;
            this.lbl_bfish.Location = new System.Drawing.Point(1255, 596);
            this.lbl_bfish.Name = "lbl_bfish";
            this.lbl_bfish.Size = new System.Drawing.Size(219, 17);
            this.lbl_bfish.TabIndex = 13;
            this.lbl_bfish.Text = "Максимальная сытость: 100";
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_.Location = new System.Drawing.Point(1255, 309);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(140, 17);
            this.lbl_.TabIndex = 14;
            this.lbl_.Text = "Сила притяжения";
            // 
            // tb_ygravity
            // 
            this.tb_ygravity.Location = new System.Drawing.Point(1244, 342);
            this.tb_ygravity.Maximum = 100;
            this.tb_ygravity.Name = "tb_ygravity";
            this.tb_ygravity.Size = new System.Drawing.Size(224, 56);
            this.tb_ygravity.TabIndex = 15;
            this.tb_ygravity.Scroll += new System.EventHandler(this.tb_ygravity_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(1255, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Сила притяжения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1255, 692);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Сила притяжения";
            // 
            // tb_pgravity
            // 
            this.tb_pgravity.Location = new System.Drawing.Point(1244, 537);
            this.tb_pgravity.Maximum = 100;
            this.tb_pgravity.Name = "tb_pgravity";
            this.tb_pgravity.Size = new System.Drawing.Size(221, 56);
            this.tb_pgravity.TabIndex = 18;
            this.tb_pgravity.Scroll += new System.EventHandler(this.tb_pgravity_Scroll);
            // 
            // tb_bgravity
            // 
            this.tb_bgravity.Location = new System.Drawing.Point(1244, 727);
            this.tb_bgravity.Maximum = 100;
            this.tb_bgravity.Name = "tb_bgravity";
            this.tb_bgravity.Size = new System.Drawing.Size(224, 56);
            this.tb_bgravity.TabIndex = 19;
            this.tb_bgravity.Scroll += new System.EventHandler(this.tb_bgravity_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1510, 795);
            this.Controls.Add(this.tb_bgravity);
            this.Controls.Add(this.tb_pgravity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ygravity);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lbl_bfish);
            this.Controls.Add(this.lbl_pfish);
            this.Controls.Add(this.lbl_yfish);
            this.Controls.Add(this.tb_bfish);
            this.Controls.Add(this.tb_yfish);
            this.Controls.Add(this.tb_pfish);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ParticlesCount);
            this.Controls.Add(this.picDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tb_ParticlesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pfish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_yfish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bfish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ygravity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pgravity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bgravity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tb_ParticlesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TrackBar tb_pfish;
        private System.Windows.Forms.TrackBar tb_yfish;
        private System.Windows.Forms.TrackBar tb_bfish;
        private System.Windows.Forms.Label lbl_yfish;
        private System.Windows.Forms.Label lbl_pfish;
        private System.Windows.Forms.Label lbl_bfish;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.TrackBar tb_ygravity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tb_pgravity;
        private System.Windows.Forms.TrackBar tb_bgravity;
    }
}

