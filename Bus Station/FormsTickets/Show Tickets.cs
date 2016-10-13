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
    public partial class Show_Tickets : Form
    {
        public Tickets TForm { get; set; }
        public Show_Tickets()
        {
            InitializeComponent();
        }

        private void Show_Tickets_Load(object sender, EventArgs e)
        {
            GetTickets();
        }

        private void bBuyTicket_Click(object sender, EventArgs e)
        {
            BusinessTickets bt = binSourceBusStation.Current as BusinessTickets;
            if (bt.Reserve == true)
            {
                BusinessTicketsRepository btr = new BusinessTicketsRepository();
                bt.Sold = true;
                bt.Reserve = false;
                btr.Save(bt);

                MessageBox.Show("Ticket sold");
            }
        }

        void GetTickets()
        {
            BusinessTicketsRepository btr = new BusinessTicketsRepository();
            binSourceBusStation.DataSource = btr.GetAll();

            dgvBusStation.DataSource = binSourceBusStation;
            dgvBusStation.Columns["TicketId"].Visible = false;
            dgvBusStation.Columns["FlightId"].Visible = false;
            dgvBusStation.Columns["SeatId"].Visible = false;
            dgvBusStation.Columns["DiscountId"].Visible = false;
        }

        private void bDeleteTicket_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить   запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result.ToString() == "Yes")
            {
                BusinessTickets tic = binSourceBusStation.Current as BusinessTickets;
                BusinessTicketsRepository obj = new BusinessTicketsRepository();

                obj.Delete(tic);
                GetTickets();
                MessageBox.Show("Ticket Delete");
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Show_Tickets_FormClosing(object sender, FormClosingEventArgs e)
        {
            TForm.Visible = true;
        }
    }
}
