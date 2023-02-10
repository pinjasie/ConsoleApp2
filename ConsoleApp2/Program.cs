using System;
class Program
{
	public static void Main(string[] args)
	{
		/*	Console.Write("Anna luku 1 ja 10 väliltä: ");
			int luku = int.Parse(Console.ReadLine());
			Console.WriteLine();
			int tulo1 = luku * 1;
			int tulo2 = luku * 2;
			int tulo3 = luku * 3;
			int tulo4 = luku * 4;
			int tulo5 = luku * 5;
			int jako1 = 1 / luku;
			int jako2 = 2 / luku;
			int jako3 = 3 / luku;
			int jako4 = 4 / luku;
			int jako5 = 5 / luku;
			int jaannos1 = 1 % luku;
			int jaannos2 = 2 % luku;
			int jaannos3 = 3 % luku;
			int jaannos4 = 4 % luku;
			int jaannos5 = 5 % luku;
			Console.WriteLine("1 * " + luku + " = " + tulo1 + " 1 / " + luku + " = " + jako1 + " 1 % " + luku + " = " + jaannos1);
			Console.WriteLine("2 * " + luku + " = " + tulo2 + " 2 / " + luku + " = " + jako2 + " 2 % " + luku + " = " + jaannos2);
			Console.WriteLine("3 * " + luku + " = " + tulo3 + " 3 / " + luku + " = " + jako3 + " 3 % " + luku + " = " + jaannos3);
			Console.WriteLine("4 * " + luku + " = " + tulo4 + " 4 / " + luku + " = " + jako4 + " 4 % " + luku + " = " + jaannos4);
			Console.WriteLine("5 * " + luku + " = " + tulo5 + " 5 / " + luku + " = " + jako5 + " 5 % " + luku + " = " + jaannos5);
		*/
		/* Console.Write("Anna pituutesi senttimetreinä: ");
		double pituusSentteina = double.Parse(Console.ReadLine());
		Console.WriteLine();
		double pituusMetreina = pituusSentteina / 100.0;
		double pituusMaileina = pituusMetreina / 1609.34;
		double pituusJaardeina = pituusMetreina / 0.9144;
		double pituusTuumina = pituusSentteina / 2.54;
		Console.WriteLine(string.Format("{0:0.00} metriä ", pituusMetreina));
		Console.WriteLine(string.Format("{0:0.00} mailia ", pituusMaileina));
		Console.WriteLine(string.Format("{0:0.00} jaardia ", pituusJaardeina));
		Console.WriteLine(string.Format("{0:0.00} tuumaa ", pituusTuumina));
	*/
		/*Console.WriteLine("VALUUTTALASKURI"); //valuuttalaskuri-tehtävä aiemmalta ajalta, lisätty vaan silmukka
			Console.WriteLine("---------------");
			Console.WriteLine();
			Console.Write("Anna summa euroina: ");
			double euroja = double.Parse(Console.ReadLine());
			Console.Write("Vastaa 1 jos haluat muuntaa dollareiksi ja 2 jos haluat muuntaa punniksi: "); //käyttäjän syöte määrittää sen, suoritetaanko if-silmukka vai ei
			int valinta = int.Parse(Console.ReadLine());
			Console.WriteLine();
			double dollareita = euroja * 1.21;
			double puntia = euroja * 0.87;
			if (valinta == 1)
			{
				Console.WriteLine(string.Format("{0,10:0.00}", dollareita + " $")); //jos käyttäjän syöte on 1, silmukka suoritetaan
			}
			else
			{
				Console.WriteLine(string.Format("{0,10:0.00}", puntia + " £")); //jos 2, suoritetaan else-lauseke
			}
		*/
		/*Console.Write("Paistaako aurinko (K/E)? "); //käyttäjältä kysytään K tai E-syötettä
		char aurinko = char.Parse(Console.ReadLine()); //käyttäjän vastaus
		Console.Write("Sataako vettä (K/E)? "); //jne yms sama juttu
		char sade = char.Parse(Console.ReadLine()); //vesi on märkää
		Console.Write("Onko lämpötila >0 (K/E)? "); //kaikkien yllätykseksi tämä rivi tekee saman kuin kaksi aiempaa
		char lampotila = char.Parse(Console.ReadLine()); //wau ihme ja kumma samoin tämä
		Console.WriteLine();
		if(aurinko == 'K' && sade == 'K' && lampotila == 'K') //eka if-silmukka, joka suoritetaan tiettyjen ehtojen täyttyessä
		{
			Console.WriteLine("Aurinko paistaa ja vettä sataa, taitaa tulla kesä");
		}
		else if(aurinko == 'E' && sade == 'K' && lampotila == 'K') //jos edellisen silmukan ehdot ei täyty, toistuu joko tämä...
		{
			Console.WriteLine("Syksy saapui tuuli vei lehdet mennessään");
		}
		else if(aurinko == 'E' && sade == 'E' && lampotila == 'K') //...tämä...
		{
			Console.WriteLine("Jo joutui armas aika ja suvi suloinen");
		}
		else if (aurinko == 'K' && sade == 'E' && lampotila == 'E') //...tai tämä
		{
			Console.WriteLine("Keväinen talvi kesän tuo");
		}
		else 
		{ //ja jos mikään ehdoista ei täyty, tai käyttäjä antaa syötteenä huuhaata, else-silmukka toistuu
		
			Console.WriteLine("Onpa erikoinen sää!");
		}*/
		/*Console.WriteLine("Tehtävä 7.1");
		Console.WriteLine("-----------");
		Console.WriteLine(); //tyhjän rivin tulostus
		Console.Write("Anna aloitusluku: ");
		int luku = int.Parse(Console.ReadLine()); //käyttäjän syöte
		for (;luku >= 0; luku--) //for-silmukka joka pyörii annetusta luvusta alaspäin nollaan asti
		{
			Console.WriteLine(luku);
		}
		*/
	}
}