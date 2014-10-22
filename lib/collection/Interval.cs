using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.integer.collection
{
	public partial class Interval
	{
		Bound _left;
		Bound _right;

		public Bound left {
			get {
				return _left;
			}
		}

		public Bound right {
			get {
				return _right;
			}
		}


		public Interval(Bound left,Bound right)
		{
			this._left = left;
			this._right = right;
		}

		public static Interval Create(Bound left,Bound right) {

			return new Interval(left, right);
		
		}
					

		public partial class Bound {
			private OpenClose _openClose;
			
			public OpenClose openClose {
				get {
					return _openClose;
				}
			}

			public ExtendedIntegerI val {
				get {
					return _val;
				}
			}
			private ExtendedIntegerI _val;

			public Bound(ExtendedIntegerI val,OpenClose openClose)
			{
				var v = Check(val, openClose);
				if (v!=null)
				{
					throw new Exception(v);
					
				}
				this._val = val;
				this._openClose = openClose;
				

			}

			static string Check(ExtendedIntegerI val,OpenClose openClose) {

				if (val is InfiniteI && openClose==OpenClose.Close)
				{
					return "The bound can not be close at Infinite.";

					
				}
				return null;
			
			}

			public enum OpenClose
			{
				Open,
				Close
				
			}


					
		}
	}
}
