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
        private BD bd = new BD();
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
                    user=txtUsuario.Text.ToUpper();
                    pass=txtPass.Text.ToUpper();

                    if (/*bd.Buscar(user, pass)*/true)
                    {
                        BandejaEntrada bandejaEntrada = new BandejaEntrada(user);
                        txtUsuario.Text = "";
                        txtPass.Text = "";
                        this.Hide();
                        bandejaEntrada.Show();
                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados no son validos");
                    }
                }                
            }
            catch
            {
                MessageBox.Show("No se pudo conectar con la base de datos");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string mensaje = "¿Seguro que desea salir?";
            const string cas = "Deseas cerrar";
            var result = MessageBox.Show(mensaje, cas, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }    
    }
}
