using DataBase.BusinessLayer;
using DataBase.DataBaseBuses;
using DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Station.FormBase
{
    public class TempFlightId
    {
        public int oldId { get; set; }
        public int newId { get ; set; }
    }

    public class TempSeatId
    {
        public int oldId { get; set; }
        public int newId { get; set; }
    } 

    public abstract class FormTemplate<T> : Form_Display where T : class, new()
    {
        public Schedule_Editing SEForm { get; set; }
        int flagdelete = 0;
        List <BusinessFlights> listbusFlights = new List<BusinessFlights>();
        List <Seats> listSeats = new List<Seats>();
        protected abstract SimpleRepository<T> repository { get; }
        protected string flag { get; set; }
        public FormTemplate()
            : base()
        {
            this.Load += FormTemplate_Load;
            this.FormClosing += FormTemplate_FormClosing;
            bAdd.Click += addNewItem_Click;
            bDelete.Click += deleteItem_Click;
            bSave.Click += saveItem_Click;
            bExit.Click += ExitItem_Click;
            binSourceBusStation.BindingComplete += bindingSource_BindingComplete;
        }

        void FormTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            SEForm.Visible = true;
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }

        void bindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            this.binSourceBusStation.EndEdit();
            T t = (T)binSourceBusStation.Current;
            repository.Save(t);
        }

        void FormTemplate_Load(object sender, EventArgs e)
        {
            DBRefresh();           
        }

        public void DBRefresh()
        {
            binSourceBusStation.DataSource = repository.GetAll();
            dgvBusStation.DataSource = binSourceBusStation;
            switch (flag)
            {
                case "Discounts":
                    dgvBusStation.Columns["Tickets"].Visible = false;
                    break;
                case "Cities":
                    dgvBusStation.Columns["Flights"].Visible = false;
                    dgvBusStation.Columns["Flights1"].Visible = false;
                    break;
                case "Buses":
                    dgvBusStation.Columns["Flights"].Visible = false;
                    dgvBusStation.Columns["Seats"].Visible = false;
                    break;
                default:
                    break;
            }
        }

        void saveItem_Click(object sender, EventArgs e)
        {
            dgvBusStation.EndEdit();
            DialogResult result;
            BusinessTicketsRepository busTickRep = new BusinessTicketsRepository();
            switch (flag)
            {
                case "Discounts":
                    Discounts disc = (Discounts)binSourceBusStation.Current;
                    if (busTickRep.GetAll(disc.DiscountId).ToList().Count > 0)
                    {
                        result = MessageBox.Show("С этим дисконтом уже проданы билеты, возможна потеря данных, все таки ИЗМЕНИТЬ ЗАПИСЬ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (result.ToString() == "Yes")
                            EditDiscount();
                    }
                    else
                        EditDiscount();
                    break;
                case "Cities":
                    Cities city = binSourceBusStation.Current as Cities;
                    if (busTickRep.GetAll(city).ToList().Count > 0)
                    {
                        result = MessageBox.Show("С этим городом уже проданы билеты, возможна потеря данных, все таки ИЗМЕНИТЬ ЗАПИСЬ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (result.ToString() == "Yes")
                            EditCity();
                    }
                    else
                        EditCity();
                    break;

                case "Buses":
                    Buses bus = binSourceBusStation.Current as Buses;
                    if (busTickRep.GetAll(bus).ToList().Count > 0)
                    {
                        result = MessageBox.Show("С этим автобусом уже проданы билеты, возможна потеря данных, все таки ИЗМЕНИТЬ ЗАПИСЬ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (result.ToString() == "Yes")
                            EditBus();
                    }
                    else
                        EditBus();
                    
                    break;

                default:
                    break;
            }
            DBRefresh();
        }

        void deleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить   запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result.ToString() == "Yes")
            {
                flagdelete = 0;
                BusinessTicketsRepository busTickRep = new BusinessTicketsRepository();
                switch (flag)
                {
                    case "Discounts":
                        Discounts disc = (Discounts)binSourceBusStation.Current;
                        if (busTickRep.GetAll(disc.DiscountId).ToList().Count > 0)
                        {
                            result = MessageBox.Show("С этим дисконтом уже проданы билеты все таки УДАЛИТЬ ЗАПИСЬ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (result.ToString() == "Yes")
                            {
                                DeleteTicketsANDFlights(disc);
                                flagdelete = 1;
                                MessageBox.Show("Discount Delete");
                            }
                        }
                        else
                        {
                            DeleteTicketsANDFlights(disc);
                            flagdelete = 1;
                        }
                        break;
                    case "Cities":
                        Cities city = binSourceBusStation.Current as Cities;
                        int countC = busTickRep.GetAll(city).ToList().Count;
                        if (countC > 0)
                        {
                            result = MessageBox.Show("Билеты с такими городами уже проданы все  таки УДАЛИТЬ ЗАПИСЬ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (result.ToString() == "Yes")
                            {
                                DeleteTicketsANDFlights(city, ref listbusFlights);
                                MessageBox.Show("Citi Delete");
                            }
                        }
                        else
                        {
                            DeleteTicketsANDFlights(city, ref listbusFlights);
                            MessageBox.Show("Citi Delete");
                        }
                        
                        
                        break;
                    case "Buses":
                        Buses bus = binSourceBusStation.Current as Buses;
                        int countB = busTickRep.GetAll(bus).ToList().Count;
                        if (countB > 0)
                        {
                            result = MessageBox.Show("Билеты с такими городами уже проданы все  таки УДАЛИТЬ ЗАПИСЬ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (result.ToString() == "Yes")
                            {
                                DeleteTicketsFlightsSeats(bus, ref listbusFlights, ref listSeats);
                                MessageBox.Show("Bus Delete");
                            }
                        }
                        else
                        {
                            DeleteTicketsFlightsSeats(bus, ref listbusFlights, ref listSeats);
                            MessageBox.Show("Bus Delete");
                        }
                        
                        break;
                    default:
                        break;
                }

                if (flagdelete == 1)
                {
                    T t = (T)binSourceBusStation.Current;
                    repository.Delete(t);
                    binSourceBusStation.RemoveCurrent();
                    DBRefresh();
                }
            }
        }

        void addNewItem_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case "Buses":
                    dgvBusStation.EndEdit();
                    Buses bus = (Buses)binSourceBusStation.Current;
                    BusRepository rep = new BusRepository();
                    rep.Create(bus);

                    Seats seat;
                    SeatsRepository seatrep = new SeatsRepository();
                    for (int i = 0; i < bus.CountSeats; i++)
                    {
                        seat = new Seats();
                        seat.BusId = bus.BusId;
                        seat.NumberSeat = i + 1;
                        seatrep.Create(seat);
                    }

                    break;
                default:
                    dgvBusStation.EndEdit();
                    T t = (T)binSourceBusStation.Current;
                    repository.Create(t);
                    break;
            }
                
        }

        private List<BusinessTickets> DeleteTicketsANDFlights(Discounts discounts)
        {
            List<BusinessTickets> busTickets = new List<BusinessTickets>();
            int DiscountId = discounts.DiscountId;
            BusinessTickets obj = new BusinessTickets();
            BusinessTicketsRepository busTickRep = new BusinessTicketsRepository();
            int countTick = busTickRep.GetAll(DiscountId).ToList().Count;
            while (countTick-- > 0)
            {
                obj = busTickRep.GetAll(DiscountId).First();
                busTickets.Add(obj);
                busTickRep.Delete(obj);
            }

            return busTickets;
        }

        private List<BusinessTickets> DeleteTicketsANDFlights(Cities city, ref List<BusinessFlights> busFlights)
        {
            List<BusinessTickets> busTickets = new List<BusinessTickets>();
            BusinessTickets obj = new BusinessTickets();
            BusinessTicketsRepository busTickRep = new BusinessTicketsRepository();
            BusinessFlights objFlights = new BusinessFlights();
            BusinessFlightsRepository busFlightsRep = new BusinessFlightsRepository();
            int countTick = busTickRep.GetAll(city).ToList().Count;
            int countFlight = busFlightsRep.GetAll(city).ToList().Count;
            if (countTick > 0)
            {
                while (countTick-- > 0)
                {
                    obj = busTickRep.GetAll(city).First();
                    busTickets.Add(obj);
                    busTickRep.Delete(obj);
                }
                    
                while (countFlight-- > 0)
                {
                    objFlights = busFlightsRep.GetAll(city).First();
                    busFlights.Add(objFlights);
                    busFlightsRep.Delete(objFlights);
                }
                flagdelete = 1;
            }
            else
            {
                while (countFlight-- > 0)
                {
                    objFlights = busFlightsRep.GetAll(city).First();
                    busFlights.Add(objFlights);
                    busFlightsRep.Delete(objFlights);
                }
                flagdelete = 1;
            }
            return busTickets;
        }

        private List<BusinessTickets> DeleteTicketsFlightsSeats(Buses bus, ref List<BusinessFlights> busFlights, ref List<Seats> listseats)
        {
            List<BusinessTickets> busTickets = new List<BusinessTickets>();
            BusinessTickets obj = new BusinessTickets();
            BusinessTicketsRepository busTickRep = new BusinessTicketsRepository();
            BusinessFlights objFlights = new BusinessFlights();
            BusinessFlightsRepository busFlightsRep = new BusinessFlightsRepository();
            Seats seats = new Seats();
            SeatsRepository seatsrep = new SeatsRepository();

            int countTick = busTickRep.GetAll(bus).ToList().Count;
            int countFlight = busFlightsRep.GetAll(bus).ToList().Count;
            int countSeat = seatsrep.GetAll().Where(p => p.BusId == bus.BusId).Count();

            if (countTick > 0)
            {
                while (countTick-- > 0)
                {
                    obj = busTickRep.GetAll(bus).First();
                    busTickets.Add(obj);
                    busTickRep.Delete(obj);
                }

                while (countFlight-- > 0)
                {
                    objFlights = busFlightsRep.GetAll(bus).First();
                    busFlights.Add(objFlights);
                    busFlightsRep.Delete(objFlights);
                }
                flagdelete = 1;
            }

            else
            {
                while (countFlight-- > 0)
                {
                    objFlights = busFlightsRep.GetAll(bus).First();
                    busFlights.Add(objFlights);
                    busFlightsRep.Delete(objFlights);
                }
                flagdelete = 1;
            }

            while (countSeat-- > 0)
            {
                seats = seatsrep.GetAll().Where(p => p.BusId == bus.BusId).First();
                listseats.Add(seats);
                seatsrep.Delete(seats);
            }
            return busTickets;
        }

        private void EditDiscount()
        {
            DiscountRepository discrep = new DiscountRepository();
            Discounts disc = (Discounts)binSourceBusStation.Current;
            List<BusinessTickets> busTicketsD = DeleteTicketsANDFlights(disc);
            discrep.Delete(disc);
            Discounts newdisc = new Discounts();
            newdisc.DiscountName = disc.DiscountName;
            newdisc.Size = disc.Size;
            newdisc.Information = disc.Information;
            discrep.Create(newdisc);
            if (busTicketsD.Count > 0)
            {
                BusinessTickets bustick = new BusinessTickets();
                BusinessTicketsRepository bustickrep = new BusinessTicketsRepository();
                for (int i = 0; i < busTicketsD.Count; i++)
                {
                    bustick.ReleaseDate = busTicketsD[i].ReleaseDate;
                    bustick.FlightId = busTicketsD[i].FlightId;
                    bustick.SeatId = busTicketsD[i].SeatId;
                    bustick.DiscountId = newdisc.DiscountId;
                    bustick.Sold = busTicketsD[i].Sold;
                    bustick.Reserve = busTicketsD[i].Reserve;
                    bustick.Canceled = busTicketsD[i].Canceled;

                    bustickrep.Create(bustick);
                }
            }
            MessageBox.Show("Discount Edit");
        }

        private void EditCity()
        {
            listbusFlights.Clear();
            Cities city = binSourceBusStation.Current as Cities;
            CitiRepository cityrep = new CitiRepository();
            List<TempFlightId> listFlightId = new List<TempFlightId>();
            List<BusinessTickets> busTicketsC = DeleteTicketsANDFlights(city, ref listbusFlights);
            cityrep.Delete(city);

            Cities newcity = new Cities();
            newcity.CityName = city.CityName;
            newcity.Information = city.Information;
            cityrep.Create(newcity);

            if (listbusFlights.Count > 0)
            {
                BusinessFlights busFlight;
                BusinessFlightsRepository busFlightrep = new BusinessFlightsRepository();
                TempFlightId ekz;
                for (int i = 0; i < listbusFlights.Count; i++)
                {
                    busFlight = new BusinessFlights();
                    ekz = new TempFlightId();
                    busFlight.FlightNumber = listbusFlights[i].FlightNumber;
                    busFlight.CityIdStart = listbusFlights[i].CityIdStart == city.CityId ? newcity.CityId : listbusFlights[i].CityIdStart;
                    busFlight.CityIdEnd = listbusFlights[i].CityIdEnd == city.CityId ? newcity.CityId : listbusFlights[i].CityIdEnd;
                    busFlight.DepartureDate = listbusFlights[i].DepartureDate;
                    busFlight.DepartureTime = listbusFlights[i].DepartureTime;
                    busFlight.ArrivalDate = listbusFlights[i].ArrivalDate;
                    busFlight.ArrivaTime = listbusFlights[i].ArrivaTime;
                    busFlight.BusId = listbusFlights[i].BusId;
                    busFlight.Price = listbusFlights[i].Price;
                    busFlightrep.Create(busFlight);

                    FlightRepository newflight = new FlightRepository();
                    ekz.oldId = listbusFlights[i].FlightId;
                    ekz.newId = newflight.GetAll().Select(p => p.FlightId).Last();
                    listFlightId.Add(ekz);
                }
            }
            if (busTicketsC.Count > 0)
            {
                BusinessTickets bustick;
                BusinessTicketsRepository bustickrep = new BusinessTicketsRepository();
                for (int i = 0; i < busTicketsC.Count; i++)
                {
                    bustick = new BusinessTickets();
                    for (int j = 0; j < listFlightId.Count; j++)
                    {
                        if (busTicketsC[i].FlightId == listFlightId[j].oldId)
                        {
                            bustick.FlightId = listFlightId[j].newId;
                            break;
                        }
                    }
                    bustick.ReleaseDate = busTicketsC[i].ReleaseDate;
                    bustick.SeatId = busTicketsC[i].SeatId;
                    bustick.DiscountId = busTicketsC[i].DiscountId;
                    bustick.Sold = busTicketsC[i].Sold;
                    bustick.Reserve = busTicketsC[i].Reserve;
                    bustick.Canceled = busTicketsC[i].Canceled;

                    bustickrep.Create(bustick);
                }
            }

            MessageBox.Show("City Edit");
        }

        private void EditBus()
        {
            listSeats.Clear();
            Buses bus = binSourceBusStation.Current as Buses;
            BusRepository busrep = new BusRepository();
            List<TempFlightId> listFlightId2 = new List<TempFlightId>();
            List<TempSeatId> listSeatId = new List<TempSeatId>();
            List<BusinessTickets> busTicketsB = DeleteTicketsFlightsSeats(bus, ref listbusFlights, ref listSeats);
            busrep.Delete(bus);

            Buses newbus = new Buses();
            newbus.BusName = bus.BusName;
            newbus.CountSeats = bus.CountSeats;
            newbus.Information = bus.Information;
            busrep.Create(newbus);

            if (listbusFlights.Count > 0)
            {
                BusinessFlights busFlight;
                BusinessFlightsRepository busFlightrep = new BusinessFlightsRepository();
                TempFlightId ekz;
                for (int i = 0; i < listbusFlights.Count; i++)
                {
                    busFlight = new BusinessFlights();
                    ekz = new TempFlightId();
                    busFlight.FlightNumber = listbusFlights[i].FlightNumber;
                    busFlight.CityIdStart = listbusFlights[i].CityIdStart;
                    busFlight.CityIdEnd = listbusFlights[i].CityIdEnd;
                    busFlight.DepartureDate = listbusFlights[i].DepartureDate;
                    busFlight.DepartureTime = listbusFlights[i].DepartureTime;
                    busFlight.ArrivalDate = listbusFlights[i].ArrivalDate;
                    busFlight.ArrivaTime = listbusFlights[i].ArrivaTime;
                    busFlight.BusId = listbusFlights[i].BusId == bus.BusId ? newbus.BusId : listbusFlights[i].BusId;
                    busFlight.Price = listbusFlights[i].Price;
                    busFlightrep.Create(busFlight);

                    FlightRepository newflight = new FlightRepository();
                    ekz.oldId = listbusFlights[i].FlightId;
                    ekz.newId = newflight.GetAll().Select(p => p.FlightId).Last();
                    listFlightId2.Add(ekz);
                }
            }


            SeatsRepository seatrep = new SeatsRepository();
            TempSeatId ekzseat;
            for (int i = 0; i < newbus.CountSeats; i++)
            {
                Seats seat = new Seats();
                ekzseat = new TempSeatId();
                seat.BusId = newbus.BusId;
                seat.NumberSeat = i + 1;
                seatrep.Create(seat);

                SeatsRepository newSeat = new SeatsRepository();
                ekzseat.oldId = i < listSeats.Count ? listSeats[i].SeatId : 0;
                ekzseat.newId = newSeat.GetAll().Select(p => p.SeatId).Last();
                listSeatId.Add(ekzseat);
            }

            if (busTicketsB.Count > 0)
            {
                BusinessTickets bustick;
                BusinessTicketsRepository bustickrep = new BusinessTicketsRepository();
                for (int i = 0; i < busTicketsB.Count; i++)
                {
                    bustick = new BusinessTickets();
                    for (int j = 0; j < listFlightId2.Count; j++)
                    {
                        if (busTicketsB[i].FlightId == listFlightId2[j].oldId)
                        {
                            bustick.FlightId = listFlightId2[j].newId;
                            break;
                        }
                    }
                    for (int k = 0; k < listSeatId.Count; k++)
                    {
                        if (busTicketsB[i].SeatId == listSeatId[k].oldId)
                        {
                            bustick.SeatId = listSeatId[k].newId;
                            break;
                        }
                    }
                    bustick.ReleaseDate = busTicketsB[i].ReleaseDate;
                    bustick.DiscountId = busTicketsB[i].DiscountId;
                    bustick.Sold = busTicketsB[i].Sold;
                    bustick.Reserve = busTicketsB[i].Reserve;
                    bustick.Canceled = busTicketsB[i].Canceled;

                    bustickrep.Create(bustick);
                }
            }

            MessageBox.Show("Bus Edit");
        }
    }
}
