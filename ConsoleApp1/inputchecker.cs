using System;
using System.Text.RegularExpressions;



namespace floating
{
	public class Inputchecker
	{

		string input = "";
		string password = "";
		string email = "";

		bool loggedin = false;

		string Password
		{
			get { if (loggedin) return password; return ""; }
		}
		enum options { INVALIDPASS, VALIDPASS, VALIDMAIL, INVALIDMAIL }



		public Inputchecker()
		{
			Console.WriteLine("Enter password and email");
			input=ReadInput();
			email=ReadInput();
			Checkpassword();
		}

		private string ReadInput()
		{
			return Console.ReadLine();
		}


		// will use this part to check some more advanced concepts
		private void Checkpassword()
		{
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("absoulte waste of space \nG\nA\nR\nB\nA\nG\nE\n");
				input = "";

			}
			string passwordv = @"[\w\%\&\?\#\¤\.\~\^]{4,20}";
			string emailv = @"^[\w-]+@[\w-]+\.[A-z]{2,4}$";

			Regex validpass = new Regex(passwordv);
			Regex validemailv = new Regex(emailv);



			try
			{




				int a = (validpass.IsMatch(input) ? (int)options.VALIDPASS : (int)options.INVALIDPASS);
				int B = (validemailv.IsMatch(email) ? (int)options.VALIDMAIL : (int)options.INVALIDMAIL);
				

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


				if (B - 2 == 0) {password="";email="";  throw new Exception("email invalid"); }
				else {Console.WriteLine("please verify your email");}



			}
			catch
			{

				Console.WriteLine("please exit the program");

			}

		}

	}
}
