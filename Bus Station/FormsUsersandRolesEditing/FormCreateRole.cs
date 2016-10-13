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
    public partial class FormCreateRole : Form
    {
        public UsersEditing UEForm { get; set; }
        public string Rolename { get; set; }
        public FormCreateRole()
        {
            InitializeComponent();
        }

        private void bCanscel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbRoleName.Text != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Fill in all the fields");
        }

        private void FormCreateRole_Load(object sender, EventArgs e)
        {
            tbRoleName.Text = Rolename;
        }

        private void FormCreateRole_FormClosing(object sender, FormClosingEventArgs e)
        {
            UEForm.Visible = true;
        }
    }
}
