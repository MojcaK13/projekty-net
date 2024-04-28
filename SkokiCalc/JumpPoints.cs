using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkokiCalc
{
    public class JumpPoints(int typ, double odleglosc, double kPoint)
    {
        int typ = typ;
        double odleglosc = odleglosc;
        double kPoint = kPoint;

        public void PodajTypSkoczni()
        {
            switch (typ)
            {
                case 1:
                    Console.WriteLine("To jest skocznia normalna.");
                    break;
                case 2:
                    Console.WriteLine("To jest duza skocznia.");
                    break;
                case 3:
                    Console.WriteLine("To jest mamucia skocznia.");
                    break;
                default:
                    Console.WriteLine("Skocznia nieznana...");
                    break;
            }
        }
        public void PoliczPunktyZaSkok()
        {
            double punkty = 0;
            double baza = 60;
            double bazaMamut = 120;
            double punktyZaMetr;
            switch (typ)
            {
                case 1:
                    punktyZaMetr = 2;
                    if (odleglosc == kPoint)
                    {
                        punkty = baza;
                    }
                    else if (odleglosc > kPoint)
                    {
                        punkty = baza + (punktyZaMetr*(odleglosc-kPoint));
                    }
                    else if (odleglosc < kPoint)
                    {
                        punkty = baza - (punktyZaMetr * (kPoint-odleglosc));
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidlowa wartosc!");
                    }
                    break;
                case 2:
                    punktyZaMetr = 1.8;
                    if (odleglosc == kPoint)
                    {
                        punkty = baza;
                    }
                    else if (odleglosc > kPoint)
                    {
                        punkty = baza + (punktyZaMetr * (odleglosc - kPoint));
                    }
                    else if (odleglosc < kPoint)
                    {
                        punkty = baza - (punktyZaMetr * (kPoint - odleglosc));
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidlowa wartosc!");
                    }
                    break;
                case 3:
                    punktyZaMetr = 1.2;
                    if (odleglosc == kPoint)
                    {
                        punkty = bazaMamut;
                    }
                    else if (odleglosc > kPoint)
                    {
                        punkty = bazaMamut + (punktyZaMetr * (odleglosc - kPoint));
                    }
                    else if (odleglosc < kPoint)
                    {
                        punkty = bazaMamut - (punktyZaMetr * (kPoint - odleglosc));
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidlowa wartosc!");
                    }
                    break;
                default:
                    Console.WriteLine("Skocznia nieznana...");
                    break;
            }
            Console.WriteLine("Punkty za skok: " + punkty);
        }
    }
}
