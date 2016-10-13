using Bus_Station.FormBase;
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
    public partial class Schedule_Editing : Form
    {
        public MainForm MForm { get; set; }
        public Schedule_Editing()
        {
            InitializeComponent();
        }

        private void bEditingBuses_Click(object sender, EventArgs e)
        {
            FormBuses fb = new FormBuses();
            fb.Show();
            fb.SEForm = this;
            this.Visible = false;
        }

        private void bEditCities_Click(object sender, EventArgs e)
        {
            FormCities fc = new FormCities();
            fc.Show();
            fc.SEForm = this;
            this.Visible = false;
        }

        private void bEditDiscount_Click(object sender, EventArgs e)
        {
            FormDiscounts fd = new FormDiscounts();
            fd.Show();
            fd.SEForm = this;
            this.Visible = false;
        }

        private void Schedule_Editing_Load(object sender, EventArgs e)
        {
            RefreshcbBuses();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshcbBuses()
        {
            CitiRepository cityRep = new CitiRepository();
            RefreshBindingSourse();
            dtpDepartureDate.MinDate = DateTime.Now;
            dtpArrivalDate.MinDate = DateTime.Now;
            dtpFinalDateFlight.MinDate = DateTime.Now;

            cbCityStart.DisplayMember = "CityName";
            cbCityStart.ValueMember = "CityId";
            cbCityStart.DataSource = cityRep.GetAll();

            cbCityEnd.DisplayMember = "CityName";
            cbCityEnd.ValueMember = "CityId";
            cbCityEnd.DataSource = cityRep.GetAll();

            BusRepository busRep = new BusRepository();
            FlightRepository flightRep = new FlightRepository();
            var busybus = flightRep.GetAll().Select(p => p.BusId).ToList();
            int count = 0;
            var tempBuses = busRep.GetAll();
            while (count < busybus.Count)
            {
                tempBuses = tempBuses.Where(p => p.BusId != busybus[count]).ToList();
                count++;
            }
            cbBuses.DisplayMember = "BusName";
            cbBuses.ValueMember = "BusId";
            cbBuses.DataSource = tempBuses;
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

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tbFlight_Number.Text != "" && tbPrice.Text != "" && cbBuses.Text != "")
            {
                BusinessFlights bflightspep = new BusinessFlights();

                DateTime countDepartureDate = dtpDepartureDate.Value.Date;
                DateTime countArrivalDate = dtpArrivalDate.Value.Date;

                bflightspep.FlightNumber = tbFlight_Number.Text;
                bflightspep.CityIdStart = Convert.ToInt32(cbCityStart.SelectedValue);
                bflightspep.CityIdEnd = Convert.ToInt32(cbCityEnd.SelectedValue);

                string[] time = tbDepartureTime.Text.Split(':');
                TimeSpan Ttime = new TimeSpan(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), Convert.ToInt32(time[2]));
                bflightspep.DepartureTime = Ttime;

                time = tbArrivalTime.Text.Split(':');
                Ttime = new TimeSpan(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), Convert.ToInt32(time[2]));
                bflightspep.ArrivaTime = Ttime;

                bflightspep.BusId = Convert.ToUInt16(cbBuses.SelectedValue);
                bflightspep.Price = Convert.ToDecimal(tbPrice.Text);

                while (countDepartureDate <= dtpFinalDateFlight.Value.Date)
                {
                    bflightspep.DepartureDate = countDepartureDate;
                    bflightspep.ArrivalDate = countArrivalDate;

                    BusinessFlightsRepository bfr = new BusinessFlightsRepository();
                    bfr.Create(bflightspep);
                    
                    countDepartureDate = countDepartureDate.AddDays(1);
                    countArrivalDate = countArrivalDate.AddDays(1);
                }
                MessageBox.Show("Flights Add");
                RefreshBindingSourse();
            }
            else
                MessageBox.Show("Fill in all the fields");
            RefreshcbBuses();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить   запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result.ToString() == "Yes")
            {
                BusinessFlights bflights = binSourceBusStation.Current as BusinessFlights;

                BusinessTicketsRepository btr = new BusinessTicketsRepository();
                BusinessTickets tic = new BusinessTickets();
                if (btr.GetAll(bflights).Count() > 0)
                {
                    result = MessageBox.Show("На этот рейс проданы билеты, билеты будут удалены, УДАЛИТЬ ЗАПИСЬ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result.ToString() == "Yes")
                    {
                        while (btr.GetAll(bflights).Count() > 0)
                        {
                            tic = btr.GetAll(bflights).First();
                            btr.Delete(tic);
                        }
                        BusinessFlightsRepository bfr = new BusinessFlightsRepository();
                        bfr.Delete(bflights);
                        MessageBox.Show("Flight Delete");
                        RefreshBindingSourse();
                        RefreshcbBuses();
                    }
                }

                else
                {
                    BusinessFlightsRepository bfr = new BusinessFlightsRepository();
                    bfr.Delete(bflights);
                    MessageBox.Show("Flight Delete");
                    RefreshBindingSourse();
                    RefreshcbBuses();
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            dgvBusStation.EndEdit();
            BusinessFlights bfl = binSourceBusStation.Current as BusinessFlights;
            List<BusinessTickets> busTickets = DeleteTickets(bfl);
            BusinessFlightsRepository bfr = new BusinessFlightsRepository();
            bfr.Save(bfl);
            if (busTickets.Count > 0)
            {
                BusinessTickets bustick = new BusinessTickets();
                BusinessTicketsRepository bustickrep = new BusinessTicketsRepository();
                FlightRepository newflight = new FlightRepository();
                for (int i = 0; i < busTickets.Count; i++)
                {
                    bustick.ReleaseDate = busTickets[i].ReleaseDate;
                    bustick.FlightId = bfl.FlightId/*newflight.GetAll().Select(p => p.FlightId).Last()*/;
                    bustick.SeatId = busTickets[i].SeatId;
                    bustick.DiscountId = busTickets[i].DiscountId;
                    bustick.Sold = busTickets[i].Sold;
                    bustick.Reserve = busTickets[i].Reserve;
                    bustick.Canceled = busTickets[i].Canceled;

                    bustickrep.Create(bustick);
                }
            }


            //   Если надо будет изменять все записи этого рейса
            //BusinessFlights bfl2 = bfr.GetAll();
            //int countFlights = bfr.GetAll(bfl1.FlightNumber).ToList().Count();
            //while (countFlights-- > 0)
            //{
            //    bfl2 = bfr.GetAll(bfl1.FlightNumber).First();
            //    listFlights.Add(bfl2);
            //    bfr.Delete(bfl2);
            //}

            //for (int i = 0; i < listFlights.Count; i++)
            //{
            //    bfl2 = listFlights[i];
            //    bfr.Save(GetBusinessFlights(bfl1, bfl2));
            //}

            RefreshBindingSourse();
            MessageBox.Show("Flights Edit");

        }

        private BusinessFlights GetBusinessFlights (BusinessFlights bfl1, BusinessFlights bfl2)
        {
            return

                    new BusinessFlights
                    {
                        FlightId = bfl2.FlightId,
                        FlightNumber = bfl1.FlightNumber,
                        CityIdStart = bfl1.CityIdStart,
                        CityIdEnd = bfl1.CityIdEnd,
                        DepartureDate = bfl1.DepartureDate,
                        DepartureTime = bfl1.DepartureTime,
                        ArrivalDate = bfl1.ArrivalDate,
                        ArrivaTime = bfl1.ArrivaTime,
                        BusId = bfl1.BusId,
                        Price = bfl1.Price
                    };
        }

        private void Schedule_Editing_Activated(object sender, EventArgs e)
        {
            RefreshBindingSourse();
            RefreshcbBuses();
        }

        private void Schedule_Editing_FormClosing(object sender, FormClosingEventArgs e)
        {
            MForm.Visible = true;
        }

        private List<BusinessTickets> DeleteTickets(BusinessFlights BFlights)
        {
            List<BusinessTickets> listbusTickets = new List<BusinessTickets>();
            BusinessTickets obj = new BusinessTickets();
            BusinessTicketsRepository busTickRep = new BusinessTicketsRepository();

            int countTick = busTickRep.GetAll(BFlights, 1).ToList().Count;
            while (countTick-- > 0)
            {
                obj = busTickRep.GetAll(BFlights, 1).First();
                listbusTickets.Add(obj);
                busTickRep.Delete(obj);
            }

            return listbusTickets;
        }
    }
}