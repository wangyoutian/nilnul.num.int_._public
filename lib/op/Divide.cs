using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.i.op
{
	public partial class Divide 
	{


		static public BigInteger Eval(BigInteger x, num.natural.__bigint.be.Positive.Asserted y) {
			return x / y.val;
		}

		static public num.natural.__bigint.be.Positive.Asserted Eval(num.natural.__bigint.be.Positive.Asserted x, num.natural.__bigint.be.Positive.Asserted y) {
			return new num.natural.__bigint.be.Positive.Asserted( x.val/y.val);
		}

		static private readonly Divide _Instance = new Divide();
		private Divide() { }
		static public Divide Instance
		{
			get
			{
				return _Instance;
			}
		}


		public override string ToString()
		{
			return "/";

		}
	}
}
