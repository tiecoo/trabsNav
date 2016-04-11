using Sellers2.Domain;
using Sellers2.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sellers2.View
{
    public partial class Update : Form
    {
        Vendedores v;
        Main m;

        public Update(Main m, int id)
        {
            VendedoresDAO vDAO = new VendedoresDAO();
            this.m = m;
            InitializeComponent();
            v = vDAO.Recupera(id);
            cel.Text = v.cel;
            cpf.Text = v.cpf;
            nome.Text = v.nome;
            tel.Text = v.tel;
            txtID.Text = id.ToString();
            nick.Text = v.nick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VendedoresDAO vDAO = new VendedoresDAO();
            vDAO.Atualiza(new Vendedores(Int32.Parse(txtID.Text), cpf.Text, nome.Text, tel.Text, cel.Text, lblnick.Text));
            m.refreshGrid();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VendedoresDAO vDAO = new VendedoresDAO();
            vDAO.Deletar(v.id);
            MessageBox.Show("Vendedor Excluido!");
            m.refreshGrid();
            this.Close();

        }
    }
}
