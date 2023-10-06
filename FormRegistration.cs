using Desctop.Models;
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
    public partial class FormRegistration : Form
    {
        private FormLogin formLogin = new FormLogin();
        string name, surname, patron, PhonNumber;
        public string login, password;
        public FormRegistration()
        {
            InitializeComponent();
        }
        
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            formLogin.Show();
            this.Close();
        }

        private void btSaveAndLog_Click(object sender, EventArgs e)
        {
            if (textName.Text.Length == 0 || textSurname.Text.Length == 0 || textPhone.Text.Length == 0) {
                MessageBox.Show("Вы указали не все данные");
            }
            else
            {   //работа с базой данных
                using (Beton_MishaContext db = new Beton_MishaContext()) { 
                    User user = new User
                    { 
                        name = textName.Text,
                        surname = textSurname.Text,
                        patronymic = textPatronymic.Text,
                        phone_namber = textPhone.Text,
                        login = login,
                        password = password,
                    };
                    db.User.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Данные сохранены");
                      
                }
                formLogin.Show();
                this.Close();
            }
        }
    }
}
