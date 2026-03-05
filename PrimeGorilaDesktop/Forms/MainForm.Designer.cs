using System.Drawing;
using System.Windows.Forms;

namespace PrimeGorilaDesktop.Forms
{
    partial class MainForm
    {
        private Label lblWelcome;

        private void InitializeComponent()
        {
            this.BackColor = ColorTranslator.FromHtml("#0f0b13");
            this.ClientSize = new Size(600, 400);
            this.Text = "Prime Gorila - Início";

            lblWelcome = new Label();
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Font = new Font("Segoe UI", 18);
            lblWelcome.Location = new Point(30, 30);
            lblWelcome.Text = "Bem-vindo!";

            this.Controls.Add(lblWelcome);
        }
    }
}
