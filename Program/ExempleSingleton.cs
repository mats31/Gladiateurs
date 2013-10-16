using System;

namespace Program
{
	class ExempleSingleton
	{
		private static ExempleSingleton _Instance;

		protected ExempleSingleton ()
		{
		}

		public static ExempleSingleton GetInstance()
		{
			if (ExempleSingleton._Instance == null) 
			{
				ExempleSingleton._Instance = new ExempleSingleton ();
			}
			return ExempleSingleton._Instance;
		}
	}
}

