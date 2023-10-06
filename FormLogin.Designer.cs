namespace Desctop
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLog = new System.Windows.Forms.Button();
            this.btRegistration = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLog
            // 
            this.btLog.Location = new System.Drawing.Point(55, 133);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(75, 23);
            this.btLog.TabIndex = 0;
            this.btLog.Text = "Войти";
            this.btLog.UseVisualStyleBackColor = true;
            // 
            // btRegistration
            // 
            this.btRegistration.Location = new System.Drawing.Point(136, 133);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(109, 23);
            this.btRegistration.TabIndex = 1;
            this.btRegistration.Text = "Регистрация";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(55, 162);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(189, 23);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Выйти";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(55, 104);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(190, 23);
            this.textPassword.TabIndex = 3;
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(55, 62);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(190, 23);
            this.textLogin.TabIndex = 4;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(56, 44);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(41, 15);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(56, 86);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(49, 15);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Пароль";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 275);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.btLog);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btLog;
        private Button btRegistration;
        private Button btExit;
        private TextBox textPassword;
        private TextBox textLogin;
        private Label labelLogin;
        private Label labelPassword;
    }
}