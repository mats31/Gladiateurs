using System;

namespace Program
{
	public class Client : Personne, IPresentable
	{

		public static int nbClient = 0;

		public Client (string p_nom, string p_prenom)
		{
			this.Nom = p_nom;
			this.Prenom = p_prenom;

			Client.nbClient ++;
		}

		public object obtenirCommande()
		{
			//recherche dans la bdd
			return null;
		}

		public object obtenirCommande(DateTime p_dateDebut)
		{
			//recherche dans la bdd
			return null;
		}

		public object obtenirCommande(DateTime p_dateDebut, DateTime p_dateFin)
		{
			//recherche dans la bdd
			return null;
		}

		public override string SePresenter()
		{
			return "coucou, je suis "+this.Nom + " ";
		}

		public static string DireBonjour ()
		{
			return "bonjour";
		}
	}
}

