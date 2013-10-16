using System;
using Program.Zoo.Interfaces;

namespace Program.Zoo
{
	public class Chien : Animal, IAttaquant
	{

		public Chien (string nom, int age)
			:base("Chien", nom, age, "Labrador")
		{

		}

		public Chien (string nom, int age, string race)
			:this(nom, age)
		{
			this.Race = race;
		}

		public override string Crier()
		{
			//string l_nouveauCri = base.Crier ();
			//l_nouveauCri += " et Waf ";
			//return l_nouveauCri;

			return "Woooooouf ! Wouf ! Wouf! Wouf!";
		}

		public string Attaquer()
		{
			return "Je te mords!!";
		}
	}
}

