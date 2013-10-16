using System;

namespace Program
{
	public abstract class Personne : IPresentable
	{
		private string _nom;
		public string Nom
		{
			get { return this._nom; }
			protected set {
				if (value == String.Empty)
					this._nom = "Doe";
				else
					this._nom = value; 
			}
		}
		private string _prenom;
		public string Prenom
		{
			get { return this._prenom; }
			set {
				if (value == String.Empty)
					this._prenom = "John";
				else
					this._prenom = value; 
			}
		}

		public virtual string SePresenter()
		{
			return "Je suis une personne :" + this.Nom + " " + this.Prenom;
		}

	}
}

