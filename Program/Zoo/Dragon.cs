using System;
using Program.Zoo.Interfaces;

namespace Program.Zoo
{
	public class Dragon : Animal, IVolant, IAttaquant
	{
		public Dragon(string nom, int age)
			:base("Fantastique", nom, age, "Dragon")
		{

		}

		public string Voler ()
		{
			return "Je vole !!!";
		}

		public string SePoser()
		{
			return "Hop, je me pose.";
		}

		public override string Crier()
		{
			return "Grooooooooaaaaarrrr !";
		}

		public string Attaquer()
		{
			return "Souffle du feu !!!";
		}
	}
}

