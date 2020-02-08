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
using System.Security.Cryptography;


namespace PrincessPasswordKeeper
{
    public partial class frmNewPassword : Form
    {
        SqlConnection con = new SqlConnection(@"Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=PasswordKeeper;Data Source=DESKTOP-3VUU2NR\SQLEXPRESS;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record
        int ID = 0;

        public frmNewPassword()
        {
            InitializeComponent();
            DisplayData();
        }

        private void frmNewPassword_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'passwordKeeperDataSet.senhas' table. You can move, or remove it, as needed.
            this.senhasTableAdapter.Fill(this.passwordKeeperDataSet.senhas);
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            lblChars.Text = txtNotes.Text.Length.ToString();
        }

        //Display Data in DataGridView
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Senhas", con);
            adapt.Fill(dt);
            dgvList.DataSource = dt;
            con.Close();
        }

        //Clear Data 
        private void ClearData()
        {
            cmbType.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
            txtNotes.Text = "";
            tstxtSearch.Text = "";
            ID = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                if (cmbType.Text != "" && txtUser.Text != "" && txtPassword.Text != "")
                {
                    cmd = new SqlCommand("INSERT INTO Senhas (tipo, usuario, senha, notas) VALUES ('" + cmbType.Text + "', '" + txtUser.Text + "', '" + txtPassword.Text + "', '" + txtNotes.Text + "')", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@tipo", cmbType.Text);
                    cmd.Parameters.AddWithValue("@usuario", txtUser.Text);
                    cmd.Parameters.AddWithValue("@senha", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@notas", txtNotes.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    tssStatus.Text = "Registro inserido com sucesso!";
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!");
                }
            }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Senhas WHERE UPPER(usuario) LIKE '" + tstxtSearch.Text + "%'", con);
            adapt.Fill(dt);
            dgvList.DataSource = dt;
            con.Close();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Tem certeza?", "Apagar", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes && ID != 0)
            {
                cmd = new SqlCommand("DELETE Senhas WHERE ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                tssStatus.Text = "Registro apagado com sucesso!";
                DisplayData();
                ClearData();
            }
        }        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbType.Text != "" && txtUser.Text != "" && txtPassword.Text != "")
            {
                cmd = new SqlCommand("UPDATE Senhas SET tipo=@tipo, usuario=@usuario, senha=@senha, notas=@notas WHERE ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@tipo", cmbType.Text);
                cmd.Parameters.AddWithValue("@usuario", txtUser.Text);
                cmd.Parameters.AddWithValue("@senha", txtPassword.Text);
                cmd.Parameters.AddWithValue("@notas", txtNotes.Text);
                cmd.ExecuteNonQuery();
                tssStatus.Text = "Registro atualizado com sucesso!";
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Selecione o registro a ser atualizado.");
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtGeneratedPassword.Text);
            txtPassword.Text = Clipboard.GetText();
            tabControl1.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtGeneratedPassword.Text = RandomPassword(Convert.ToInt32(numericPassLenght.Value));
        }
        
        public string RandomPassword(int length)
        {
            const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
            const string Digits = "0123456789";
            const string SpecialCharacters = @"~!@#$%^&*():;[]{}<>,.?/\|";

            // Make a list of allowed characters.
            string allowed = "";
            if (cbNumbers.Checked) allowed = Digits;
            if (cbSpecialChar.Checked) allowed = SpecialCharacters;
            if (cbUpperCasing.Checked) allowed = CapitalLetters;
            if (cbLowerCasing.Checked) allowed = SmallLetters;

            // Satisfy requirements.
            string password = "";
            if (cbNumbers.Checked &&
                (password.IndexOfAny(Digits.ToCharArray()) == -1))
                password += RandomChar(Digits);
            if (cbSpecialChar.Checked &&
                (password.IndexOfAny(SpecialCharacters.ToCharArray()) == -1))
                password += RandomChar(SpecialCharacters);
            if (cbUpperCasing.Checked &&
                (password.IndexOfAny(CapitalLetters.ToCharArray()) == -1))
                password += RandomChar(CapitalLetters);
            if (cbLowerCasing.Checked &&
                (password.IndexOfAny(SmallLetters.ToCharArray()) == -1))
                password += RandomChar(SmallLetters);

            // Add the remaining characters randomly.
            while (password.Length < Convert.ToInt32(numericPassLenght.Value))
                password += RandomChar(allowed);

            // Randomize (to mix up the required characters at the front).
            password = RandomizeString(password);

            return password;
        }

        private string RandomChar(string str)
        {
            return str.Substring(Crypto.RandomInteger(0, str.Length - 1), 1);
        }

        // Return a random permutation of a string.
        private string RandomizeString(string str)
        {
            string result = "";
            while (str.Length > 0)
            {
                // Pick a random character.
                int i = Crypto.RandomInteger(0, str.Length - 1);
                result += str.Substring(i, 1);
                str = str.Remove(i, 1);
            }
            return result;
        }

        private void dgvList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbType.Text = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUser.Text = dgvList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgvList.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNotes.Text = dgvList.Rows[e.RowIndex].Cells[4].Value.ToString();
            ID = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[0].Value.ToString());

            btnUpdate.Enabled = true;
            tsbDelete.Enabled = true;
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            DisplayData();
            ClearData();
        }
    }
}
