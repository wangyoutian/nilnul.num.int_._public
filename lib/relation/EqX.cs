using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.integer.relation
{
	static public partial class EqX
	{
		static public void Assert(BigInteger a,BigInteger b) {

			nilnul.bit.AssertX.Eq(a, b);
		}
	}
}
