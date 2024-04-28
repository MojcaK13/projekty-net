namespace Sailing
{ 
public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe lodek:");
            string boatsStr = Console.ReadLine();
            int boats = int.Parse(boatsStr);
            Console.WriteLine("Podaj liczbe wyscigow");
            string racesStr = Console.ReadLine();
            int races = int.Parse(racesStr);
            int[] result = new int[races];
            Random randomResult = new Random();
            for (int race = 0; race < races; race++)
            {
                result[race] = randomResult.Next(1,boats+2);
            }
            Console.WriteLine("Wyniki regaty: "+string.Join(",",result));
        }
    }
}