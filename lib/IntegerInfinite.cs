using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;
using nilnul.math.number.real;

namespace nilnul.math.complex.real.rational.integer
{
    public class IntegerInfinite:Integer
    {

		private bool PositiveNegative
		{
			get;
			set;
		}

		public IntegerInfinite(bool PositiveNegative) {
			this.PositiveNegative = PositiveNegative;
		}

		static private readonly IntegerInfinite positive = new IntegerInfinite(true);
		static private readonly IntegerInfinite negative = new IntegerInfinite(false);

		static public IntegerInfinite Positive {
			get {
				return positive;
			}
		}
		static public IntegerInfinite Negative {
			get {
				return negative;
			}
		}

    }
}
