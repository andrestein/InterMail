using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data.SqlClient;


namespace InterMail
{
    public partial class Login : Form
    {
        OracleConnection conn = new OracleConnection("Data Source=XE;Persist Security Info=True;User ID=system;Password=andres27041997;Unicode=True");
        DataSet ds;
        string SQL;

        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {
                string user;
                string pass;                
                if(txtUsuario.Text != "" && txtPass.Text != "")
                {
                    user=txtUsuario.Text;
                    pass=txtPass.Text;
                    SQL= "Select * from USUARIO WHERE USERNAME='" + user
                    + "' and PASS='" + pass + "';";
                    OracleDataAdapter data = new OracleDataAdapter(SQL, conn);
                    ds = new DataSet("USUARIO");
                    data.Fill(ds);                    
                    if (ds.Tables.Count != 0)
                    {
                        MessageBox.Show("Existe el usuario");
                    }
                    else
                    {
                        MessageBox.Show("Datos invalidos");
                    }                              
                }                
            }
            catch
            {
                MessageBox.Show("No se pudo conectar con la base de datos");
            }
        }    
    }
}
