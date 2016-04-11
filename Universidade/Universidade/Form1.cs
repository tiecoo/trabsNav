using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universidade
{
    public partial class Main : Form
    {

        public List<Departamento> listaDepartamento { get; set; }
        public List<Professor> listaProfessor { get; set; }


        public Main()
        {
            InitializeComponent();
            listaDepartamento = new List<Departamento>();
            listaProfessor = new List<Professor>();
            GeraDados();

            dataGridDep.DataSource = listaDepartamento;
            dataGridProf.DataSource = listaProfessor;
            lblProfCount.Text = listaProfessor.Count+" registro(s) encontrados";
            lblDepCount.Text = listaDepartamento.Count + " registro(s) encontrados";
        }
         
        private void GeraDados()
        {
            listaDepartamento = new List<Departamento>();
            listaProfessor = new List<Professor>();

            Departamento[] deps = { 
                new Departamento("Sistemas de Informação"), 
                new Departamento("Ciencia da Computação"),
                new Departamento("Engenharia de Produção"),
                new Departamento("Sistemas de Informação"),
                new Departamento("Ciencia da Computação"),
                new Departamento("Engenharia de Produção"),
                new Departamento("Administração"),
                new Departamento("Direito"),
                new Departamento("Odontologia"),
                new Departamento("Enfermagem"),
                new Departamento("Medicina"),
            };

            for (int i = 0; i < deps.Length; i++)
                listaDepartamento.Add(deps[i]);
            
            listaProfessor.Add(new Professor("Bugatti", ( new Departamento[]{ deps[0], deps[1]}) ));
            listaProfessor.Add(new Professor("Elvis", new Departamento[] { deps[3] } ));
            listaProfessor.Add(new Professor("Giulliana", new Departamento[]{ deps[4] }));
            listaProfessor.Add(new Professor("Rodolfo", new Departamento[]{ deps[2],deps[7]}));
            listaProfessor.Add(new Professor("Sabatine", new Departamento[]{ deps[9] } ));
            listaProfessor.Add(new Professor("Mauricio", new Departamento[]{ deps[6], deps[10]}));
            listaProfessor.Add(new Professor("Renata", new Departamento[]{ deps[9],deps[3],deps[6]}));
            listaProfessor.Add(new Professor("Jorge", new Departamento[]{ deps[8], deps[3], deps[1]}));
            listaProfessor.Add(new Professor("Elton", new Departamento[]{ deps[3]}));
        }

        private void listarBtn_Click(object sender, EventArgs e)
        {
            if (txtProfessor.Text.Equals("")) // Reseta Find
            {
                dataGridDep.DataSource = listaDepartamento;
                lblDepCount.Text = listaDepartamento.Count + " registro(s) encontrados";
            }
            else
            {
                Professor p = listaProfessor.SingleOrDefault(x => x.ID_Professor == Int32.Parse(txtProfessor.Text));
                List<Departamento> ld = new List<Departamento>();

                for (int i = 0; i < p.dep.Length; i++)
                {
                    ld.Add(p.dep[i]);

                }
                dataGridDep.DataSource = ld;
                dataGridDep.Refresh();
                lblDepCount.Text = ld.Count + " registro(s) encontrados";
            }


        }
    }
}
