using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.num.integer
{
	static public partial class IntegerX 
	{
		

		static public Integer ToInteger(this BigInteger a) {
			return new Integer(a);
		}

		static public BigInteger ToBigint(this IntegerI i) {

			if (i is Integer)
			{
				return ((Integer)i).bigInt;
				
			}

			if (i is integer.Natural2)
			{
				return ((Natural2)i).toBigint();
				
			}
			else
			{
				throw new Exception("Unknown type.");
			}
		
		}

		/// <summary>
		/// parse a string as integer.
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		static public BigInteger Parse(string s) {
			return BigInteger.Parse(s);
		
		}
	
	}

   
}
