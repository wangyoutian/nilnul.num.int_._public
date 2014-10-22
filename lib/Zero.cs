using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer
{
	public partial class Zero
	{
		static public bool Is(BigInteger i) {

			return i == 0;
		
		}

		static public void Assert(BigInteger i) {
			nilnul.bit.Assert.Eval(Is(i));

		}

		static public void AssertNot(BigInteger i) {
			nilnul.bit.Assert.False(Is(i));
		}

		static public void AssertNot(nilnul.num.natural.PositiveNatural3 i)
		{
			nilnul.bit.Assert.False(Is(i.val));
		}
	}
}
