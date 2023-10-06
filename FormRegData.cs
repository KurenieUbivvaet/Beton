using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desctop
{
    public partial class FormRegData : Form
    {
        private FormRegistration formReg = new FormRegistration();
        public FormRegData()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btResume_Click(object sender, EventArgs e)
        {
            bool errorInfo = false;
            if (errorInfo == false)
            {
                if (textLogin.Text.Length == 0)
                {
                    MessageBox.Show("Вы не ввели логин");
                    errorInfo = true;
                }

                if (textPassword.Text.Length == 0)
                {
                    MessageBox.Show("Вы не ввели Пароль");
                    errorInfo = true;
                }

                if (textRtPassword.Text.Length == 0)
                {
                    MessageBox.Show("Вы не повторили пароль ");
                    errorInfo = true;
                }

                if (textPassword.Text != textRtPassword.Text)
                {
                    MessageBox.Show("Пароли не совпадают");
                    errorInfo = true;
                }
                if (errorInfo == false) {                    
                    formReg.Show();
                    formReg.login = textLogin.Text;
                    formReg.password = textPassword.Text;
                    this.Close();
                }
            }
        }
    }
}
