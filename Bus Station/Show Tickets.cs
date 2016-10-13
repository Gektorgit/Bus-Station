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
    public partial class Show_Tickets : Form
    {
        public Show_Tickets()
        {
            InitializeComponent();
        }

        private void Show_Tickets_Load(object sender, EventArgs e)
        {
            BusinessTicketsRepository btr = new BusinessTicketsRepository();
            binSourceBusStation.DataSource = btr.GetAll();

            dgvBusStation.DataSource = binSourceBusStation;
            dgvBusStation.Columns["TicketId"].Visible = false;
        }
    }
}
