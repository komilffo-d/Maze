namespace Maze
{
    partial class Admin
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
            this.AdminAboutUs = new System.Windows.Forms.Button();
            this.AdminAboutSys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createPattern = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveToFile = new System.Windows.Forms.Button();
            this.EntryExit = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureMaze = new System.Windows.Forms.PictureBox();
            this.modeGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonAdminAuto = new System.Windows.Forms.RadioButton();
            this.radioButtonAdminHands = new System.Windows.Forms.RadioButton();
            this.altGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonAldousBroder = new System.Windows.Forms.RadioButton();
            this.radioButtonEuler = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaze)).BeginInit();
            this.modeGroupBox.SuspendLayout();
            this.altGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminAboutUs
            // 
            this.AdminAboutUs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminAboutUs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AdminAboutUs.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminAboutUs.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AdminAboutUs.Location = new System.Drawing.Point(19, 10);
            this.AdminAboutUs.Margin = new System.Windows.Forms.Padding(2);
            this.AdminAboutUs.Name = "AdminAboutUs";
            this.AdminAboutUs.Size = new System.Drawing.Size(181, 33);
            this.AdminAboutUs.TabIndex = 5;
            this.AdminAboutUs.Text = "О разработчиках";
            this.AdminAboutUs.UseVisualStyleBackColor = false;
            this.AdminAboutUs.Click += new System.EventHandler(this.AdminAboutUs_Click);
            // 
            // AdminAboutSys
            // 
            this.AdminAboutSys.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminAboutSys.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AdminAboutSys.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminAboutSys.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AdminAboutSys.Location = new System.Drawing.Point(231, 10);
            this.AdminAboutSys.Margin = new System.Windows.Forms.Padding(2);
            this.AdminAboutSys.Name = "AdminAboutSys";
            this.AdminAboutSys.Size = new System.Drawing.Size(181, 33);
            this.AdminAboutSys.TabIndex = 6;
            this.AdminAboutSys.Text = "О системе";
            this.AdminAboutSys.UseVisualStyleBackColor = false;
            this.AdminAboutSys.Click += new System.EventHandler(this.AdminAboutSys_Click);
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
            this.label1.Text = "Настройка параметров лабиринта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createPattern
            // 
            this.createPattern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createPattern.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createPattern.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createPattern.ForeColor = System.Drawing.SystemColors.Window;
            this.createPattern.Location = new System.Drawing.Point(40, 171);
            this.createPattern.Margin = new System.Windows.Forms.Padding(2);
            this.createPattern.Name = "createPattern";
            this.createPattern.Size = new System.Drawing.Size(259, 34);
            this.createPattern.TabIndex = 8;
            this.createPattern.Text = "Создать шаблон";
            this.createPattern.UseVisualStyleBackColor = false;
            this.createPattern.Click += new System.EventHandler(this.createPattern_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.label2.Location = new System.Drawing.Point(-47, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ширина лабиринта:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.label3.Location = new System.Drawing.Point(-62, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Высота дабиринта:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(-10, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Способ расстановки входа и выхода:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(-10, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Выбор алгоритма генерации лабиринта:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveToFile
            // 
            this.saveToFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveToFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveToFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveToFile.ForeColor = System.Drawing.SystemColors.Window;
            this.saveToFile.Location = new System.Drawing.Point(520, 458);
            this.saveToFile.Margin = new System.Windows.Forms.Padding(2);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(259, 34);
            this.saveToFile.TabIndex = 22;
            this.saveToFile.Text = "Сохранить лабиринт в файл";
            this.saveToFile.UseVisualStyleBackColor = false;
            this.saveToFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // EntryExit
            // 
            this.EntryExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EntryExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EntryExit.Enabled = false;
            this.EntryExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntryExit.ForeColor = System.Drawing.SystemColors.Window;
            this.EntryExit.Location = new System.Drawing.Point(38, 397);
            this.EntryExit.Margin = new System.Windows.Forms.Padding(2);
            this.EntryExit.Name = "EntryExit";
            this.EntryExit.Size = new System.Drawing.Size(292, 34);
            this.EntryExit.TabIndex = 23;
            this.EntryExit.Text = "Расставить вход и выход";
            this.EntryExit.UseVisualStyleBackColor = false;
            this.EntryExit.Visible = false;
            this.EntryExit.Click += new System.EventHandler(this.EntryExit_Click);
            // 
            // Generate
            // 
            this.Generate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Generate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Generate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.ForeColor = System.Drawing.SystemColors.Window;
            this.Generate.Location = new System.Drawing.Point(38, 448);
            this.Generate.Margin = new System.Windows.Forms.Padding(2);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(292, 34);
            this.Generate.TabIndex = 24;
            this.Generate.Text = "Сгенерировать лабиринт";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Visible = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // widthUpDown
            // 
            this.widthUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.widthUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.widthUpDown.Location = new System.Drawing.Point(196, 101);
            this.widthUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.widthUpDown.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(90, 20);
            this.widthUpDown.TabIndex = 25;
            this.widthUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // heightUpDown
            // 
            this.heightUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.heightUpDown.Location = new System.Drawing.Point(196, 128);
            this.heightUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.heightUpDown.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.heightUpDown.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(90, 20);
            this.heightUpDown.TabIndex = 26;
            this.heightUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // pictureMaze
            // 
            this.pictureMaze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureMaze.BackColor = System.Drawing.SystemColors.Control;
            this.pictureMaze.Location = new System.Drawing.Point(416, 22);
            this.pictureMaze.Margin = new System.Windows.Forms.Padding(2);
            this.pictureMaze.Name = "pictureMaze";
            this.pictureMaze.Size = new System.Drawing.Size(406, 410);
            this.pictureMaze.TabIndex = 27;
            this.pictureMaze.TabStop = false;
            this.pictureMaze.Click += new System.EventHandler(this.pictureMaze_Click);
            // 
            // modeGroupBox
            // 
            this.modeGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modeGroupBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.modeGroupBox.Controls.Add(this.radioButtonAdminAuto);
            this.modeGroupBox.Controls.Add(this.radioButtonAdminHands);
            this.modeGroupBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.modeGroupBox.Location = new System.Drawing.Point(9, 245);
            this.modeGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.modeGroupBox.Name = "modeGroupBox";
            this.modeGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.modeGroupBox.Size = new System.Drawing.Size(403, 57);
            this.modeGroupBox.TabIndex = 28;
            this.modeGroupBox.TabStop = false;
            // 
            // radioButtonAdminAuto
            // 
            this.radioButtonAdminAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAdminAuto.AutoSize = true;
            this.radioButtonAdminAuto.Checked = true;
            this.radioButtonAdminAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAdminAuto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonAdminAuto.Location = new System.Drawing.Point(174, 22);
            this.radioButtonAdminAuto.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAdminAuto.Name = "radioButtonAdminAuto";
            this.radioButtonAdminAuto.Size = new System.Drawing.Size(191, 22);
            this.radioButtonAdminAuto.TabIndex = 30;
            this.radioButtonAdminAuto.TabStop = true;
            this.radioButtonAdminAuto.Text = "Автоматический режим";
            this.radioButtonAdminAuto.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdminHands
            // 
            this.radioButtonAdminHands.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAdminHands.AutoSize = true;
            this.radioButtonAdminHands.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAdminHands.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonAdminHands.Location = new System.Drawing.Point(16, 22);
            this.radioButtonAdminHands.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAdminHands.Name = "radioButtonAdminHands";
            this.radioButtonAdminHands.Size = new System.Drawing.Size(126, 22);
            this.radioButtonAdminHands.TabIndex = 29;
            this.radioButtonAdminHands.Text = "Ручной режим";
            this.radioButtonAdminHands.UseVisualStyleBackColor = true;
            // 
            // altGroupBox
            // 
            this.altGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altGroupBox.Controls.Add(this.radioButtonAldousBroder);
            this.altGroupBox.Controls.Add(this.radioButtonEuler);
            this.altGroupBox.Location = new System.Drawing.Point(9, 336);
            this.altGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.altGroupBox.Name = "altGroupBox";
            this.altGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.altGroupBox.Size = new System.Drawing.Size(403, 57);
            this.altGroupBox.TabIndex = 29;
            this.altGroupBox.TabStop = false;
            // 
            // radioButtonAldousBroder
            // 
            this.radioButtonAldousBroder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAldousBroder.AutoSize = true;
            this.radioButtonAldousBroder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAldousBroder.Location = new System.Drawing.Point(174, 20);
            this.radioButtonAldousBroder.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAldousBroder.Name = "radioButtonAldousBroder";
            this.radioButtonAldousBroder.Size = new System.Drawing.Size(217, 22);
            this.radioButtonAldousBroder.TabIndex = 30;
            this.radioButtonAldousBroder.Text = "Алгоритм Олдоса-Бродера";
            this.radioButtonAldousBroder.UseVisualStyleBackColor = true;
            // 
            // radioButtonEuler
            // 
            this.radioButtonEuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonEuler.AutoSize = true;
            this.radioButtonEuler.Checked = true;
            this.radioButtonEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEuler.Location = new System.Drawing.Point(16, 20);
            this.radioButtonEuler.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEuler.Name = "radioButtonEuler";
            this.radioButtonEuler.Size = new System.Drawing.Size(149, 22);
            this.radioButtonEuler.TabIndex = 30;
            this.radioButtonEuler.TabStop = true;
            this.radioButtonEuler.Text = "Алгоритм Эйлера";
            this.radioButtonEuler.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(831, 514);
            this.Controls.Add(this.altGroupBox);
            this.Controls.Add(this.pictureMaze);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.widthUpDown);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.EntryExit);
            this.Controls.Add(this.saveToFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createPattern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminAboutSys);
            this.Controls.Add(this.AdminAboutUs);
            this.Controls.Add(this.modeGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaze)).EndInit();
            this.modeGroupBox.ResumeLayout(false);
            this.modeGroupBox.PerformLayout();
            this.altGroupBox.ResumeLayout(false);
            this.altGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminAboutUs;
        private System.Windows.Forms.Button AdminAboutSys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createPattern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveToFile;
        private System.Windows.Forms.Button EntryExit;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.PictureBox pictureMaze;
        private System.Windows.Forms.GroupBox modeGroupBox;
        private System.Windows.Forms.RadioButton radioButtonAdminAuto;
        private System.Windows.Forms.RadioButton radioButtonAdminHands;
        private System.Windows.Forms.GroupBox altGroupBox;
        private System.Windows.Forms.RadioButton radioButtonAldousBroder;
        private System.Windows.Forms.RadioButton radioButtonEuler;
    }
}