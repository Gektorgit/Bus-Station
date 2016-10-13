using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Station.FormsUsersandRolesEditing
{
    public partial class FormCreateUser : Form
    {
        public UsersEditing UEForm { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime DateBirthday { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephon { get; set; }

        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void FormCreateUser_Load(object sender, EventArgs e)
        {
            DateBirthday = DateTime.Now.Date;
            tbUserName.Text = UserName;
            tbUserPassword.Text = UserPassword;
            dtpDateBirthday.Value = DateBirthday;
            tbFirstName.Text = FirstName;
            tbLastName.Text = LastName;
            tbTelephon.Text = Telephon;
        }

        private void bCanscel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != "" && tbUserPassword.Text != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Fill in all the fields");
        }

        private void tbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbUserPassword.Select();
        }

        private void tbUserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                dtpDateBirthday.Select();
        }

        private void dtpDateBirthday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbFirstName.Select();
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbLastName.Select();
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbTelephon.Select();
        }

        private void FormCreateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            UEForm.Visible = true;
        }
    }
}
