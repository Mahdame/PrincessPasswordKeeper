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

namespace PrincessPasswordKeeper
{
    public partial class frmLogin : Form
    {
        static public string loginUser;
        string conexao = @"Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=PasswordKeeper;Data Source=DESKTOP-3VUU2NR\SQLEXPRESS;";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM usuarios WHERE usuario='" + txtLogin.Text + "' AND senha='" + txtPassword.Text + "'";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Autentication.enter(dr["usuario"].ToString(), dr["senha"].ToString());
                loginUser = dr["usuario"].ToString();
                this.Visible = false;

                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Erro: Usuário/Senha não encontrado.");
                txtLogin.Text = "";
                txtPassword.Text = "";
                txtLogin.Focus();
            }
            con.Close();
            dr.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
