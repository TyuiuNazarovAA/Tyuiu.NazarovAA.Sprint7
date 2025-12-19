using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NazarovAA.Sprint7.Project.V14.Lib
{
    public class CityRoute
    {
        public string BusNumber { get; private set; }
        public string FromStation { get; private set; }
        public string ToStation { get; private set; }
        public int Minutes { get; private set; }
        public CityRoute(string busNumber, string fromStation, string toStation, int minutes)
        {
            BusNumber = busNumber;
            FromStation = fromStation;
            ToStation = toStation;
            Minutes = minutes;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not CityRoute route)
            {
                return false;
            }

            if (route.BusNumber == BusNumber &&
                route.FromStation == FromStation &&
                route.ToStation == ToStation &&
                route.Minutes == Minutes)
            {
                return true;
            }

            return false;
        }
    }
}
