using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.Repository
{
    public class Conexao
    {
        public SqlConnection cn = new SqlConnection();

        public void Conectar()
        {
            string s = "";
            s = "Server=DESKTOP-PQSDVH0\\SQLEXPRESS;Database=GERENTE_EFICAZ;UID=sa;PWD=123;";
            cn.ConnectionString = s;
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
        }
    }
}
