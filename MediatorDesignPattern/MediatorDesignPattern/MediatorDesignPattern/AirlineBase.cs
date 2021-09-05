using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
   public abstract class AirlineBase
    {
        public string FlightCode { get; set; }

        public IAirport Airport { get; set; }

        public virtual void GetLandingPermission()
        {
            if (Airport !=null)
            {
                bool hasPermissionForLanding = Airport.GiveLandingPermission(FlightCode);
                if (hasPermissionForLanding)
                    Console.WriteLine("İniş İzni Verildi");
                else
                {
                    Console.WriteLine("İniş İzni Verilmedi");
                }
            }
            else
            {
                Console.WriteLine("Uçak kaydı yok,İniş İzni Verilmedi");
            }

        }

    }
}
