using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        Random uretec = new Random();
        DateTime gelmekvak = Convert.ToDateTime("08:01");
        int islemsuresi;
        int sgelen = 1;
        DateTime cik = Convert.ToDateTime("08:01");
        int musterisa = 1;
        DateTime kapatma = Convert.ToDateTime("17:00");
        while (true)
        {
            islemsuresi = uretec.Next(1, 11);
            cik = cik.AddMinutes(Convert.ToDouble(islemsuresi));

            if (cik <= kapatma)
            {

                Console.WriteLine(musterisa + "  gelmek vakti: " + gelmekvak + " işlem süresi: " + islemsuresi + " cık: " + cik);
                musterisa++;
                sgelen = uretec.Next(1, islemsuresi);
                gelmekvak = gelmekvak.AddMinutes(sgelen);

            }
            else
            {
                break;
            }
        }
        Console.Read();

    }
}
