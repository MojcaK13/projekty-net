namespace SkokiCalc
{ 
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Podaj typ skoczni (1:normalna,2:duza,3:mamucia):");
            string typString = Console.ReadLine();
            int typ = int.Parse(typString);
            Console.WriteLine("Podaj punkt K skoczni:");
            string kPointStr = Console.ReadLine();
            double kPoint = double.Parse(kPointStr);
            Console.WriteLine("Podaj odleglosc:");
            string odlegloscString = Console.ReadLine();
            double odleglosc = double.Parse(odlegloscString);
            JumpPoints jumpPoints = new JumpPoints(typ,odleglosc,kPoint);
            jumpPoints.PodajTypSkoczni();
            jumpPoints.PoliczPunktyZaSkok();
        }
    }
}