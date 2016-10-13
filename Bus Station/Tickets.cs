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
    public partial class Tickets : Form
    {
        CitiRepository Citir = new CitiRepository();
        DiscountRepository Discountr = new DiscountRepository();
        SeatsRepository Seatsr = new SeatsRepository();
        BusinessFlights flight;

        public Tickets()
        {
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            BusinessFlightsRepository bfr = new BusinessFlightsRepository();
            var MaxDate = bfr.GetAll(DateTime.Now.Date).Max(p => p.DepartureDate);

            RefreshBindingSourse();
            cbCityStart.DataSource = Citir.GetAll().Select(p => p.CityName).ToList();
            cbCityEnd.DataSource = Citir.GetAll().Select(p => p.CityName).ToList();

            cbDiscount.DisplayMember = "DiscountName";
            cbDiscount.ValueMember = "DiscountId";
            cbDiscount.DataSource = Discountr.GetAll();
            dtpDepartureDate.MinDate = DateTime.Now;
            dtpDepartureDate.MaxDate = MaxDate;

            
        }
        private void RefreshBindingSourse()
        {
            BusinessFlightsRepository bfr = new BusinessFlightsRepository();
            binSourceBusStation.DataSource = bfr.GetAll(DateTime.Now.Date);
            dgvBusStation.DataSource = binSourceBusStation;
            dgvBusStation.Columns["FlightId"].Visible = false;
        }
        private void RefreshBindingSourse(object CityStart, object CityEnd, object dt)
        {
            BusinessFlightsRepository bfr = new BusinessFlightsRepository();
            binSourceBusStation.DataSource = bfr.GetAll(Convert.ToString(CityStart), Convert.ToString(CityEnd), Convert.ToDateTime(dt));
            dgvBusStation.DataSource = binSourceBusStation;
            dgvBusStation.Columns["FlightId"].Visible = false;
        }

        private void bShowFlights_Click(object sender, EventArgs e)
        {
            if (cbCityStart.Text != "" && cbCityEnd.Text != "")
                RefreshBindingSourse(cbCityStart.SelectedValue, cbCityEnd.SelectedValue, dtpDepartureDate.Value.Date);
            else
                MessageBox.Show("Fill in all the fields");
            if (binSourceBusStation.Count == 0)
            {
                cbSeats.DataSource = null;
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBusStation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RefreshSeats();
            bBuyTicket.Enabled = true;
        }
        public void RefreshSeats()
        {
            DateTime dt = DateTime.Now.Date;
            cbSeats.DataSource = null;
            BusStationEntities conect = new BusStationEntities();
            flight = binSourceBusStation.Current as BusinessFlights;
            string BussName = flight.Bus;
            dt = flight.DepartureDate;
            int Busid = conect.Buses.Where(p => p.BusName == BussName).Select(p => p.BusId).First();


            var notSeats = conect.Tickets.Where(p => p.Flights.DepartureDate == dt && p.Flights.BusId == Busid).Select(p => p.SeatId).ToList();
            int count = 0;

            cbSeats.ValueMember = "SeatId";
            cbSeats.DisplayMember = "NumberSeat";
            var tempSeats = Seatsr.GetAll().Where(p => p.BusId == Busid).ToList();
            while (count < notSeats.Count)
            {
                tempSeats = tempSeats.Where(p => p.SeatId != notSeats[count]).ToList();
                count++;
            }
            cbSeats.DataSource = tempSeats;
        }

        private void bShowTickets_Click(object sender, EventArgs e)
        {
            Show_Tickets st = new Show_Tickets();
            st.Show();
        }

        private void bBuyTicket_Click(object sender, EventArgs e)
        {
            BusStationEntities conect = new BusStationEntities();
            if (cbCityStart.Text != "" && cbCityEnd.Text != "" && cbSeats.Text != "")
            {
                DataBase.DataBaseBuses.Tickets ticket = new DataBase.DataBaseBuses.Tickets();
                ticket.ReleaseDate = DateTime.Now.Date;
                ticket.FlightId = flight.FlightId;
                ticket.SeatId = Convert.ToInt32(cbSeats.SelectedValue);
                ticket.DiscountId = Convert.ToInt32(cbDiscount.SelectedValue);
                ticket.Sold = true;
                conect.Tickets.Add(ticket);
                conect.SaveChanges();
                MessageBox.Show("Ticket Sold");
                RefreshSeats();
            }

            else
                MessageBox.Show("Fill in all the fields");
        }
    }
}
