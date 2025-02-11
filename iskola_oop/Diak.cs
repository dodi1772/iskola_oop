using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola_oop
{
	internal class Diak
	{
		private string Nev {  get; set; }
		private string Osztaly { get; set; }
		private int Azonosito { get; set; }

		public Diak(string nev, string osztaly, int azonosito)
		{
			Nev = nev;
			Osztaly = osztaly;
			Azonosito = azonosito;
		}
		public void TeljesNevKiirasa()
		{
            Console.WriteLine($"Diák neve: {Nev} Osztálya: {Osztaly}");
        }
		public string TeljesNev()
		{ return Nev; }
	}
}
