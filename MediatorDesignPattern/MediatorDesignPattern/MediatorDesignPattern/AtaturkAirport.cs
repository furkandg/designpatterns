using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class AtaturkAirport : IAirport
    {
        private Dictionary<string, AirlineBase> _planes;

        public AtaturkAirport()
        {
            _planes = new Dictionary<string, AirlineBase>();
        }

      
        public bool GiveLandingPermission(string flightCode)
        {
            if (!_planes.ContainsKey(flightCode))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Register(AirlineBase airline)
        {
            if (!_planes.ContainsValue(airline))
            {
                _planes.Add(airline.FlightCode, airline);
            }

            airline.Airport = this;
        }
    }
}
