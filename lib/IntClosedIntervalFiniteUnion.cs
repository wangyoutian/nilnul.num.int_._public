using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;

namespace nilnul
{
	public partial class IntClosedIntervalFiniteUnion 
		
		:MultiOpExprA<SetI,IntClosedInterval>

		, nilnul.collection.set.FiniteSetI<int>
		
	{

		public IntClosedIntervalFiniteUnion(IEnumerable<IntClosedInterval> intervals)
			:base(intervals)
		{

		}
		public IntClosedIntervalFiniteUnion(params IntClosedInterval[] intervals)
			: this((IEnumerable<IntClosedInterval>)intervals)
		{

		}




		#region SetI<int> Members

		public bool? hasElement(int element)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IEnumerable<int> Members

		public IEnumerator<int> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		public override MultiOpI<SetI> op
		{
			get
			{
				return Union.Instance;
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
