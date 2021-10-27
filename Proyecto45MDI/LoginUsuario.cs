using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // para poder utilizar las clases de conexion
namespace Proyecto45MDI
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private void ChkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkMostrar.Checked==true)
            {
                txtContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
            }

        }
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string cadena = "data source = SQL5103.site4now.net ; initial catalog =db_a7acff_usuarios; user id = db_a7acff_usuarios_admin; password = Lima2020";
            SqlConnection Ocon = new SqlConnection(cadena);
            Ocon.Open();
            string SQLConsul = "select Estado from Usuarios where Usuario = '"+ txtUsuario.Text +"' and Password = '"+ txtContra.Text +"'";
            SqlCommand Ocoman = new SqlCommand(SQLConsul , Ocon);
            Ocoman.CommandType = CommandType.Text;
            int escalar = Convert.ToInt32(Ocoman.ExecuteScalar());
            if (escalar == 1)
            {
                Form1 MiFormlulario = new Form1();
                MiFormlulario.Show();
            }
            else if (escalar==2)
            {
                MessageBox.Show("El usuario esta Deshabilitado");
            }
            else if (escalar==0)
            {
                MessageBox.Show("El Usuario / Contraseña no existen ");
            }
            Ocon.Close();
        }
    }
}