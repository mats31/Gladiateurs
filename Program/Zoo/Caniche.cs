using System;

namespace Program.Zoo
{
	public class Caniche : Chien
	{
		public Caniche (string nom, int age)
			:base(nom, age)
		{
			this.Race = "Caniche";
		}

		public override string Crier()
		{
			return "Wiiiiiiiiif Wif Wif Wif !";
		}
	}
}

