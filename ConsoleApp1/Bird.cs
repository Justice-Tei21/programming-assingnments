using System;






namespace school
{
	public class Birdy
	{

		private int height;
		private string name;
		private double weight;

		public int Height{ get { return height; } set { height = value; } }
		public string Name{ get { return name; } set { name = value; } }
		public double Weight{ get { return weight; } set { weight = value; } }

		string caw;



		public Birdy(int tall, string nam, double fat)
		{
			height = tall;
			name = nam;
			weight = fat;


			caw=Cawselect();

      
		}





		 private string Cawselect()
		{
			return name + "caw!";


		}

		virtual public void Sing() 
		{
			Console.WriteLine(caw);
		}
	}
}

