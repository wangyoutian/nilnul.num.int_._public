using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;

namespace nilnul.realNumber
{
	public partial class IntClosedIntervalFiniteUnion 
		
		:MultiOpExprA<SetI,IntClosedInterval>

		, FiniteSetI<int>
		
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
			return  operands.SelectMany(c=>c.Select(e=>e)).GetEnumerator();
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

	static public partial class X {

		static public IEnumerable<IntClosedInterval> ToIntervals(this IEnumerable<int> a)
		{

			List<IntClosedInterval> intervals = new List<IntClosedInterval>();

		
			IntClosedInterval currentInterval=null;

			//bool findingRight=false;

			foreach (var item in a.OrderBy(c=>c))
			{
				
					if (currentInterval==null){
						currentInterval=new IntClosedInterval(item,item);
						continue;

					}

					if( item==currentInterval.right+1)
					{
						currentInterval.right+=1;
						 
					}
					else
					{

						intervals.Add(currentInterval);

						currentInterval=new IntClosedInterval(item,item);
					}
					
				//}else{
				//    currentInterval=new IntClosedInterval(item,item);
				//    findingRight=true;
				//}

			}
			intervals.Add(currentInterval);

			return intervals;
		}

		static public IntClosedIntervalFiniteUnion ToIntervalUnion(this IEnumerable<int> a)
		{

			

			return new IntClosedIntervalFiniteUnion(a.ToIntervals());
		}
		

		


	}
}
