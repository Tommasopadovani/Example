using BlaisePascal.Example.Domain;
using System;
using System.Collections.Generic;
using System.Text;

public class Program// Questa e una classe
{
    //metodo di entrata di esecuzione del codice 
    public static void Main()
    {
        Vehicle vehicle = new Vehicle();
        string licence = vehicle.GEtLicensePlate();

        Console.WriteLine(licence);
    }

}
