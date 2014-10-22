using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.integer;
namespace nilnul.number.integer
{
	public partial class IntegerMultiply
	{
		public Integer eval(Integer a,Integer b)
		{
			return a.bigInt * b.bigInt;
		}
		public IntegerI eval(IntegerI a, IntegerI b)
		{
			if (a is Integer && b is Integer)
			{
				return eval((Integer)a, (Integer)b);
				
			}
			else
			{
				throw new Exception();
			}
		}
	}
}
