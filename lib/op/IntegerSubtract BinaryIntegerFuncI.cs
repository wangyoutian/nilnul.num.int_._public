using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.integer;

namespace nilnul.number.integer
{
	public partial class IntegerSubtract
		:BinaryIntegerFuncI
	{





		#region BinaryIntegerFuncI Members

		public BinaryIntegerFuncExprI call(IntegerExprI left, IntegerExprI right)
		{
			return new BinaryIntegerFuncExpr(Instance,left,right);
		}

		public virtual Integer simplify(Integer a,Integer b)
		{
			return new Integer( a.bigInt - b.bigInt);

		}

		public IntegerI simplify(IntegerI left,IntegerI right)
		{
			if (left is Integer && right is Integer)
			{
				return simplify((Integer)left, (Integer)right);
			}
			else
			{
				throw new Exception();
			}

		
		}

		public IntegerExprI eval(IntegerExprI left, IntegerExprI right)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
