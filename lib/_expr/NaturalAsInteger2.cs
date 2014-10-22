using System;
using System.Numerics;

namespace nilnul.num.integer
{
	public partial class Natural2:IntegerI
	{
		natural.NaturalI _val;

		public Natural2(natural.NaturalI val)
		{
			this._val = val;
		}

		public BigInteger toBigint() {
			return natural.NaturalX.ToBigint(_val);
		}
					

	}
}
