using System;

public class Inputchecker
{

	string input;


	bool isvalidpassword;
	public Inputchecker()
	{
		Console.WriteLine("Enter password");
		ReadInput();



	}

	private void ReadInput()
	{
		input=Console.ReadLine();
	}

	private void Checkpassword()
	{
		string pattern = @"(){4,20}";

	}

}
