using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnookerCalc
{
    public class TablePoints(int myReds)
    {
        int reds = myReds;

        public void wyswietlBile()
        {
            Console.WriteLine("Ilość czerwonych bil na stole:"+reds); 
        }
        public void wyswietlMozliwePunkty()
        {
            int availablePoints = 0;
            if (reds == 15)
            {
                availablePoints = 147;
            }
            else if (reds < 15 & reds >= 1)
            {
                
                Console.WriteLine("Czy byla wbita ostatnio czerwona bila?");
                char wbita=Console.ReadKey().KeyChar;
                if (wbita == 'T' || wbita == 't')
                {
                    availablePoints = reds * 8 + 34;
                }
                else if (wbita=='N' || wbita=='n')
                {
                    availablePoints = reds * 8 + 27;
                }
                else
                {
                    Console.WriteLine("Nieprawidlowa wartosc!");
                }
            }else if (reds == 0)
            {
                Console.WriteLine("Czy byla wbita ostatnio czerwona bila?");
                char wbita = Console.ReadKey().KeyChar;
                if (wbita == 'T' || wbita == 't')
                {
                    availablePoints = reds * 8 + 34;
                }
                else if (wbita == 'N' || wbita == 'n')
                {
                    Console.WriteLine("Podaj liczbe kolorowych bil na stole");
                    string colcount = Console.ReadLine();
                    int colors = int.Parse(colcount);
                    switch (colors)
                    {
                        case 0:
                            availablePoints = 0;
                            break;
                        case 1:
                            availablePoints = 7;
                            break;
                        case 2:
                            availablePoints = 13;
                            break;
                        case 3:
                            availablePoints = 18;
                            break;
                        case 4:
                            availablePoints = 22;
                            break;
                        case 5:
                            availablePoints = 25;
                            break;
                        case 6:
                            availablePoints = 27;
                            break;
                        default:
                            Console.WriteLine("Niewlasciwa wartosc!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidlowa wartosc!");
                }
            }
            Console.WriteLine("Ilosc mozliwych do zdobycia punktow wynosi:" + availablePoints);
        }
    }
}
