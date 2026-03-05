using System;
using System.Windows.Forms;

namespace PrimeGorilaDesktop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Forms.LoginForm());
        }
    }
}
