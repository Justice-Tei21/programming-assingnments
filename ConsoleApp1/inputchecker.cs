using System;
using System.Text.RegularExpressions;

public class Inputchecker
{

	string input;
	string password;


	
	public Inputchecker()
	{
		Console.WriteLine("Enter password");
		ReadInput();
		Checkpassword();
	}

	private void ReadInput()
	{
		input=Console.ReadLine();
	}

	private void Checkpassword()
	{
		const string pattern = @"(){4,20}";

		Regex rg = new Regex(pattern);
		try {
		if (rg.IsMatch(input))
		{
				password = input;
		}

		else
		{
            throw new Exception(" ");
        }



		 }
		catch {
		}
	}

}
