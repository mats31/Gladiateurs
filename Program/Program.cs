using System;
using System.Collections.Generic;
using Program.Zoo.Interfaces;
using Program.Zoo;

namespace Program
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*Caniche l_caniche;
			Chat l_chat;
			Chien l_chien;

			l_caniche = new Caniche ( "Tapette", -50);
			l_chat = new Chat ("Tom", 40);
			l_chien = new Chien ("Le Chien", 2);

			Console.WriteLine(l_caniche.SePresenter());
			Console.WriteLine(l_chat.SePresenter());
			Console.WriteLine(l_chien.SePresenter());

			Console.WriteLine(l_caniche.Crier());
			Console.WriteLine(l_chat.Crier());
			Console.WriteLine(l_chien.Crier());

			Console.WriteLine (Animal.Zoo ());

			Console.ReadKey();*/

			List<Animal> maListe = new List<Animal>();

			Chien   animal1 = new Chien("Le Chien", 2);
			Chat    animal2 = new Chat("Tom", 40);
			Caniche animal3 = new Caniche ("Tapette", 2);
			Dragon  animal4 = new Dragon ("Shenron", 2000);

			maListe.Add(animal1);
			maListe.Add(animal2);
			maListe.Add(animal3);
			maListe.Add (animal4);

			foreach (Animal b_animal in maListe)
			{
				Console.WriteLine(b_animal.Crier());

				if (b_animal is IVolant) 
				{
					IVolant aniVol = (IVolant)b_animal;
					Console.WriteLine (aniVol.Voler ());
				}

				if (b_animal is IAttaquant)
				{
					IAttaquant aniAtt = (IAttaquant)b_animal;
					Console.WriteLine (aniAtt.Attaquer ());
				}
			}

			Console.ReadKey();
		}
	}
}

//List<Client> maListe = new List<Client>();

//Client cli1 = new Client("Jo", "Greg");
//Client cli2 = new Client("Biabiany", "Mathis");

//maListe.Add(cli1);
//maListe.Add(cli2);

//foreach (Client b_cli in maListe)
//{
//	Console.WriteLine(b_cli.Nom);
//}
