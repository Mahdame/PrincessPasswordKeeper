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
    public partial class frmMain : Form
    {
        string loginUser;

        public frmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssDate.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tssUser.Text = frmLogin.loginUser;
        }

        private void tsmNew_Click(object sender, EventArgs e)
        {
            frmNewPassword newPassword = new frmNewPassword();
            newPassword.Show();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Tem certeza?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
                Application.Exit();
        }
        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
        }
    }
}
