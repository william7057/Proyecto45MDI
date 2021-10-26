using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
           
        }
    }
}