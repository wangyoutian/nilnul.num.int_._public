using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using nilnul.collection.interval;

namespace nilnul.realNumber
{
	
	public partial class IntClosedInterval 
		: IEnumerable<int> {

		#region IEnumerable<int> Members

		public IEnumerator<int> GetEnumerator()
		{
			

			for (int i = left; i <= right; i++)
			{
				yield return i;
			}
		}

		#endregion

		#region IEnumerable Members

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		#endregion
		}
}
