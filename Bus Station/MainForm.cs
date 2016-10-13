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
    public partial class MainForm : Form
    {
        public Authorization_Form AForm { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bScheduleEditing_Click(object sender, EventArgs e)
        {
            Schedule_Editing se = new Schedule_Editing();
            se.Show();
            se.MForm = this;
            this.Visible = false;
        }

        private void bTicket_Click(object sender, EventArgs e)
        {
            Tickets ti = new Tickets();
            ti.Show();
            ti.MForm = this;
            this.Visible = false;
        }

        private void bUsersEditing_Click(object sender, EventArgs e)
        {
            UsersEditing ue = new UsersEditing();
            ue.Show();
            ue.MForm = this;
            this.Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AForm.Close();
        }
    }
}
