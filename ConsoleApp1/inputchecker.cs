using System;
using System.Text.RegularExpressions;

public class Inputchecker
{

	string input="";
	string password="";

	bool loggedin = false;

	string Password {
		get { if(loggedin)return password; return ""; } 
		 }
	enum options {INVALIDPASS,VALIDPASS,INVALIDMAIL,VALIDMAIL}


	
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


	// will use this part to check some more advanced concepts
	private void Checkpassword()
	{
		if (string.IsNullOrEmpty(input))
		{
			Console.WriteLine("absoulte waste of space G\nA\nR\nB\nA\nG\nE\n");
			input = "";

        }
        const string passwordv = @"[\w\%\&\?\#\¤\.\~\^]{4,20}";
        const string emailv = @"^[\w-\.]+@[\w-]+\.[a-Z]{2,4}$";

        Regex validpass = new Regex(passwordv);
		Regex validemailv = new Regex(emailv);



		try
		{

			
			

			int a=(validpass.IsMatch(input) ? (int)options.VALIDPASS:(int)options.INVALIDPASS );
            int B = (validemailv.IsMatch(input) ? (int)options.VALIDMAIL : (int)options.INVALIDMAIL);


            switch (a)
			{

				case (int)options.VALIDPASS:
					password = input;
					Console.WriteLine("password is accepted");
					break;

				case (int)options.INVALIDPASS:
					{
						throw new Exception("password is invalid");



					}
				default:
					Console.WriteLine("what did you write to get this message?");
					break;
			}


			if (B - 2 == 0)
				Console.WriteLine("email invalid");
			else Console.WriteLine("please verify your email");



		}
		catch {

			Console.WriteLine("please exit the program");
		
		}
	
	}

}
