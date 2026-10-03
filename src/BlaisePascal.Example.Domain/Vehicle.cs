using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.Example.Domain
{
    public class Vehicle
    {
        private int _id;
        private string _LicensePlate;
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevlPercentage;

        public string GEtLicensePlate()
        {
            return _LicensePlate;
        }

    }
}
