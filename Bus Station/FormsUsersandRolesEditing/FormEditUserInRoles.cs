using DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Station
{
    public partial class FormEditUserInRoles : Form
    {
        public UsersEditing UEForm { get; set; }
        public FormEditUserInRoles()
        {
            InitializeComponent();
        }

        private void FormEditUserInRoles_Load(object sender, EventArgs e)
        {
            RoleRepository rr = new RoleRepository();
            dtpHireDate.MinDate = DateTime.Now.Date;
            cbRoles.DisplayMember = "RoleName";
            cbRoles.ValueMember = "RoleId";
            cbRoles.DataSource = rr.GetAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormEditUserInRoles_FormClosing(object sender, FormClosingEventArgs e)
        {
            UEForm.Visible = true;
        }
    }
}
