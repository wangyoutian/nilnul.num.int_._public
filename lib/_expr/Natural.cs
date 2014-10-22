using System;

namespace nilnul.num.integer
{
	public partial class Natural:natural.Natural, IntegerI
	{
		natural.Natural _val;

		public Natural(natural.Natural val)
			:base(val.val)
		{
			
		}
					

	}
}
