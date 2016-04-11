using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class Departamento
    {
        public String Descricao { get; set; }
        public int ID_Departamento  { get; set; }
        public static int Cont { get; private set; }

        public Departamento(string Descricao)
        {
            try
            {
                Departamento.Cont++;
                ID_Departamento = Departamento.Cont;
                this.Descricao = Descricao;
             
            }
            catch (Exception)
            {
                Departamento.Cont--;
                throw new Exception("Erro ao criar o objeto");
            }
        }

    }
}
