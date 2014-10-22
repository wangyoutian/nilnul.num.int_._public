using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using I = System.Numerics.BigInteger;
using Cut=nilnul.order.interval.Cut2<I>;

namespace nilnul.num.i
{
	public partial class Interval
	{
		Cut _left;

		Cut _right;

		public Cut left {
			get {
				return _left;
			}
		}

		public Cut right {
			get {
				return _right;
			}
		}


		public Interval(Cut left,Cut right)
		{
			this._left = left;
			this._right = right;
		}

		
					

	}
}
