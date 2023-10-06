namespace Desctop
{
    partial class FormRegistration
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btExit = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btSaveAndLog = new System.Windows.Forms.Button();
            this.btLogIn = new System.Windows.Forms.Button();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textPatronymic = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Firebrick;
            this.splitContainer1.Panel1.Controls.Add(this.btExit);
            this.splitContainer1.Panel1.Controls.Add(this.labelPhone);
            this.splitContainer1.Panel1.Controls.Add(this.labelPatronymic);
            this.splitContainer1.Panel1.Controls.Add(this.labelSurname);
            this.splitContainer1.Panel1.Controls.Add(this.labelName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel2.Controls.Add(this.btSaveAndLog);
            this.splitContainer1.Panel2.Controls.Add(this.btLogIn);
            this.splitContainer1.Panel2.Controls.Add(this.textPhone);
            this.splitContainer1.Panel2.Controls.Add(this.textPatronymic);
            this.splitContainer1.Panel2.Controls.Add(this.textSurname);
            this.splitContainer1.Panel2.Controls.Add(this.textName);
            this.splitContainer1.Size = new System.Drawing.Size(548, 364);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 0;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(12, 324);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(78, 28);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Выйти";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPhone.Location = new System.Drawing.Point(0, 99);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(98, 13);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Номер телефона";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPatronymic.Location = new System.Drawing.Point(35, 70);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(58, 15);
            this.labelPatronymic.TabIndex = 2;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.BackColor = System.Drawing.Color.Firebrick;
            this.labelSurname.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSurname.Location = new System.Drawing.Point(35, 41);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(58, 15);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Firebrick;
            this.labelName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelName.Location = new System.Drawing.Point(62, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(31, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя";
            // 
            // btSaveAndLog
            // 
            this.btSaveAndLog.Location = new System.Drawing.Point(124, 324);
            this.btSaveAndLog.Name = "btSaveAndLog";
            this.btSaveAndLog.Size = new System.Drawing.Size(141, 28);
            this.btSaveAndLog.TabIndex = 8;
            this.btSaveAndLog.Text = "Сохранить и выйти";
            this.btSaveAndLog.UseVisualStyleBackColor = true;
            this.btSaveAndLog.Click += new System.EventHandler(this.btSaveAndLog_Click);
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(3, 324);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(115, 28);
            this.btLogIn.TabIndex = 7;
            this.btLogIn.Text = "Авторизоваться";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(3, 99);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(262, 23);
            this.textPhone.TabIndex = 3;
            // 
            // textPatronymic
            // 
            this.textPatronymic.Location = new System.Drawing.Point(3, 70);
            this.textPatronymic.Name = "textPatronymic";
            this.textPatronymic.Size = new System.Drawing.Size(262, 23);
            this.textPatronymic.TabIndex = 2;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(3, 41);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(262, 23);
            this.textSurname.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(3, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(262, 23);
            this.textName.TabIndex = 0;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 364);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox textPatronymic;
        private TextBox textSurname;
        private TextBox textName;
        private TextBox textPhone;
        private Label labelName;
        private Button btExit;
        private Label labelPhone;
        private Label labelPatronymic;
        private Label labelSurname;
        private Button btSaveAndLog;
        private Button btLogIn;
    }
}