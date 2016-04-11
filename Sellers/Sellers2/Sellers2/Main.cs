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
using Sellers2.Domain;

namespace Sellers2.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            Vendedores v = new Vendedores(nome.Text, cpf.Text, tel.Text, cel.Text, nick.Text);
            VendedoresDAO vDAO = new VendedoresDAO();
            vDAO.Insere(v);
            MessageBox.Show("Vendedor Inserido!");
            refreshGrid();
        }

        public void refreshGrid()
        {
            this.vendedoresTableAdapter.Fill(this.sellersDataSet.Vendedores);

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            int id = Int32.Parse(row.Cells[0].Value.ToString());
            Update uf = new Update(this, id);
            uf.Show();
        }
    }
}
