namespace Envysoft.Helios
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbAntialasing = new System.Windows.Forms.CheckBox();
            this.cbUpSharpen = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ZoomTrackBar = new System.Windows.Forms.TrackBar();
            this.RotatePanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.rbRotate270FlipNone = new System.Windows.Forms.RadioButton();
            this.rbRotate180FlipNone = new System.Windows.Forms.RadioButton();
            this.rbRotate90FlipNone = new System.Windows.Forms.RadioButton();
            this.FlipPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.rbRotateNoneFlipXY = new System.Windows.Forms.RadioButton();
            this.rbRotateNoneFlipY = new System.Windows.Forms.RadioButton();
            this.rbRotateNoneFlipX = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomTrackBar)).BeginInit();
            this.RotatePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FlipPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.RotatePanel);
            this.panel1.Controls.Add(this.FlipPanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.videoSourcePlayer1);
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 520);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbAntialasing);
            this.panel2.Controls.Add(this.cbUpSharpen);
            this.panel2.Location = new System.Drawing.Point(696, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 32);
            this.panel2.TabIndex = 8;
            // 
            // cbAntialasing
            // 
            this.cbAntialasing.AutoSize = true;
            this.cbAntialasing.Enabled = false;
            this.cbAntialasing.Location = new System.Drawing.Point(135, 8);
            this.cbAntialasing.Name = "cbAntialasing";
            this.cbAntialasing.Size = new System.Drawing.Size(94, 17);
            this.cbAntialasing.TabIndex = 11;
            this.cbAntialasing.Text = "Сглаживание";
            this.cbAntialasing.UseVisualStyleBackColor = true;
            this.cbAntialasing.CheckedChanged += new System.EventHandler(this.cbAntialasing_CheckedChanged);
            // 
            // cbUpSharpen
            // 
            this.cbUpSharpen.AutoSize = true;
            this.cbUpSharpen.Location = new System.Drawing.Point(7, 8);
            this.cbUpSharpen.Name = "cbUpSharpen";
            this.cbUpSharpen.Size = new System.Drawing.Size(119, 17);
            this.cbUpSharpen.TabIndex = 10;
            this.cbUpSharpen.Text = "Поднять резкость";
            this.cbUpSharpen.UseVisualStyleBackColor = true;
            this.cbUpSharpen.CheckedChanged += new System.EventHandler(this.cbUpSharpen_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ZoomTrackBar);
            this.groupBox3.Location = new System.Drawing.Point(696, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 96);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Масштаб";
            // 
            // ZoomTrackBar
            // 
            this.ZoomTrackBar.AutoSize = false;
            this.ZoomTrackBar.Location = new System.Drawing.Point(28, 40);
            this.ZoomTrackBar.Maximum = 99;
            this.ZoomTrackBar.Minimum = 1;
            this.ZoomTrackBar.Name = "ZoomTrackBar";
            this.ZoomTrackBar.Size = new System.Drawing.Size(192, 28);
            this.ZoomTrackBar.TabIndex = 0;
            this.ZoomTrackBar.Value = 1;
            this.ZoomTrackBar.Scroll += new System.EventHandler(this.ZoomTrackBar_Scroll);
            // 
            // RotatePanel
            // 
            this.RotatePanel.Controls.Add(this.groupBox1);
            this.RotatePanel.Location = new System.Drawing.Point(696, 196);
            this.RotatePanel.Name = "RotatePanel";
            this.RotatePanel.Size = new System.Drawing.Size(112, 168);
            this.RotatePanel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.rbRotate270FlipNone);
            this.groupBox1.Controls.Add(this.rbRotate180FlipNone);
            this.groupBox1.Controls.Add(this.rbRotate90FlipNone);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поворот на:";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Location = new System.Drawing.Point(8, 104);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(44, 17);
            this.radioButton7.TabIndex = 11;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Нет";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // rbRotate270FlipNone
            // 
            this.rbRotate270FlipNone.AutoSize = true;
            this.rbRotate270FlipNone.Location = new System.Drawing.Point(8, 80);
            this.rbRotate270FlipNone.Name = "rbRotate270FlipNone";
            this.rbRotate270FlipNone.Size = new System.Drawing.Size(43, 17);
            this.rbRotate270FlipNone.TabIndex = 10;
            this.rbRotate270FlipNone.Text = "270";
            this.rbRotate270FlipNone.UseVisualStyleBackColor = true;
            // 
            // rbRotate180FlipNone
            // 
            this.rbRotate180FlipNone.AutoSize = true;
            this.rbRotate180FlipNone.Location = new System.Drawing.Point(8, 52);
            this.rbRotate180FlipNone.Name = "rbRotate180FlipNone";
            this.rbRotate180FlipNone.Size = new System.Drawing.Size(43, 17);
            this.rbRotate180FlipNone.TabIndex = 9;
            this.rbRotate180FlipNone.Text = "180";
            this.rbRotate180FlipNone.UseVisualStyleBackColor = true;
            // 
            // rbRotate90FlipNone
            // 
            this.rbRotate90FlipNone.AutoSize = true;
            this.rbRotate90FlipNone.Location = new System.Drawing.Point(8, 28);
            this.rbRotate90FlipNone.Name = "rbRotate90FlipNone";
            this.rbRotate90FlipNone.Size = new System.Drawing.Size(37, 17);
            this.rbRotate90FlipNone.TabIndex = 8;
            this.rbRotate90FlipNone.Text = "90";
            this.rbRotate90FlipNone.UseVisualStyleBackColor = true;
            // 
            // FlipPanel
            // 
            this.FlipPanel.Controls.Add(this.groupBox2);
            this.FlipPanel.Location = new System.Drawing.Point(812, 196);
            this.FlipPanel.Name = "FlipPanel";
            this.FlipPanel.Size = new System.Drawing.Size(120, 168);
            this.FlipPanel.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.rbRotateNoneFlipXY);
            this.groupBox2.Controls.Add(this.rbRotateNoneFlipY);
            this.groupBox2.Controls.Add(this.rbRotateNoneFlipX);
            this.groupBox2.Location = new System.Drawing.Point(4, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 140);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отразить по:";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Location = new System.Drawing.Point(8, 104);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(44, 17);
            this.radioButton8.TabIndex = 24;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Нет";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // rbRotateNoneFlipXY
            // 
            this.rbRotateNoneFlipXY.AutoSize = true;
            this.rbRotateNoneFlipXY.Location = new System.Drawing.Point(8, 80);
            this.rbRotateNoneFlipXY.Name = "rbRotateNoneFlipXY";
            this.rbRotateNoneFlipXY.Size = new System.Drawing.Size(82, 17);
            this.rbRotateNoneFlipXY.TabIndex = 23;
            this.rbRotateNoneFlipXY.Text = "Осям X и Y";
            this.rbRotateNoneFlipXY.UseVisualStyleBackColor = true;
            // 
            // rbRotateNoneFlipY
            // 
            this.rbRotateNoneFlipY.AutoSize = true;
            this.rbRotateNoneFlipY.Location = new System.Drawing.Point(8, 52);
            this.rbRotateNoneFlipY.Name = "rbRotateNoneFlipY";
            this.rbRotateNoneFlipY.Size = new System.Drawing.Size(55, 17);
            this.rbRotateNoneFlipY.TabIndex = 22;
            this.rbRotateNoneFlipY.Text = "Оси Y";
            this.rbRotateNoneFlipY.UseVisualStyleBackColor = true;
            // 
            // rbRotateNoneFlipX
            // 
            this.rbRotateNoneFlipX.AutoSize = true;
            this.rbRotateNoneFlipX.Location = new System.Drawing.Point(8, 28);
            this.rbRotateNoneFlipX.Name = "rbRotateNoneFlipX";
            this.rbRotateNoneFlipX.Size = new System.Drawing.Size(55, 17);
            this.rbRotateNoneFlipX.TabIndex = 20;
            this.rbRotateNoneFlipX.Text = "Оси X";
            this.rbRotateNoneFlipX.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Получить изображение с микроскопа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startCamera_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(724, 8);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(212, 132);
            this.videoSourcePlayer1.TabIndex = 1;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 574);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Управление микроскопом Helios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ZoomTrackBar)).EndInit();
            this.RotatePanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FlipPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel RotatePanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRotate270FlipNone;
        private System.Windows.Forms.RadioButton rbRotate180FlipNone;
        private System.Windows.Forms.RadioButton rbRotate90FlipNone;
        private System.Windows.Forms.Panel FlipPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRotateNoneFlipXY;
        private System.Windows.Forms.RadioButton rbRotateNoneFlipY;
        private System.Windows.Forms.RadioButton rbRotateNoneFlipX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar ZoomTrackBar;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbAntialasing;
        private System.Windows.Forms.CheckBox cbUpSharpen;

    }
}

