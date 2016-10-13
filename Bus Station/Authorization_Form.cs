using DataBase.BusinessLayer;
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
    public partial class Authorization_Form : Form
    {
        public Authorization_Form()
        {
            InitializeComponent();
            //MetodClearOldDataBase();
        }

        private void Authorization_Form_Load(object sender, EventArgs e)
        {
            UserRepository ur = new UserRepository();
            cbLogin.ValueMember = "UserId";
            cbLogin.DisplayMember = "UserName";
            cbLogin.DataSource = ur.GetAll();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            UserRepository ur = new UserRepository();
            BusinessUserInRolesRepository Userrep = new BusinessUserInRolesRepository();
            this.DialogResult = DialogResult.OK;
            string password = ur.GetAll().Where(p => p.UserId == Convert.ToInt32(cbLogin.SelectedValue)).Select(p => p.UserPassword).First();
            DateTime maxdt = Userrep.GetAll(Convert.ToInt32(cbLogin.SelectedValue)).Where(p => p.HireDate <= DateTime.Now).Max(p => p.HireDate);
            string RoleName = Userrep.GetAll(Convert.ToInt32(cbLogin.SelectedValue)).Where(p => p.HireDate == maxdt).Select(p => p.RoleName).Last();
            
            if (RoleName == "Admin" && tbPassword.Text == password)
            {
                MainForm main = new MainForm();
                main.Show();
                main.AForm = this;
                this.Visible = false;
            }

            else if (RoleName == "Menedger" && tbPassword.Text == password)
            {
                MainForm main = new MainForm();
                main.bScheduleEditing.Visible = false;
                main.bUsersEditing.Visible = false;
                main.bTicket.Location = new Point(431, 13);
                main.bTicket.Height = 181;
                main.Show();
            }
            else if (RoleName == "User" && tbPassword.Text == password)
            {
                MainForm main = new MainForm();
                main.bScheduleEditing.Visible = false;
                main.bUsersEditing.Visible = false;
                main.bTicket.Visible = false;
                main.bExit.Location = new Point(431, 13);
                main.bExit.Height = 271 ;
                main.Show();
            }
            else
                MessageBox.Show("Invalid Password");
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                bOk.PerformClick();
        }

        private void MetodClearOldDataBase() // Метод для очистки Базы данных от старых рейсов и проданных билетов
        {
            BusinessFlightsRepository bfr = new BusinessFlightsRepository();
            BusinessTicketsRepository btr = new BusinessTicketsRepository();
            BusinessTickets tic = new BusinessTickets();
            BusinessFlights fli = new BusinessFlights();
            DateTime NowDate = DateTime.Now.Date;
            int flag = 0;
            while (btr.GetAll(NowDate).Count() > 0)
            {
                tic = btr.GetAll(NowDate).First();
                btr.Delete(tic);
                flag = 1;
            }

            while (bfr.GetAll().Where(p => p.ArrivalDate < NowDate).ToList().Count > 0)
            {
                fli = bfr.GetAll().Where(p => p.DepartureDate < NowDate).First();
                bfr.Delete(fli);
                flag = 1;
            }

            if (flag == 1)
                MessageBox.Show("Old Tickets and Flights Deleted"); 
        }
    }
}
