using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
   public class PegasusAirline :AirlineBase
    {
        public override void GetLandingPermission()
        {
            Console.WriteLine(FlightCode + " nolu Pegaus Uçağına İniş İzni Gönderildi. ");
            base.GetLandingPermission();
        }
    }
}
