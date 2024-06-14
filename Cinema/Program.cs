using System.Diagnostics.Tracing;

class Cinema
{

    public static void Main(string[] args)
    {
        string typeMovie = Console.ReadLine();
        int countRows = int.Parse(Console.ReadLine());
        int seatsRow = int.Parse(Console.ReadLine());

        double premier = 12.00;
        double normal = 7.50;
        double discount = 5.00;
        double price = 0.00;

        if (typeMovie == "Premiere")
        {
            price = ( countRows * seatsRow)*premier;
            Console.WriteLine($"{price:F2}");
        }
        else if(typeMovie=="Normal")
        {
            price = (countRows * seatsRow) * normal;
            Console.WriteLine($"{price:F2}");
        }
        else if (typeMovie=="Discount")
        {
            price = (countRows * seatsRow) * discount;
            Console.WriteLine($"{price:F2}");

        }
    }
}
