using System;



namespace spacey
{
	public class Class1
	{

		private int crazies = 0;
		private Random random = new Random();
		private string[] repository;



        public int Crazies
		{
			get { return crazies; }
			set { crazies = (value + 1)!; }
		}
		public Class1(int people)
		{
			crazies = people;
			repository = new string[people];
			individuals();
		}

		private void individuals()
		{
			string[] firstName = { "Philip", "Michael", "Franklin", "Trevor", "Judas","Jam","Mario" };
			string[] lastName = { "Costa", "Iscariot", "Smith", "Plumber", "Webb","M. Mario" };

			for(int i = 0; i < crazies; ++i)
			{
				
				repository[i] = firstName[random.Next() % firstName.Length] +" " 
					+ lastName[random.Next() % lastName.Length];

			}

		}

		public void getpeople()
		{
			for(int i = 0; i < repository.Length; i++)
			{
				Console.WriteLine(repository[i]);
			}
		}
	}
}