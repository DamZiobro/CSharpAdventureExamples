using System;

namespace decimalDoubleDifference
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float float1 = 1.000000001f;
			double double1 = 1.00000000000000001;
			decimal decimal1 = 1.00000000000000001m;

			Console.WriteLine ("Is float1 == 1: " + (float1 == 1));
			Console.WriteLine ("Is double1 == 1: " + (double1 == 1));
			Console.WriteLine ("Is decimal1 == 1: " + (decimal1 == 1));

		}
	}
}
