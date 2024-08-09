using StateATMProject.Model;

public class Program
{  
    public static void PrintCardDetails()
    {
        ATMMachine machine = new ATMMachine();
        Console.WriteLine("Initially the card is not inserted");
        machine.EnterPin();
        machine.withdraw();
        machine.EjectCard();
        machine.InsertCard();

        Console.WriteLine();

        Console.WriteLine("Now Card is Inserted");

        machine.EnterPin();
        machine.withdraw();
        machine.EjectCard();

    }
    public static void Main(string[] args)
    {
        PrintCardDetails();
    }


}
