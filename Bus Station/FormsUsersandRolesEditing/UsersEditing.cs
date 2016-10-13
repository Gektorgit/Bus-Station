using Bus_Station.FormsUsersandRolesEditing;
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
        public MainForm MForm { get; set; }
        public UsersEditing()
        {
            InitializeComponent();
            GetUsers();
        }

        private void tabCUserAndRoles_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabCUserAndRoles.SelectedTab.Text)
	        {
                case "Users":
                    GetUsers();
                    break;
                case "Roles":
                    GetRoles();
                    break;
                case "UserinRoles":
                    UserRepository repository = new UserRepository();
                    cbUsers.DisplayMember = "UserName";
                    cbUsers.ValueMember = "UserId";
                    cbUsers.DataSource = repository.GetAll();
                    GetUserRoles(cbUsers.SelectedValue, 0);
                    break;
		        default:
                    break;
	        }
        }

        private void GetUsers()
        {
            UserRepository usrep = new UserRepository();
            bindingSourceUserinRoles.DataSource = usrep.GetAll().ToList();
            dgvUsers.DataSource = bindingSourceUserinRoles;
            dgvUsers.Columns["UserInRoles"].Visible = false;
            dgvUsers.Columns["UserId"].Visible = false;
        }

        private void GetRoles()
        {
            RoleRepository rolrep = new RoleRepository();
            bindingSourceUserinRoles.DataSource = rolrep.GetAll().ToList();
            dgvRoles.DataSource = bindingSourceUserinRoles;
            dgvRoles.Columns["RoleId"].Visible = false;
            dgvRoles.Columns["UserInRoles"].Visible = false;
        }

        private void GetUserRoles(object obj, object obj2)
        {
            BusinessUserInRolesRepository brep = new BusinessUserInRolesRepository();
            bindingSourceUserinRoles.DataSource = brep.GetAll(Convert.ToInt32(obj), Convert.ToInt32(obj2));
            dgvUserinRoles.DataSource = bindingSourceUserinRoles;
            dgvUserinRoles.Columns["UserId"].Visible = false;
            dgvUserinRoles.Columns["RoleId"].Visible = false;
            dgvUserinRoles.Columns["UserInRoleId"].Visible = false;
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUserRoles(cbUsers.SelectedValue, 0);
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            BusinessUserInRoles obj = new BusinessUserInRoles();
            obj.UserId = Convert.ToInt32(cbUsers.SelectedValue);

            FormEditUserInRoles feuir = new FormEditUserInRoles();
            feuir.UEForm = this;
            this.Visible = false;
            if (feuir.ShowDialog() == DialogResult.OK)
            {
                obj.RoleId = Convert.ToInt32(feuir.cbRoles.SelectedValue);
                obj.HireDate = feuir.dtpHireDate.Value.Date;
                BusinessUserInRolesRepository brep = new BusinessUserInRolesRepository();
                brep.Create(obj);
                GetUserRoles(obj.UserId, 0);
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dgvUserinRoles.SelectedCells != null)
            {
                DialogResult result = MessageBox.Show("Удалить   запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result.ToString() == "Yes")
                {
                    BusinessUserInRoles obj = new BusinessUserInRoles();
                    obj = bindingSourceUserinRoles.Current as BusinessUserInRoles;
                    BusinessUserInRolesRepository brep = new BusinessUserInRolesRepository();
                    brep.Delete(obj);
                    GetUserRoles(cbUsers.SelectedValue, 0);
                }
                
            }
        }

        private void bRoleCreate_Click(object sender, EventArgs e)
        {
            FormCreateRole crRole = new FormCreateRole();
            crRole.UEForm = this;
            this.Visible = false;
            if (crRole.ShowDialog() == DialogResult.OK)
            {
                BusStationEntities context = new BusStationEntities();
                Roles role = new Roles();
                role.RoleName = crRole.tbRoleName.Text;
                context.Roles.Add(role);
                context.SaveChanges();
                MessageBox.Show("Role Add");
                GetRoles();
            }
        }

        private void bRoleEdit_Click(object sender, EventArgs e)
        {
            FormCreateRole crRole = new FormCreateRole();

            RoleRepository roleRep = new RoleRepository();
            Roles role = bindingSourceUserinRoles.Current as Roles;
            List<BusinessUserInRoles> busUsinRol = new List<BusinessUserInRoles>();

            crRole.Rolename = role.RoleName;
            crRole.UEForm = this;
            this.Visible = false;
            if (crRole.ShowDialog() == DialogResult.OK)
            {
                busUsinRol = DeleteUserinRoles(role); // Удаляем связи роли с пользователями
                roleRep.Delete(role);
                role = new Roles();
                role.RoleName = crRole.tbRoleName.Text;
                roleRep.Create(role);
                MessageBox.Show("Role Edit");
                GetRoles();

                if (busUsinRol.Count > 0)
                {
                    BusinessUserInRoles obj = new BusinessUserInRoles();
                    BusinessUserInRolesRepository brep = new BusinessUserInRolesRepository();
                    obj.RoleId = role.RoleId;
                    for (int i = 0; i < busUsinRol.Count; i++)
                    {
                        obj.UserId = busUsinRol[i].UserId;
                        obj.HireDate = busUsinRol[i].HireDate;
                        brep.Create(obj);
                    }
                }
            }
        }

        private void bRoleDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить   запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result.ToString() == "Yes")
            {
                Roles role = bindingSourceUserinRoles.Current as Roles;
                DeleteUserinRoles(role);

                RoleRepository rr = new RoleRepository();
                rr.Delete(role);
                GetRoles();
                MessageBox.Show("Role Delete");
            }

            
        }

        private void bUserCreate_Click(object sender, EventArgs e)
        {
            FormCreateUser crUser = new FormCreateUser();
            crUser.UEForm = this;
            this.Visible = false;
            if (crUser.ShowDialog() == DialogResult.OK)
            {
                UserRepository usrep = new UserRepository();
                Users user = new Users();
                user.UserName = crUser.tbUserName.Text;
                user.UserPassword = crUser.tbUserPassword.Text;
                user.DateBirthday = crUser.dtpDateBirthday.Value.Date;
                user.FirstName = crUser.tbFirstName.Text;
                user.LastName = crUser.tbLastName.Text;
                user.Telephon = crUser.tbTelephon.Text;
                usrep.Create(user);
                MessageBox.Show("User Add");
                GetUsers();
            }
        }

        private void bUserEdit_Click(object sender, EventArgs e)
        {

            FormCreateUser crUser = new FormCreateUser();

            UserRepository userRep = new UserRepository();
            Users user = bindingSourceUserinRoles.Current as Users;
            List<BusinessUserInRoles> busUsinRol = new List<BusinessUserInRoles>();

            crUser.UserName = user.UserName;
            crUser.UserPassword = user.UserPassword;
            crUser.DateBirthday = user.DateBirthday;
            crUser.FirstName = user.FirstName;
            crUser.LastName = user.LastName;
            crUser.Telephon = user.Telephon;
            crUser.UEForm = this;
            this.Visible = false;
            if (crUser.ShowDialog() == DialogResult.OK)
            {
                busUsinRol = DeleteUserinRoles(user);// Удаляем связи пользователя с ролями
                userRep.Delete(user);
                user = new Users();
                user.UserName = crUser.tbUserName.Text;
                user.UserPassword = crUser.tbUserPassword.Text;
                user.DateBirthday = crUser.dtpDateBirthday.Value.Date;
                user.FirstName = crUser.tbFirstName.Text;
                user.LastName = crUser.tbLastName.Text;
                user.Telephon = crUser.tbTelephon.Text;
                userRep.Create(user);
                MessageBox.Show("User Edit");
                GetUsers();

                if (busUsinRol.Count > 0)
                {
                    BusinessUserInRoles obj = new BusinessUserInRoles();
                    BusinessUserInRolesRepository brep = new BusinessUserInRolesRepository();
                    obj.UserId = user.UserId;

                    for (int i = 0; i < busUsinRol.Count; i++)
                    {
                        obj.RoleId = busUsinRol[i].RoleId;
                        obj.HireDate = busUsinRol[i].HireDate;
                        brep.Create(obj);
                    }
                }
            }
        }

        private void bUserDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить   запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result.ToString() == "Yes")
            {
                Users user = bindingSourceUserinRoles.Current as Users;
                DeleteUserinRoles(user);

                UserRepository ur = new UserRepository();
                ur.Delete(user);
                GetUsers();
                MessageBox.Show("User Delete");
            } 
        }

        private List<BusinessUserInRoles> DeleteUserinRoles(Users user) // Метод для удаления связи между пользователями и ролями
        {
            List<BusinessUserInRoles> busUsinRol = new List<BusinessUserInRoles>();

            int UserId = user.UserId;
            GetUserRoles(UserId, 0);
            BusinessUserInRoles obj = new BusinessUserInRoles();
            BusinessUserInRolesRepository brep = new BusinessUserInRolesRepository();
            while (bindingSourceUserinRoles.Current != null)
            {
                obj = bindingSourceUserinRoles.Current as BusinessUserInRoles;
                busUsinRol.Add(obj);
                brep.Delete(obj);
                GetUserRoles(UserId, 0);
            }
            return busUsinRol;
        }

        private List<BusinessUserInRoles> DeleteUserinRoles(Roles role) // Метод для удаления связи между ролями и пользователями
        {
            List<BusinessUserInRoles> busUsinRol = new List<BusinessUserInRoles>();

            int RoleId = role.RoleId;
            GetUserRoles(0, RoleId);
            BusinessUserInRoles obj = new BusinessUserInRoles();
            BusinessUserInRolesRepository brep = new BusinessUserInRolesRepository();
            while (bindingSourceUserinRoles.Current != null)
            {
                obj = bindingSourceUserinRoles.Current as BusinessUserInRoles;
                busUsinRol.Add(obj);
                brep.Delete(obj);
                GetUserRoles(0, RoleId);
            }
            return busUsinRol;
        }

        private void UsersEditing_FormClosing(object sender, FormClosingEventArgs e)
        {
            MForm.Visible = true;
        }
    }
}
