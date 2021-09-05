using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class THYAirline:AirlineBase
    {
        public override void GetLandingPermission()
        {
            Console.WriteLine(FlightCode + "Nolu Thy uçağına iniş izni gönderildi");
            base.GetLandingPermission();
        }
    }
}
