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
            this.width = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAdminAuto = new System.Windows.Forms.RadioButton();
            this.radioButtonAdminHands = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAldousBroder = new System.Windows.Forms.RadioButton();
            this.radioButtonEuler = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminAboutUs
            // 
            this.AdminAboutUs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminAboutUs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AdminAboutUs.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminAboutUs.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AdminAboutUs.Location = new System.Drawing.Point(25, 12);
            this.AdminAboutUs.Name = "AdminAboutUs";
            this.AdminAboutUs.Size = new System.Drawing.Size(241, 41);
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
            this.AdminAboutSys.Location = new System.Drawing.Point(308, 12);
            this.AdminAboutSys.Name = "AdminAboutSys";
            this.AdminAboutSys.Size = new System.Drawing.Size(241, 41);
            this.AdminAboutSys.TabIndex = 6;
            this.AdminAboutSys.Text = "О системе";
            this.AdminAboutSys.UseVisualStyleBackColor = false;
            this.AdminAboutSys.Click += new System.EventHandler(this.AdminAboutSys_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 60);
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
            this.createPattern.Location = new System.Drawing.Point(54, 210);
            this.createPattern.Name = "createPattern";
            this.createPattern.Size = new System.Drawing.Size(345, 42);
            this.createPattern.TabIndex = 8;
            this.createPattern.Text = "Создать шаблон";
            this.createPattern.UseVisualStyleBackColor = false;
            this.createPattern.Click += new System.EventHandler(this.createPattern_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.label2.Location = new System.Drawing.Point(-63, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ширина лабиринта:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.label3.Location = new System.Drawing.Point(-82, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Высота дабиринта:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(-13, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(503, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Способ расстановки входа и выхода:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(-13, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 36);
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
            this.saveToFile.Location = new System.Drawing.Point(694, 564);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(345, 42);
            this.saveToFile.TabIndex = 22;
            this.saveToFile.Text = "Сохранить лабиринт в файл";
            this.saveToFile.UseVisualStyleBackColor = false;
            // 
            // EntryExit
            // 
            this.EntryExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EntryExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EntryExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntryExit.ForeColor = System.Drawing.SystemColors.Window;
            this.EntryExit.Location = new System.Drawing.Point(51, 489);
            this.EntryExit.Name = "EntryExit";
            this.EntryExit.Size = new System.Drawing.Size(390, 42);
            this.EntryExit.TabIndex = 23;
            this.EntryExit.Text = "Расставить вход и выход";
            this.EntryExit.UseVisualStyleBackColor = false;
            // 
            // Generate
            // 
            this.Generate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Generate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Generate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.ForeColor = System.Drawing.SystemColors.Window;
            this.Generate.Location = new System.Drawing.Point(51, 552);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(390, 42);
            this.Generate.TabIndex = 24;
            this.Generate.Text = "Сгенерировать лабиринт";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // width
            // 
            this.width.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.width.Location = new System.Drawing.Point(262, 124);
            this.width.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(120, 22);
            this.width.TabIndex = 25;
            this.width.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // height
            // 
            this.height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.height.Location = new System.Drawing.Point(262, 157);
            this.height.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(120, 22);
            this.height.TabIndex = 26;
            this.height.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(555, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 504);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.radioButtonAdminAuto);
            this.groupBox1.Controls.Add(this.radioButtonAdminHands);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(12, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 70);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonAdminAuto
            // 
            this.radioButtonAdminAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAdminAuto.AutoSize = true;
            this.radioButtonAdminAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAdminAuto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonAdminAuto.Location = new System.Drawing.Point(232, 27);
            this.radioButtonAdminAuto.Name = "radioButtonAdminAuto";
            this.radioButtonAdminAuto.Size = new System.Drawing.Size(232, 26);
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
            this.radioButtonAdminHands.Location = new System.Drawing.Point(22, 27);
            this.radioButtonAdminHands.Name = "radioButtonAdminHands";
            this.radioButtonAdminHands.Size = new System.Drawing.Size(154, 26);
            this.radioButtonAdminHands.TabIndex = 29;
            this.radioButtonAdminHands.TabStop = true;
            this.radioButtonAdminHands.Text = "Ручной режим";
            this.radioButtonAdminHands.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.radioButtonAldousBroder);
            this.groupBox2.Controls.Add(this.radioButtonEuler);
            this.groupBox2.Location = new System.Drawing.Point(12, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 70);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonAldousBroder
            // 
            this.radioButtonAldousBroder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAldousBroder.AutoSize = true;
            this.radioButtonAldousBroder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAldousBroder.Location = new System.Drawing.Point(232, 25);
            this.radioButtonAldousBroder.Name = "radioButtonAldousBroder";
            this.radioButtonAldousBroder.Size = new System.Drawing.Size(259, 26);
            this.radioButtonAldousBroder.TabIndex = 30;
            this.radioButtonAldousBroder.TabStop = true;
            this.radioButtonAldousBroder.Text = "Алгоритм Олдоса-Бродера";
            this.radioButtonAldousBroder.UseVisualStyleBackColor = true;
            // 
            // radioButtonEuler
            // 
            this.radioButtonEuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonEuler.AutoSize = true;
            this.radioButtonEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEuler.Location = new System.Drawing.Point(22, 25);
            this.radioButtonEuler.Name = "radioButtonEuler";
            this.radioButtonEuler.Size = new System.Drawing.Size(179, 26);
            this.radioButtonEuler.TabIndex = 30;
            this.radioButtonEuler.TabStop = true;
            this.radioButtonEuler.Text = "Алгоритм Эйлера";
            this.radioButtonEuler.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1108, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
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
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAdminAuto;
        private System.Windows.Forms.RadioButton radioButtonAdminHands;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonAldousBroder;
        private System.Windows.Forms.RadioButton radioButtonEuler;
    }
}