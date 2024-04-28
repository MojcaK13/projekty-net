namespace SnookerCalc
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe czerwonych bil na stole:");
            string redString = Console.ReadLine();
            int reds = int.Parse(redString);
            TablePoints tablePoints = new TablePoints(reds);
            tablePoints.wyswietlBile();
            tablePoints.wyswietlMozliwePunkty();
        }
    }
}