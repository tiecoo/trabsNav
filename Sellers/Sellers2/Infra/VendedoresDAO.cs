using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Sellers2.Domain;

namespace Sellers2.Infra
{
    public class VendedoresDAO
    {
        public bool Insere(Vendedores v)
        {
                DAL dal = new DAL();

                using (var cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO Vendedores (Nome,CPF,Telefone,Celular, Nick) VALUES (@nome,@cpf,@tel,@cel, @nick)", dal.sqlCon))
                {

                    cmd.Parameters.AddWithValue("@nome", v.nome);
                    cmd.Parameters.AddWithValue("@cpf", v.cpf);
                    cmd.Parameters.AddWithValue("@tel", v.tel);
                    cmd.Parameters.AddWithValue("@cel", v.cel);
                    cmd.Parameters.AddWithValue("@nick", v.nick);
                    cmd.ExecuteNonQuery();

                }
                return true;
         
        }

        public Vendedores Recupera(int id)
        {
            DAL dal = new DAL();
            using (var cmd = new SqlCommand("SELECT * FROM Vendedores WHERE id = " + id, dal.sqlCon))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    var nome = reader["Nome"].ToString();
                    var cpf = reader["CPF"].ToString();
                    var tel = reader["Telefone"].ToString();
                    var cel = reader["Celular"].ToString();
                    var nick = reader["Nick"].ToString();

                    return new Vendedores(id, cpf, nome, tel, cel, nick);
                }
            }
        }

        public void Atualiza(Vendedores v)
        {
            DAL dal = new DAL();
            using (var cmd = new SqlCommand("UPDATE Vendedores SET Nome = @nome, CPF = @cpf, Telefone = @tel, Celular = @cel, Nick = @nick WHERE id = @id", dal.sqlCon))
            {
                cmd.Parameters.AddWithValue("@nome", v.nome);
                cmd.Parameters.AddWithValue("@cpf", v.cpf);
                cmd.Parameters.AddWithValue("@tel", v.tel);
                cmd.Parameters.AddWithValue("@cel", v.cel);
                cmd.Parameters.AddWithValue("@nick", v.nick);
                cmd.Parameters.AddWithValue("@id", v.id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            DAL dal = new DAL();
            using (var cmd = new SqlCommand("DELETE FROM Vendedores WHERE id = @id", dal.sqlCon))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

        }
    }
}
