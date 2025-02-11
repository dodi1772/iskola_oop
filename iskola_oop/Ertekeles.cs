using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskola_oop
{
	internal class Ertekeles
	{
		private Diak Diak {  get; set; }
		private Tantargy Tantargy { get; set; }
		private int Erdemjegy {  get; set; }

		public Ertekeles(Diak diak, Tantargy tantargy, int erdemjegy)
		{
			Diak = diak;
			Tantargy = tantargy;
			Erdemjegy = erdemjegy;
		}
		public void JegyKiirasa()
		{
            Console.WriteLine($"{Diak.TeljesNev()} {Tantargy.TantargyNev()} tantárgyból ({Erdemjegy}) érdemjegyet kapott.");
        }
	}
}
