using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellers2.Domain
{
    public class Vendedores
    {
       public int id { get; set; }
       public string nome { get; set; }
       public string cpf { get; set; }
       public string tel { get; set; }
       public string cel { get; set; }
       public string nick { get; set; }

       public Vendedores(int id, string cpf, string nome, string tel, string cel, string nick)
       {
           this.id = id;
           this.nome = nome;
           this.cpf = cpf;
           this.tel = tel;
           this.cel = cel;
           this.nick = nick;
       }
        public Vendedores(string cpf, string nome, string tel, string cel, string nick)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.tel = tel;
            this.cel = cel;
            this.nick = nick;
        }
    }
}
