using DataBase.DataBaseBuses;
using DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Station.FormBase
{
    public class FormBuses : FormTemplate<Buses>
    {
        public FormBuses()
        {
            Load += EventLoaded;
            flag = "Buses";
        }

        private void EventLoaded(object sender, EventArgs e)
        {
            dgvBusStation.Columns["BusId"].Visible = false;
            dgvBusStation.Columns["Flights"].Visible = false;
            dgvBusStation.Columns["Seats"].Visible = false;
        }

        protected override SimpleRepository<Buses> repository
        {
            get { return new BusRepository(); }
        }
    }

    public class FormCities : FormTemplate<Cities>
    {

        public FormCities()
        {
            Load += EventLoaded;
            flag = "Cities";
        }

        private void EventLoaded(object sender, EventArgs e)
        {
            dgvBusStation.Columns["CityId"].Visible = false;
        }

        protected override SimpleRepository<Cities> repository
        {
            get { return new CitiRepository(); }
        }
    }

    public class FormDiscounts : FormTemplate<Discounts>
    {
        public FormDiscounts()
        {
            Load += EventLoaded;
            flag = "Discounts";
        }

        private void EventLoaded(object sender, EventArgs e)
        {
            dgvBusStation.Columns["DiscountId"].Visible = false;
        }
        protected override SimpleRepository<Discounts> repository
        {
            get { return new DiscountRepository(); }
        }
    }
}
