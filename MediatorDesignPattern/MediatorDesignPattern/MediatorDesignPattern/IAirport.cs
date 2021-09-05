using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public interface IAirport
    {
        void Register(AirlineBase airline);
        bool GiveLandingPermission(string flightCode);
    }
}
