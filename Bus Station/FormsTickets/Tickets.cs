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
        public MainForm MForm { get; set; }
        public Tickets()
        {
            BusinessFlightsRepository bfr = new BusinessFlightsRepository();
            InitializeComponent();
            
            cbCityStart.DataSource = bfr.GetAll().Select(p => p.CityStart).Distinct().ToList();
            cbCityEnd.DataSource = bfr.GetAll().Select(p => p.CityEnd).Distinct().ToList();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            BusinessFlightsRepository bfr = new BusinessFlightsRepository();
            var MaxDate = bfr.GetAll(DateTime.Now.Date).Max(p => p.DepartureDate);
            
            cbDiscount.DisplayMember = "DiscountName";
            cbDiscount.ValueMember = "DiscountId";
            cbDiscount.DataSource = Discountr.GetAll();
            dtpDepartureDate.MaxDate = MaxDate;
            dtpDepartureDate.MinDate = DateTime.Now.Date;
            

            
        }
        private void RefreshBindingSourse()
        {
            BusinessFlightsRepository bfr = new BusinessFlightsRepository();
            binSourceBusStation.DataSource = bfr.GetAll(DateTime.Now.Date);
            dgvBusStation.DataSource = binSourceBusStation;
            dgvBusStation.Columns["FlightId"].Visible = false;
            dgvBusStation.Columns["CityIdStart"].Visible = false;
            dgvBusStation.Columns["CityIdEnd"].Visible = false;
            dgvBusStation.Columns["BusId"].Visible = false;
        }
        private void RefreshBindingSourse(object CityStart, object CityEnd, object dt)
        {
            BusinessFlightsRepository bfr = new BusinessFlightsRepository();
            binSourceBusStation.DataSource = bfr.GetAll(Convert.ToString(CityStart), Convert.ToString(CityEnd), Convert.ToDateTime(dt));
            dgvBusStation.DataSource = binSourceBusStation;
            dgvBusStation.Columns["FlightId"].Visible = false;
            dgvBusStation.Columns["CityIdStart"].Visible = false;
            dgvBusStation.Columns["CityIdEnd"].Visible = false;
            dgvBusStation.Columns["BusId"].Visible = false;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBusStation_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshSeats();
            bBuyTicket.Enabled = true;
            bReserveTicket.Enabled = true;
        }
        public void RefreshSeats()
        {
            if (binSourceBusStation.Count != 0)
            {
                flight = binSourceBusStation.Current as BusinessFlights;
                if (flight.CityStart != null)
                {
                    DateTime dt = DateTime.Now.Date;
                    cbSeats.DataSource = null;
                    BusStationEntities conect = new BusStationEntities();
                    BusRepository busrep = new BusRepository();
                    BusinessTicketsRepository btr = new BusinessTicketsRepository();
                    string BussName = flight.Bus;
                    dt = flight.DepartureDate;
                    int Busid = busrep.GetAll().Where(p => p.BusName == BussName).Select(p => p.BusId).First();
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
                else
                    MessageBox.Show("Выберите рейс");
            }
            
            
        }

        private void bShowTickets_Click(object sender, EventArgs e)
        {
            Show_Tickets st = new Show_Tickets();
            st.Show();
            st.TForm = this;
            this.Visible = false;
        }

        private void bBuyTicket_Click(object sender, EventArgs e)
        {
            if (cbCityStart.Text != "" && cbCityEnd.Text != "" && cbSeats.Text != "")
            {
                BusinessTickets bustick = new BusinessTickets();
                bustick.ReleaseDate = DateTime.Now.Date;
                bustick.FlightId = flight.FlightId;
                bustick.SeatId = Convert.ToInt32(cbSeats.SelectedValue);
                bustick.DiscountId = Convert.ToInt32(cbDiscount.SelectedValue);
                bustick.Sold = true;

                BusinessTicketsRepository bustickrep = new BusinessTicketsRepository();
                bustickrep.Create(bustick);

                MessageBox.Show("Ticket Sold");
                RefreshSeats();
            }

            else
                MessageBox.Show("Fill in all the fields");
        }

        private void bReserveTicket_Click(object sender, EventArgs e)
        {
            if (cbCityStart.Text != "" && cbCityEnd.Text != "" && cbSeats.Text != "")
            {
                BusinessTickets bustick = new BusinessTickets();
                bustick.ReleaseDate = DateTime.Now.Date;
                bustick.FlightId = flight.FlightId;
                bustick.SeatId = Convert.ToInt32(cbSeats.SelectedValue);
                bustick.DiscountId = Convert.ToInt32(cbDiscount.SelectedValue);
                bustick.Reserve = true;

                BusinessTicketsRepository bustickrep = new BusinessTicketsRepository();
                bustickrep.Create(bustick);

                MessageBox.Show("Ticket Reserve");
                RefreshSeats();
            }

            else
                MessageBox.Show("Fill in all the fields");
        }

        private void cbCityStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            bBuyTicket.Enabled = false;
            bReserveTicket.Enabled = false;
            cbSeats.DataSource = null;

            BusinessFlightsRepository bfr = new BusinessFlightsRepository();
            var MaxDate = bfr.GetAll(DateTime.Now.Date).Where(p => p.CityStart == Convert.ToString(cbCityStart.SelectedValue)).Max(p => p.DepartureDate);
            var MinDate = bfr.GetAll(DateTime.Now.Date).Where(p => p.CityStart == Convert.ToString(cbCityStart.SelectedValue)).Min(p => p.DepartureDate);
            dtpDepartureDate.MinDate = MinDate;
            dtpDepartureDate.MaxDate = MaxDate;
            dtpDepartureDate.Value = dtpDepartureDate.MinDate;

            cbCityEnd.DataSource = bfr.GetAll().Where(p => p.CityStart == Convert.ToString(cbCityStart.SelectedValue)).Select(p => p.CityEnd).Distinct().ToList();
            if (Convert.ToString(cbCityStart.SelectedValue) == "")
                cbCityEnd.DataSource = bfr.GetAll().Select(p => p.CityEnd).Distinct().ToList();

            RefreshBindingSourse(cbCityStart.SelectedValue, cbCityEnd.SelectedValue, dtpDepartureDate.Value.Date);
            if (binSourceBusStation.Count == 0)
                cbSeats.DataSource = null;
        }

        private void dtpDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            if (binSourceBusStation.Count == 0)
                cbSeats.DataSource = null;
            RefreshBindingSourse(cbCityStart.SelectedValue, cbCityEnd.SelectedValue, dtpDepartureDate.Value.Date);
        }

        private void cbCityEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            bBuyTicket.Enabled = false;
            bReserveTicket.Enabled = false;
            cbSeats.DataSource = null;

            RefreshBindingSourse(cbCityStart.SelectedValue, cbCityEnd.SelectedValue, dtpDepartureDate.Value.Date);
            if (binSourceBusStation.Count == 0)
                cbSeats.DataSource = null;
        }

        private void Tickets_FormClosing(object sender, FormClosingEventArgs e)
        {
            MForm.Visible = true;
        }
    }
}
