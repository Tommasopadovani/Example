using BlaisePascal.Example.Domain;
using System.Runtime.InteropServices.Marshalling;

public class Program// Questa e una classe
{
    //metodo di entrata di esecuzione del codice 
    public static void Main()
    {

        Console.WriteLine("inserisc il nome del cliente");
        string nomeCliente = Console.ReadLine();

        Console.WriteLine($"Benvenuto {nomeCliente} nella libreria EasyLibrary");

        Console.WriteLine("inserisc il tipo di spedizione");
        string tipoDiCOnsegna = (Console.ReadLine());



        int costoSpedizioneSingoloPacco = 5;
        costoSpedizioneSingoloPacco = 10;

        Console.WriteLine("inserisc il nuro di pacchi acquistati");
        int numeroPacchiComprati = int.Parse(Console.ReadLine());

        

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        Console.WriteLine("il tipo di consegna selezionato è " + tipoDiCOnsegna);
        Console.WriteLine($"il costo totale è {costoTotale} ");

        lamp lamp1 = new lamp(); //ipo, nome oggetto, ugaule , new, tipo 
    }

}
