using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrimeGorilaDesktop.Forms
{
    public partial class MainForm : Form
    {
        private dynamic usuario;

        public MainForm(dynamic user)
        {
            usuario = user;
            InitializeComponent();
        }
    }
}
