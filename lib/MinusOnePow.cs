using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.int_
{
	public partial class MinusOnePow
	{
		static public int Eval(int pow) {
			return pow % 2 == 0 ? 1 : -1;
		
		}
	}
}
