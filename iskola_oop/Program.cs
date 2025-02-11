namespace iskola_oop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*("\t1. Diák hozzáadása\n\t2. Tanár hozzáadása\n\t3. Tanár tantárgy hozzáadása\n\t4. Tanár oktatott tárgyainak kiírása\n\t5. Tantárgy hozzáadása\n\t6. Egy tárgy adatainak kiírása\n\t7. Osztály hozzáadása\n\t8. Diák hozzáadása osztályhoz\n\t9. Összes diák az osztályban kilistázása\n\t10. Osztályfőnök kiírása\n\t11. Értékelés hozzáadása\n\t12. Diák értékeléseinek kiírása");*/
			List<string> keresztnevek = new List<string>
		{
			"Anna", "Béla", "Cecília", "Dávid", "Erika",
			"Ferenc", "Gábor", "Hanna", "Imre", "Júlia"
		};
			List<Diak> diakok= new List<Diak>();
			Tanar tanar = new Tanar("Dezső", 234);
			Osztaly osztaly = new Osztaly("11E", tanar);
			int azonos = 123;
            for (int i = 0; i < keresztnevek.Count; i++)
            {
				azonos++;
				Diak diak = new Diak(keresztnevek[i], "11E", azonos);
				osztaly.HozzaadDiak(diak);
				diakok.Add(diak);
			}

			Tantargy tantargy = new Tantargy("Matematika", 14);
			tanar.HozzaadTantargy(tantargy);
			tantargy=new Tantargy("Fizika", 11);
			tanar.HozzaadTantargy(tantargy);
			tanar.OktatottTantargyak();
			osztaly.OsszesDiakKilistazas();
			osztaly.OsztalyfonokKiirasa();
			Ertekeles ertekeles = new Ertekeles(diakok[1], tantargy, 4);
			ertekeles.JegyKiirasa();
		}
	}
}
