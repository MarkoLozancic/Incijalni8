using System;

namespace Incijalni8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prvi,drugi,treci,x, i;
            prvi = 0;
            drugi = 1;
            Console.WriteLine("Unesi broj clana fibonnacijevog niza kojeg zelis da ti ispisem: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x > 2)
            {
                for (i = 3; i <= x; i++)
                {
                     treci=prvi + drugi ;
                    prvi = drugi;
                    drugi = treci;
                    if (i == x)
                    {
                        Console.WriteLine("Vrijednost clana fibonnacijevog niza kojeg si odabrao je: " + treci);
                        Console.ReadKey();
                    }
                }
            }
            else
            { Console.WriteLine("Broj clana niza mora biti veci od 2!"); }


        }
    }
}
