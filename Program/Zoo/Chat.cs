using System;

namespace Program.Zoo
{
	public class Chat : Animal
	{
		public Chat (string nom, int age)
			:base("Chat", nom, age, "Matou")
		{

		}

		public override string Crier()
		{
			return "Miaaaaaaaaoooouw !";
		}
	}
}

