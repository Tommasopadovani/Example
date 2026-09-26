using System.Runtime.InteropServices.Marshalling;

public class Program// Questa e una classe
{
    //metodo di entrata di esecuzione del codice 
    public static void Main()
    {

        Console.WriteLine("Benvenuto nella libreria EasyLibrary");
        int costoSpedizioneSingoloPacco = 5;
        costoSpedizioneSingoloPacco = 10;

        int numeroPacchiComprati = 2;

        string tipoDiCOnsegna = "Standard";

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        Console.WriteLine("il tipo di consegna selezionato è " + tipoDiCOnsegna);
        Console.WriteLine($"il costo totale è {costoTotale} ");
    }

}