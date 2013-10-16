using System;

namespace Program.Zoo
{
	public abstract class Animal
	{
		private string _espece;
		public string Espece 
		{
			get { return this._espece; }
			protected set { this._espece = value; }
		}
		private string _race;
		public string Race 
		{
			get { return this._race; }
			protected set { this._race = value; }
		}
		private string _nom;
		public string Nom 
		{
			get { return this._nom; }
			protected set { this._nom = value; }
		}
		private int _age;
		public int Age 
		{
			get { return this._age; }
			protected set {
				if (value < 0)
					this._age = 0;
				else
					this._age = value; 
			}
		}
		private static int NOMBRE_ANIMAUX = 0;

		public Animal (string espece, string nom, int age, string race)
		{
			this.Espece = espece;
			this.Nom = nom;
			this.Age = age;
			this.Race= race;
			Animal.NOMBRE_ANIMAUX ++;
		}

		public string SePresenter()
		{
			return("Je suis un "+this._espece+" de la race des "+this._race+", je m'apelle "+this._nom+" et j'ai "+this._age.ToString()+" ans.");
		}

		public abstract string Crier ();

		public static string Zoo()
		{
			return("Il y a " + Animal.NOMBRE_ANIMAUX + " animaux dans le zoo.");
		}
	}
}