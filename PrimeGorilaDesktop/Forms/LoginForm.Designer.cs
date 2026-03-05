using System.Drawing;
using System.Windows.Forms;

namespace PrimeGorilaDesktop.Forms
{
    partial class LoginForm
    {
        private Label lblTitulo;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnLogin;

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.txtEmail = new TextBox();
            this.txtSenha = new TextBox();
            this.btnLogin = new Button();

            // Form
            this.BackColor = ColorTranslator.FromHtml("#0f0b13");
            this.ClientSize = new Size(350, 350);
            this.Text = "Prime Gorila - Login";

            // Título
            lblTitulo.Text = "LOGIN";
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitulo.Location = new Point(120, 40);

            // Email
            txtEmail.Location = new Point(50, 120);
            txtEmail.Width = 250;
            txtEmail.BackColor = Color.Black;
            txtEmail.ForeColor = Color.White;

            // Senha
            txtSenha.Location = new Point(50, 170);
            txtSenha.Width = 250;
            txtSenha.PasswordChar = '*';
            txtSenha.BackColor = Color.Black;
            txtSenha.ForeColor = Color.White;

            // Botão
            btnLogin.Text = "Entrar";
            btnLogin.Location = new Point(50, 230);
            btnLogin.Width = 250;
            btnLogin.BackColor = ColorTranslator.FromHtml("#3a0bd6");
            btnLogin.ForeColor = Color.White;
            btnLogin.Click += btnLogin_Click;

            this.Controls.Add(lblTitulo);
            this.Controls.Add(txtEmail);
            this.Controls.Add(txtSenha);
            this.Controls.Add(btnLogin);
        }
    }
}
