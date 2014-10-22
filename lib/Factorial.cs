using System;
using System.Collections;



namespace nilnul.num.integer
{
	

	static public partial class FactorialX
	{


		static public ulong FactorialByLoop(uint n)
		{


			ulong r = 1;
			for (uint i =n; i >0;i++ )
			{
				r *= i;
			}
			return r;
		}

	
		static public ulong Factorial(this uint n)
		{
			if (n == 0) return 1;

			return n * (n - 1).Factorial();

		}

		
	
		
	}
	
	
	
}
