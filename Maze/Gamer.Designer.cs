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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutUs
            // 
            this.aboutUs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutUs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.aboutUs.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutUs.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.aboutUs.Location = new System.Drawing.Point(25, 12);
            this.aboutUs.Name = "aboutUs";
            this.aboutUs.Size = new System.Drawing.Size(241, 41);
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
            this.aboutSys.Location = new System.Drawing.Point(308, 12);
            this.aboutSys.Name = "aboutSys";
            this.aboutSys.Size = new System.Drawing.Size(241, 41);
            this.aboutSys.TabIndex = 6;
            this.aboutSys.Text = "О системе";
            this.aboutSys.UseVisualStyleBackColor = false;
            this.aboutSys.Click += new System.EventHandler(this.aboutSys_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 60);
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
            this.outputMazeFile.Location = new System.Drawing.Point(63, 117);
            this.outputMazeFile.Name = "outputMazeFile";
            this.outputMazeFile.Size = new System.Drawing.Size(345, 42);
            this.outputMazeFile.TabIndex = 8;
            this.outputMazeFile.Text = "Загрузить лабиринт из файла";
            this.outputMazeFile.UseVisualStyleBackColor = false;
            // 
            // radioButtonHalloween
            // 
            this.radioButtonHalloween.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHalloween.AutoSize = true;
            this.radioButtonHalloween.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonHalloween.Location = new System.Drawing.Point(25, 211);
            this.radioButtonHalloween.Name = "radioButtonHalloween";
            this.radioButtonHalloween.Size = new System.Drawing.Size(115, 26);
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
            this.radioButtonNewYear.Location = new System.Drawing.Point(262, 211);
            this.radioButtonNewYear.Name = "radioButtonNewYear";
            this.radioButtonNewYear.Size = new System.Drawing.Size(120, 26);
            this.radioButtonNewYear.TabIndex = 10;
            this.radioButtonNewYear.TabStop = true;
            this.radioButtonNewYear.Text = "Новый год";
            this.radioButtonNewYear.UseVisualStyleBackColor = true;
            // 
            // radioButtonForest
            // 
            this.radioButtonForest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonForest.AutoSize = true;
            this.radioButtonForest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonForest.Location = new System.Drawing.Point(25, 257);
            this.radioButtonForest.Name = "radioButtonForest";
            this.radioButtonForest.Size = new System.Drawing.Size(139, 26);
            this.radioButtonForest.TabIndex = 11;
            this.radioButtonForest.TabStop = true;
            this.radioButtonForest.Text = "Лесная тема";
            this.radioButtonForest.UseVisualStyleBackColor = true;
            // 
            // radioButtonSea
            // 
            this.radioButtonSea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonSea.AutoSize = true;
            this.radioButtonSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSea.Location = new System.Drawing.Point(262, 257);
            this.radioButtonSea.Name = "radioButtonSea";
            this.radioButtonSea.Size = new System.Drawing.Size(149, 26);
            this.radioButtonSea.TabIndex = 12;
            this.radioButtonSea.TabStop = true;
            this.radioButtonSea.Text = "Морская тема";
            this.radioButtonSea.UseVisualStyleBackColor = true;
            // 
            // radioButtonHands
            // 
            this.radioButtonHands.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHands.AutoSize = true;
            this.radioButtonHands.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonHands.Location = new System.Drawing.Point(25, 359);
            this.radioButtonHands.Name = "radioButtonHands";
            this.radioButtonHands.Size = new System.Drawing.Size(154, 26);
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
            this.radioButtonAuto.Location = new System.Drawing.Point(262, 359);
            this.radioButtonAuto.Name = "radioButtonAuto";
            this.radioButtonAuto.Size = new System.Drawing.Size(232, 26);
            this.radioButtonAuto.TabIndex = 14;
            this.radioButtonAuto.TabStop = true;
            this.radioButtonAuto.Text = "Автоматический режим";
            this.radioButtonAuto.UseVisualStyleBackColor = true;
            // 
            // radioButtonWave
            // 
            this.radioButtonWave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonWave.AutoSize = true;
            this.radioButtonWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWave.Location = new System.Drawing.Point(25, 456);
            this.radioButtonWave.Name = "radioButtonWave";
            this.radioButtonWave.Size = new System.Drawing.Size(196, 26);
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
            this.radioButton1Hands.Location = new System.Drawing.Point(262, 456);
            this.radioButton1Hands.Name = "radioButton1Hands";
            this.radioButton1Hands.Size = new System.Drawing.Size(210, 26);
            this.radioButton1Hands.TabIndex = 16;
            this.radioButton1Hands.TabStop = true;
            this.radioButton1Hands.Text = "Алгоритм одной руки";
            this.radioButton1Hands.UseVisualStyleBackColor = true;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBarSpeed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBarSpeed.Location = new System.Drawing.Point(25, 564);
            this.trackBarSpeed.Maximum = 5;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(370, 56);
            this.trackBarSpeed.TabIndex = 17;
            this.trackBarSpeed.Value = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-16, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Выбор темы оформления:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-4, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Выбор режима прохождения:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Выбор алгоритма прохождения:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(-4, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 36);
            this.label5.TabIndex = 21;
            this.label5.Text = "Выбор скорости перемещения:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startGame
            // 
            this.startGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startGame.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGame.ForeColor = System.Drawing.SystemColors.Window;
            this.startGame.Location = new System.Drawing.Point(694, 564);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(345, 42);
            this.startGame.TabIndex = 22;
            this.startGame.Text = "Начать прохождение";
            this.startGame.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(603, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 464);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Gamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1108, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.radioButton1Hands);
            this.Controls.Add(this.radioButtonWave);
            this.Controls.Add(this.radioButtonAuto);
            this.Controls.Add(this.radioButtonHands);
            this.Controls.Add(this.radioButtonSea);
            this.Controls.Add(this.radioButtonForest);
            this.Controls.Add(this.radioButtonNewYear);
            this.Controls.Add(this.radioButtonHalloween);
            this.Controls.Add(this.outputMazeFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutSys);
            this.Controls.Add(this.aboutUs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gamer";
            this.Text = "Gamer";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}