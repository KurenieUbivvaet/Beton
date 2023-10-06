namespace Desctop
{
    public partial class FormLogin : Form
    {
        

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            FormRegData frd = new FormRegData();
            frd.Show();
            this.Hide();
        }
    }
}