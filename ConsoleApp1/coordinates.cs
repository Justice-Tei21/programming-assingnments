using System;



namespace coordinates
{
	public class Cords
	{
		private int minval = -10;
		private int maxval = 10;
		bool hasarr = false;

		private int[][] places;
        Random rand = new Random();

        public Cords(int arrlength=10)
		{
			places = new int[arrlength][];
			if (arrlength > (maxval - minval) * (maxval - minval))
			{
				Console.WriteLine("values to generate exceed possible values ");

            }
			else {
				FillArr();
				Checkdoubles(); 
				hasarr = true;
			}
            
        }

		void FillArr()
		{
			
			for(int i = 0; i<places.Length; i++)
			{
				places[i] =  RandomPoint();
				
			}
		}

		int[] RandomPoint()
		{
			return new int[2] { rand.Next(minval, maxval), rand.Next(minval, maxval) };

        }

		private void Checkdoubles()
		{
			//will check if any array is equal to any future array and changes the future one
			//not guaranteed for the final cord to be unique since in wont compare after a change
			for( int i = 0; i<places.Length; i++)
			{
				for(int j = 0; j<places.Length; j++)
				{
					if (places[i][0] == places[j][0] && places[i][1] == places[j][1])
					{
						places[j] = RandomPoint();
					}
				}
			}
		}
		public void print()
		{
			if (hasarr)
			{
				for (int k = 0; k < places.Length; k++)
				{

					Console.WriteLine("x: " + places[k][1] + " y: " + places[k][0]);
				}
			}
			else Console.WriteLine("no array has been initialized");
		}
	}
}
