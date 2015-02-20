// Sunil new terst
using System;

namespace dsfsdff
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			MainClass obj = new MainClass ();
			obj.Foo ();
		}

		void Foo()
		{
			throw new Exception ();
		}
	}
}
