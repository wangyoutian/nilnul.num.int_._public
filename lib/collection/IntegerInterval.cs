using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.math.complex.real.rational.integer.set
{
	public class IntegerInterval:Set
	{
		public Integer left
		{
			get;
			set;
		}
		public Integer right
		{
			get;
			set;
		}
		public Type type
		{
			get;
			set;
		}

		public IntegerInterval(Integer left,Integer right,Type type) {
			this.left = left;
			this.right = right;
			this.type = type;
		}

		public Integer min {
			get {
				if (type == Type.closed || type == Type.leftClosedRightOpen)
				{
					return left;
				}
				else {
					return left + 1;
				}
			}
		}

		public Integer max {
			get
			{
				if (type == Type.closed || type == Type.leftOpenRightClosed)
				{
					return right;
				}
				else
				{
					return right-1;
				}
			}
		}

		static public enum Type { 
			closed,
			open,
			leftClosedRightOpen,
			leftOpenRightClosed,
		}

	}
	public class IntegerInterval : IEnumerable<Integer> {

		public Enumerator IEnumerable<Integer>.GetEnumerator() {
			return new Enumerator(this);
		}

		public Enumerator IEnumerable.GetEnumerator() {
			return ((IEnumerable<Integer>)this).GetEnumerator();
		}

		public class Enumerator:IEnumerator<Integer> {
			private IntegerInterval _intInterval;
			private Integer _position;
			
			public Enumerator(IntegerInterval intInterval){
				this._intInterval = intInterval;

			}

			public void Reset() {

				_position = _intInterval.min - 1;
				

			}

			public bool MoveNext() {
				_position++;
				if(_position>_intInterval.max){
					return false;
				}
				return true;
			}


			public Integer IEnumerator<Integer>.Current {
				get { return _position; }

			}
			public object IEnumerator.Current {
				get {
					return ((IEnumerator<Integer>)this).Current;
				}
			}
			public void Dispose() { 
			}
		}
	}
}
