using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sellers2.Infra;

namespace Sellers2.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logon_Click(object sender, EventArgs e)
        {
            LoginDAO lDAO = new LoginDAO();
            if (lDAO.autentica(nick.Text, password.Text) == 1)
            {
                Main m = new Main();
                m.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
