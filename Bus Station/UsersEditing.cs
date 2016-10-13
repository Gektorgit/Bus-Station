using DataBase.BusinessLayer;
using DataBase.DataBaseBuses;
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
    public partial class UsersEditing : Form
    {
        BusStationEntities context = new BusStationEntities();
        public UsersEditing()
        {
            InitializeComponent();
            bindingSourceUserinRoles.DataSource = context.Users.ToList();
            dgvUsers.DataSource = bindingSourceUserinRoles;
        }

        private void UsersEditing_Load(object sender, EventArgs e)
        {
            
        }

        private void tabCUserAndRoles_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabCUserAndRoles.SelectedTab.Text)
	        {
                case "Users":
                    bindingSourceUserinRoles.DataSource = context.Users.ToList();
                    dgvUsers.DataSource = bindingSourceUserinRoles;
                    break;
                case "Roles":
                    bindingSourceUserinRoles.DataSource = context.Roles.ToList();
                    dgvRoles.DataSource = bindingSourceUserinRoles;
                    break;
                case "UserinRoles":
                    UserRepository repository = new UserRepository();
                    var roles = repository.GetAll();
                    cbUsers.DisplayMember = "UserName";
                    cbUsers.ValueMember = "UserId";
                    cbUsers.DataSource = roles;
                    GetUserRoles(cbUsers.SelectedValue);
                    break;
		        default:
                    break;
	        }
        }
        private void GetUserRoles(object obj)
        {
            BusinessUserInRolesRepository brep = new BusinessUserInRolesRepository();
            bindingSourceUserinRoles.DataSource = brep.GetAll(Convert.ToInt32(obj));
            dgvUserinRoles.DataSource = bindingSourceUserinRoles;
            dgvUserinRoles.Columns["RoleId"].Visible = false;
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserRoles(cbUsers.SelectedValue);
        }
    }
}
