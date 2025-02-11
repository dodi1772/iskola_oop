using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola_oop
{
	internal class Osztaly
	{
		private string Nev {  get; set; }
		List<Diak> diakok =new List<Diak>();
		private Tanar Osztalyfonok { get; set; }

		public Osztaly(string nev, Tanar osztalyfonok)
		{
			Nev = nev;
			Osztalyfonok = osztalyfonok;
		}
		public void HozzaadDiak(Diak diak)
		{
            if (diakok.Count<=25)
            {
				diakok.Add(diak);
                Console.WriteLine($"Sikeresen hozzáadva a(z) {Nev} osztályhoz.");
            }
            else
            {
                Console.WriteLine("Az adott osztály megtelt.");
            }
        }
		public void OsszesDiakKilistazas()
		{
            foreach (var diak in diakok)
            {
				diak.TeljesNevKiirasa();
            }
        }
		public void OsztalyfonokKiirasa()
		{
			Osztalyfonok.OktatottTantargyak();
		}
	}
}
