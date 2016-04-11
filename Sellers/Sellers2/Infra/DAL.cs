using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sellers2.Infra
{
    public class DAL : IDisposable
    {
        public SqlConnection sqlCon { get; private set; }

        public DAL()
        {
            sqlCon = new SqlConnection(DB.Default.conString);
            sqlCon.Open();
        }

        public void Dispose()
        {
            sqlCon.Close();
        }
    }
}
