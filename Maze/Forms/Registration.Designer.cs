namespace Maze
{
    partial class Registration
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
            this.RInputLogin = new System.Windows.Forms.TextBox();
            this.RInputPassword = new System.Windows.Forms.TextBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RConfirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(429, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // RInputLogin
            // 
            this.RInputLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RInputLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RInputLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RInputLogin.Location = new System.Drawing.Point(358, 174);
            this.RInputLogin.MaximumSize = new System.Drawing.Size(500, 90);
            this.RInputLogin.Multiline = true;
            this.RInputLogin.Name = "RInputLogin";
            this.RInputLogin.Size = new System.Drawing.Size(362, 36);
            this.RInputLogin.TabIndex = 1;
            // 
            // RInputPassword
            // 
            this.RInputPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RInputPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RInputPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RInputPassword.Location = new System.Drawing.Point(358, 263);
            this.RInputPassword.MaximumSize = new System.Drawing.Size(500, 90);
            this.RInputPassword.Multiline = true;
            this.RInputPassword.Name = "RInputPassword";
            this.RInputPassword.PasswordChar = '*';
            this.RInputPassword.Size = new System.Drawing.Size(362, 36);
            this.RInputPassword.TabIndex = 2;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegistration.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistration.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonRegistration.Location = new System.Drawing.Point(376, 479);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(326, 42);
            this.buttonRegistration.TabIndex = 4;
            this.buttonRegistration.Text = "Зарегистрироваться";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(372, 148);
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
            this.label4.Location = new System.Drawing.Point(813, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 206);
            this.label4.TabIndex = 7;
            this.label4.Text = " Логин должен состоять из 6-16 символов латиницы или цифр. \nПароль должен состоят" +
    "ь из 6-20 символов латиницы или цифр. ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(372, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Повторите пароль:";
            // 
            // RConfirmPassword
            // 
            this.RConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RConfirmPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RConfirmPassword.Location = new System.Drawing.Point(358, 359);
            this.RConfirmPassword.MaximumSize = new System.Drawing.Size(500, 90);
            this.RConfirmPassword.Multiline = true;
            this.RConfirmPassword.Name = "RConfirmPassword";
            this.RConfirmPassword.PasswordChar = '*';
            this.RConfirmPassword.Size = new System.Drawing.Size(362, 36);
            this.RConfirmPassword.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(813, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = " Памятка!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1104, 628);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RConfirmPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.RInputPassword);
            this.Controls.Add(this.RInputLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RInputLogin;
        private System.Windows.Forms.TextBox RInputPassword;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RConfirmPassword;
        private System.Windows.Forms.Label label6;
    }
}
