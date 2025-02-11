using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola_oop
{
	internal class Tantargy
	{
		private string Nev {  get; set; }
		private int KontaktOrak { get; set; }

		public Tantargy(string nev, int kontaktOrak)
		{
			Nev = nev;
			KontaktOrak = kontaktOrak;
		}
		public void TantargyAdatok()
		{
            Console.WriteLine($"Tantárgy neve: {Nev} Heti óraszám: {KontaktOrak}");
        }
		public string TantargyNev()
		{
			return Nev;
		}
	}
}
