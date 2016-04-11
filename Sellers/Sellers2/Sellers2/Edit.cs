﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sellers2.Domain;
using Sellers2.Infra;

namespace Sellers2
{
    public partial class Edit : Form
    {

        Vendedores v;
        Main m;
        public Edit(Main m,int id)
        {
            VendedoresDAO vDAO = new VendedoresDAO();
            this.m = m;
            v = vDAO.Recupera(id);
            cel.Text = v.cel;
            cpf.Text = v.cpf;
            nome.Text = v.nome;
            id.Text = id.ToString();
            tel.Text = v.tel;
            nick.Text = v.nick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VendedoresDAO vDAO = new VendedoresDAO();
            vDAO.Atualiza(new Vendedores(Int32.Parse(id.Text), cpf.Text, nome.Text, tel.Text, cel.Text, nick.Text));
            m.refreshGrid();
            this.Close();
        }
    }
}
