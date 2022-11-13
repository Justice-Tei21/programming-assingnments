using System;




namespace animalia
{
	public class Animal
	{


		string name;
		int age;

		public Animal()
		{
			Console.WriteLine("hello, drum");
		}

		public string GetName()
		{
			Console.WriteLine(name);
			return name;
		}

		public void SetName(string newname)
		{
			name=newname;
		}

        public virtual string Animalsound()
		{
			string sound = "sound of animal";
			Console.WriteLine(sound);
			return sound;
		}


    }
}