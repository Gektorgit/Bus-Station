using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Station
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Для доступа к БД на домашнем компьютере
            //<add name="BusStationEntities" connectionString="metadata=res://*/DataBaseBuses.ModelBusStation.csdl|res://*/DataBaseBuses.ModelBusStation.ssdl|res://*/DataBaseBuses.ModelBusStation.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=ADMINWORKGROUP;initial catalog=BusStation;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />

            // Для доступа к БД в академии
            //<add name="BusStationEntities" connectionString="metadata=res://*/DataBaseBuses.ModelBusStation.csdl|res://*/DataBaseBuses.ModelBusStation.ssdl|res://*/DataBaseBuses.ModelBusStation.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=localhost;initial catalog=BusStation;user id=sa;password=student;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />

            // Для доступа к БД в Богодухове
            //<add name="BusStationEntities" connectionString="metadata=res://*/DataBaseBuses.ModelBusStation.csdl|res://*/DataBaseBuses.ModelBusStation.ssdl|res://*/DataBaseBuses.ModelBusStation.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=localhost;initial catalog=BusStation;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization_Form());
        }
    }
}
