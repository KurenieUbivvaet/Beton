namespace Desctop
{
    partial class FormRegData
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btResume = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.labelRtPas = new System.Windows.Forms.Label();
            this.textRtPassword = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(52, 94);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(49, 15);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(53, 52);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(41, 15);
            this.labelLogin.TabIndex = 11;
            this.labelLogin.Text = "Логин";
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(52, 70);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(190, 23);
            this.textLogin.TabIndex = 10;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(52, 112);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(190, 23);
            this.textPassword.TabIndex = 9;
            // 
            // btResume
            // 
            this.btResume.Location = new System.Drawing.Point(134, 184);
            this.btResume.Name = "btResume";
            this.btResume.Size = new System.Drawing.Size(109, 23);
            this.btResume.TabIndex = 8;
            this.btResume.Text = "Продолжить";
            this.btResume.UseVisualStyleBackColor = true;
            this.btResume.Click += new System.EventHandler(this.btResume_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(53, 184);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 7;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // labelRtPas
            // 
            this.labelRtPas.AutoSize = true;
            this.labelRtPas.Location = new System.Drawing.Point(53, 137);
            this.labelRtPas.Name = "labelRtPas";
            this.labelRtPas.Size = new System.Drawing.Size(109, 15);
            this.labelRtPas.TabIndex = 14;
            this.labelRtPas.Text = "Повторите пароль";
            // 
            // textRtPassword
            // 
            this.textRtPassword.Location = new System.Drawing.Point(52, 155);
            this.textRtPassword.Name = "textRtPassword";
            this.textRtPassword.PasswordChar = '*';
            this.textRtPassword.Size = new System.Drawing.Size(190, 23);
            this.textRtPassword.TabIndex = 13;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(52, 213);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(189, 23);
            this.btExit.TabIndex = 15;
            this.btExit.Text = "Выйти";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FormRegData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 275);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.labelRtPas);
            this.Controls.Add(this.textRtPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.btResume);
            this.Controls.Add(this.btBack);
            this.Name = "FormRegData";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPassword;
        private Label labelLogin;
        private TextBox textLogin;
        private TextBox textPassword;
        private Button btResume;
        private Button btBack;
        private Label labelRtPas;
        private TextBox textRtPassword;
        private Button btExit;
    }
}