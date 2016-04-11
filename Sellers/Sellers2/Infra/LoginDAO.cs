using Sellers2.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sellers2.Infra
{
    public class LoginDAO
    {
        public int autentica(string n, string s)
        {
            DAL dal = new DAL();
            var sql = "SELECT COUNT(*) FROM Usuarios WHERE nick = @nick AND senha = @senha";
            var cmd = new System.Data.SqlClient.SqlCommand(sql, dal.sqlCon);
            cmd.Parameters.AddWithValue("@nick", n);
            cmd.Parameters.AddWithValue("@senha", s);
            Int32 count = (Int32)cmd.ExecuteScalar();
            return count;
        }

    }
}
