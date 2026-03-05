using System;
using System.Windows.Forms;
using PrimeGorilaDesktop.Services;

namespace PrimeGorilaDesktop.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var api = new ApiService();
            var user = await api.Login(txtEmail.Text, txtSenha.Text);

            if (user == null)
            {
                MessageBox.Show("E-mail ou senha incorretos.");
                return;
            }

            Hide();
            new MainForm(user).Show();
        }
    }
}
