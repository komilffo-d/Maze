namespace Maze
{
    partial class Gamer
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
            this.aboutUs = new System.Windows.Forms.Button();
            this.aboutSys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputMazeFile = new System.Windows.Forms.Button();
            this.radioButtonHalloween = new System.Windows.Forms.RadioButton();
            this.radioButtonNewYear = new System.Windows.Forms.RadioButton();
            this.radioButtonForest = new System.Windows.Forms.RadioButton();
            this.radioButtonSea = new System.Windows.Forms.RadioButton();
            this.radioButtonHands = new System.Windows.Forms.RadioButton();
            this.radioButtonAuto = new System.Windows.Forms.RadioButton();
            this.radioButtonWave = new System.Windows.Forms.RadioButton();
            this.radioButton1Hands = new System.Windows.Forms.RadioButton();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureMaze = new System.Windows.Forms.PictureBox();
            this.ThemeGroupBox = new System.Windows.Forms.GroupBox();
            this.ModePassGroupBox = new System.Windows.Forms.GroupBox();
            this.algorithmGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaze)).BeginInit();
            this.ThemeGroupBox.SuspendLayout();
            this.ModePassGroupBox.SuspendLayout();
            this.algorithmGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutUs
            // 
            this.aboutUs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutUs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.aboutUs.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutUs.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.aboutUs.Location = new System.Drawing.Point(19, 10);
            this.aboutUs.Margin = new System.Windows.Forms.Padding(2);
            this.aboutUs.Name = "aboutUs";
            this.aboutUs.Size = new System.Drawing.Size(181, 33);
            this.aboutUs.TabIndex = 5;
            this.aboutUs.Text = "О разработчиках";
            this.aboutUs.UseVisualStyleBackColor = false;
            this.aboutUs.Click += new System.EventHandler(this.aboutUs_Click);
            // 
            // aboutSys
            // 
            this.aboutSys.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutSys.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.aboutSys.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutSys.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.aboutSys.Location = new System.Drawing.Point(231, 10);
            this.aboutSys.Margin = new System.Windows.Forms.Padding(2);
            this.aboutSys.Name = "aboutSys";
            this.aboutSys.Size = new System.Drawing.Size(181, 33);
            this.aboutSys.TabIndex = 6;
            this.aboutSys.Text = "О системе";
            this.aboutSys.UseVisualStyleBackColor = false;
            this.aboutSys.Click += new System.EventHandler(this.aboutSys_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Настройка параметров игры";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputMazeFile
            // 
            this.outputMazeFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputMazeFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputMazeFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputMazeFile.ForeColor = System.Drawing.SystemColors.Window;
            this.outputMazeFile.Location = new System.Drawing.Point(47, 95);
            this.outputMazeFile.Margin = new System.Windows.Forms.Padding(2);
            this.outputMazeFile.Name = "outputMazeFile";
            this.outputMazeFile.Size = new System.Drawing.Size(259, 34);
            this.outputMazeFile.TabIndex = 8;
            this.outputMazeFile.Text = "Загрузить лабиринт из файла";
            this.outputMazeFile.UseVisualStyleBackColor = false;
            this.outputMazeFile.Click += new System.EventHandler(this.outputMazeFile_Click);
            // 
            // radioButtonHalloween
            // 
            this.radioButtonHalloween.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHalloween.AutoSize = true;
            this.radioButtonHalloween.Checked = true;
            this.radioButtonHalloween.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonHalloween.Location = new System.Drawing.Point(33, 18);
            this.radioButtonHalloween.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHalloween.Name = "radioButtonHalloween";
            this.radioButtonHalloween.Size = new System.Drawing.Size(95, 22);
            this.radioButtonHalloween.TabIndex = 9;
            this.radioButtonHalloween.TabStop = true;
            this.radioButtonHalloween.Text = "Halloween";
            this.radioButtonHalloween.UseVisualStyleBackColor = true;
            // 
            // radioButtonNewYear
            // 
            this.radioButtonNewYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonNewYear.AutoSize = true;
            this.radioButtonNewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonNewYear.Location = new System.Drawing.Point(216, 18);
            this.radioButtonNewYear.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNewYear.Name = "radioButtonNewYear";
            this.radioButtonNewYear.Size = new System.Drawing.Size(101, 22);
            this.radioButtonNewYear.TabIndex = 10;
            this.radioButtonNewYear.Text = "Новый год";
            this.radioButtonNewYear.UseVisualStyleBackColor = true;
            // 
            // radioButtonForest
            // 
            this.radioButtonForest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonForest.AutoSize = true;
            this.radioButtonForest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonForest.Location = new System.Drawing.Point(33, 46);
            this.radioButtonForest.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonForest.Name = "radioButtonForest";
            this.radioButtonForest.Size = new System.Drawing.Size(115, 22);
            this.radioButtonForest.TabIndex = 11;
            this.radioButtonForest.Text = "Лесная тема";
            this.radioButtonForest.UseVisualStyleBackColor = true;
            // 
            // radioButtonSea
            // 
            this.radioButtonSea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonSea.AutoSize = true;
            this.radioButtonSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSea.Location = new System.Drawing.Point(216, 46);
            this.radioButtonSea.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSea.Name = "radioButtonSea";
            this.radioButtonSea.Size = new System.Drawing.Size(126, 22);
            this.radioButtonSea.TabIndex = 12;
            this.radioButtonSea.Text = "Морская тема";
            this.radioButtonSea.UseVisualStyleBackColor = true;
            // 
            // radioButtonHands
            // 
            this.radioButtonHands.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHands.AutoSize = true;
            this.radioButtonHands.Checked = true;
            this.radioButtonHands.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonHands.Location = new System.Drawing.Point(25, 18);
            this.radioButtonHands.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHands.Name = "radioButtonHands";
            this.radioButtonHands.Size = new System.Drawing.Size(126, 22);
            this.radioButtonHands.TabIndex = 13;
            this.radioButtonHands.TabStop = true;
            this.radioButtonHands.Text = "Ручной режим";
            this.radioButtonHands.UseVisualStyleBackColor = true;
            // 
            // radioButtonAuto
            // 
            this.radioButtonAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAuto.AutoSize = true;
            this.radioButtonAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAuto.Location = new System.Drawing.Point(179, 18);
            this.radioButtonAuto.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAuto.Name = "radioButtonAuto";
            this.radioButtonAuto.Size = new System.Drawing.Size(191, 22);
            this.radioButtonAuto.TabIndex = 14;
            this.radioButtonAuto.Text = "Автоматический режим";
            this.radioButtonAuto.UseVisualStyleBackColor = true;
            // 
            // radioButtonWave
            // 
            this.radioButtonWave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonWave.AutoSize = true;
            this.radioButtonWave.Checked = true;
            this.radioButtonWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWave.Location = new System.Drawing.Point(12, 18);
            this.radioButtonWave.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonWave.Name = "radioButtonWave";
            this.radioButtonWave.Size = new System.Drawing.Size(166, 22);
            this.radioButtonWave.TabIndex = 15;
            this.radioButtonWave.TabStop = true;
            this.radioButtonWave.Text = "Волновой алгоритм";
            this.radioButtonWave.UseVisualStyleBackColor = true;
            // 
            // radioButton1Hands
            // 
            this.radioButton1Hands.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1Hands.AutoSize = true;
            this.radioButton1Hands.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1Hands.Location = new System.Drawing.Point(195, 18);
            this.radioButton1Hands.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1Hands.Name = "radioButton1Hands";
            this.radioButton1Hands.Size = new System.Drawing.Size(175, 22);
            this.radioButton1Hands.TabIndex = 16;
            this.radioButton1Hands.Text = "Алгоритм одной руки";
            this.radioButton1Hands.UseVisualStyleBackColor = true;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBarSpeed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBarSpeed.Location = new System.Drawing.Point(19, 458);
            this.trackBarSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarSpeed.Maximum = 5;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(278, 45);
            this.trackBarSpeed.TabIndex = 17;
            this.trackBarSpeed.Value = 3;
            this.trackBarSpeed.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-12, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Выбор темы оформления:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-3, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Выбор режима прохождения:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Выбор алгоритма прохождения:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(-3, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Выбор скорости перемещения:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Visible = false;
            // 
            // startGame
            // 
            this.startGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startGame.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGame.ForeColor = System.Drawing.SystemColors.Window;
            this.startGame.Location = new System.Drawing.Point(520, 458);
            this.startGame.Margin = new System.Windows.Forms.Padding(2);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(259, 34);
            this.startGame.TabIndex = 22;
            this.startGame.Text = "Начать прохождение";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Visible = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::Maze.Properties.Resources.mario;
            this.pictureBox2.Location = new System.Drawing.Point(452, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureMaze
            // 
            this.pictureMaze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureMaze.BackColor = System.Drawing.SystemColors.Control;
            this.pictureMaze.Location = new System.Drawing.Point(452, 29);
            this.pictureMaze.Margin = new System.Windows.Forms.Padding(2);
            this.pictureMaze.Name = "pictureMaze";
            this.pictureMaze.Size = new System.Drawing.Size(370, 377);
            this.pictureMaze.TabIndex = 28;
            this.pictureMaze.TabStop = false;
            // 
            // ThemeGroupBox
            // 
            this.ThemeGroupBox.Controls.Add(this.radioButtonHalloween);
            this.ThemeGroupBox.Controls.Add(this.radioButtonNewYear);
            this.ThemeGroupBox.Controls.Add(this.radioButtonForest);
            this.ThemeGroupBox.Controls.Add(this.radioButtonSea);
            this.ThemeGroupBox.Location = new System.Drawing.Point(19, 164);
            this.ThemeGroupBox.Name = "ThemeGroupBox";
            this.ThemeGroupBox.Size = new System.Drawing.Size(378, 81);
            this.ThemeGroupBox.TabIndex = 30;
            this.ThemeGroupBox.TabStop = false;
            // 
            // ModePassGroupBox
            // 
            this.ModePassGroupBox.Controls.Add(this.radioButtonHands);
            this.ModePassGroupBox.Controls.Add(this.radioButtonAuto);
            this.ModePassGroupBox.Location = new System.Drawing.Point(22, 270);
            this.ModePassGroupBox.Name = "ModePassGroupBox";
            this.ModePassGroupBox.Size = new System.Drawing.Size(375, 62);
            this.ModePassGroupBox.TabIndex = 31;
            this.ModePassGroupBox.TabStop = false;
            // 
            // algorithmGroupBox
            // 
            this.algorithmGroupBox.Controls.Add(this.radioButtonWave);
            this.algorithmGroupBox.Controls.Add(this.radioButton1Hands);
            this.algorithmGroupBox.Location = new System.Drawing.Point(22, 358);
            this.algorithmGroupBox.Name = "algorithmGroupBox";
            this.algorithmGroupBox.Size = new System.Drawing.Size(375, 53);
            this.algorithmGroupBox.TabIndex = 32;
            this.algorithmGroupBox.TabStop = false;
            this.algorithmGroupBox.Visible = false;
            // 
            // Gamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(831, 514);
            this.Controls.Add(this.algorithmGroupBox);
            this.Controls.Add(this.ModePassGroupBox);
            this.Controls.Add(this.ThemeGroupBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureMaze);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.outputMazeFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutSys);
            this.Controls.Add(this.aboutUs);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gamer";
            this.Text = "Gamer";
            this.Load += new System.EventHandler(this.Gamer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gamer_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Gamer_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaze)).EndInit();
            this.ThemeGroupBox.ResumeLayout(false);
            this.ThemeGroupBox.PerformLayout();
            this.ModePassGroupBox.ResumeLayout(false);
            this.ModePassGroupBox.PerformLayout();
            this.algorithmGroupBox.ResumeLayout(false);
            this.algorithmGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aboutUs;
        private System.Windows.Forms.Button aboutSys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button outputMazeFile;
        private System.Windows.Forms.RadioButton radioButtonHalloween;
        private System.Windows.Forms.RadioButton radioButtonNewYear;
        private System.Windows.Forms.RadioButton radioButtonForest;
        private System.Windows.Forms.RadioButton radioButtonSea;
        private System.Windows.Forms.RadioButton radioButtonHands;
        private System.Windows.Forms.RadioButton radioButtonAuto;
        private System.Windows.Forms.RadioButton radioButtonWave;
        private System.Windows.Forms.RadioButton radioButton1Hands;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.PictureBox pictureMaze;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox ThemeGroupBox;
        private System.Windows.Forms.GroupBox ModePassGroupBox;
        private System.Windows.Forms.GroupBox algorithmGroupBox;
    }
}