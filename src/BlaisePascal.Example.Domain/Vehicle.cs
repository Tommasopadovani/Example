using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.Example.Domain
{
    public class Vehicle
    {
        private int _id;
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevlPercentage;

        public string LicensePlate { get; private set; }

        //unico metodo sewnza tipo di ritorno, costruttore della classe
        public Vehicle(string licensePlate)
        { 
         LicensePlate= licensePlate;        
        }


    }
}










