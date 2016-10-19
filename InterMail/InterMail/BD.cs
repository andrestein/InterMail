using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Data;

namespace InterMail
{
    class BD
    {
        string conexion = "Data Source=XE;Persist Security Info=True;User ID=system;Password=andres27041997;Unicode=True";
        string SQL;
        OracleDataAdapter adaptador = new OracleDataAdapter();
        DataTable tab = new DataTable();

        public bool Buscar(string user, string pass)
        {
            SQL = "SELECT * "+
            "FROM USUARIO "+
            "WHERE USERNAME='" + user + "' AND PASS='" + pass + "';";
            adaptador = new OracleDataAdapter(SQL, conexion);
            adaptador.Fill(tab);
            if (tab.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
    }
}
