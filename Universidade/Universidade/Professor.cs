using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class Professor
    {
        public String Nome { get; set; }
        public int ID_Professor { get; set; }
        public static int Contp { get; private set; }
        public Departamento[] dep { get; private set; }
        public static int Cont { get; private set; }

        public Professor(string Nome,Departamento[] deps)
        {
            try
            {
                Cont++;
                this.Nome = Nome;
                this.ID_Professor = Cont;
                dep = deps;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao criar o objeto");
            }
        }
    }


}
