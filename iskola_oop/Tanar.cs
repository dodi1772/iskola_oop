using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola_oop
{
	internal class Tanar
	{
		private string Nev {  get; set; }
		List<Tantargy> Tantargyak = new List<Tantargy>();
		private int TanarID { get; set; }

		public Tanar(string nev, int tanarID)
		{
			Nev = nev;
			TanarID = tanarID;
		}
		public void HozzaadTantargy(Tantargy tantargy)
		{
			Tantargyak.Add(tantargy);
            Console.WriteLine("Tantárgy sikeresen hozzáadva a tanárhoz.");
        }
		public void OktatottTantargyak()
		{
            Console.WriteLine($"{Nev} oktatott tárgyai: ");
            foreach (var tantargy in Tantargyak)
            {
                tantargy.TantargyAdatok();
            }
        }
	}
}
