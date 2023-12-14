namespace Maze
{
    partial class Authorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.AInputLogin = new System.Windows.Forms.TextBox();
            this.AInputPassword = new System.Windows.Forms.TextBox();
            this.Entry = new System.Windows.Forms.Button();
            this.Reg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(429, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // AInputLogin
            // 
            this.AInputLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AInputLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AInputLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AInputLogin.Location = new System.Drawing.Point(358, 151);
            this.AInputLogin.MaximumSize = new System.Drawing.Size(500, 90);
            this.AInputLogin.Multiline = true;
            this.AInputLogin.Name = "AInputLogin";
            this.AInputLogin.Size = new System.Drawing.Size(362, 36);
            this.AInputLogin.TabIndex = 1;
            // 
            // AInputPassword
            // 
            this.AInputPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AInputPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AInputPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AInputPassword.Location = new System.Drawing.Point(358, 263);
            this.AInputPassword.MaximumSize = new System.Drawing.Size(500, 90);
            this.AInputPassword.Multiline = true;
            this.AInputPassword.Name = "AInputPassword";
            this.AInputPassword.PasswordChar = '*';
            this.AInputPassword.Size = new System.Drawing.Size(362, 36);
            this.AInputPassword.TabIndex = 2;
            // 
            // Entry
            // 
            this.Entry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Entry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Entry.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entry.ForeColor = System.Drawing.SystemColors.Window;
            this.Entry.Location = new System.Drawing.Point(394, 361);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(279, 42);
            this.Entry.TabIndex = 3;
            this.Entry.Text = "Войти";
            this.Entry.UseVisualStyleBackColor = false;
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // Reg
            // 
            this.Reg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Reg.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Reg.Location = new System.Drawing.Point(394, 517);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(279, 42);
            this.Reg.TabIndex = 4;
            this.Reg.Text = "Регистрация";
            this.Reg.UseVisualStyleBackColor = false;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(372, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(372, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(341, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ещё не зарегистрированы?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1104, 628);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.AInputPassword);
            this.Controls.Add(this.AInputLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AInputLogin;
        private System.Windows.Forms.TextBox AInputPassword;
        private System.Windows.Forms.Button Entry;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

