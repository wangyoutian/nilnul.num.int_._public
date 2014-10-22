using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.int_.op
{
	static public partial class PowX
	{


		static public BigInteger Eval(this BigInteger base_, BigInteger index_nonNeg)
		{
			if (base_ >= 0)
			{
				
					return nilnul.num.natural.op.PowX2.Eval(base_, index_nonNeg);

			
				

			}
			if (index_nonNeg.IsEven)
			{
				return nilnul.num.natural.op.PowX2.Eval(-base_, index_nonNeg);
				
			}
			return -nilnul.num.natural.op.PowX2.Eval(-base_, index_nonNeg);


		}

		[Obsolete("see Eval_plural_positive")]
		static public BigInteger Eval_indexPositive_basePlural(BigInteger base_plural, BigInteger indexPositive)
		{
			//

			if (indexPositive == 1)
			{
				return base_plural;

			}
			BigInteger remainder;
			var half = BigInteger.DivRem(indexPositive, 2, out remainder);

			var halfPow = Eval_indexPositive_basePlural(base_plural, half);
			//var halfPowSquared = halfPow * halfPow;

			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * base_plural;



		}

		static public BigInteger Eval_basePlural_indexNoNeg(BigInteger base_plural, BigInteger index_nonNeg)
		{
			return nilnul.num.natural.op.PowX2.Do_basePlural_indexNonNeg(base_plural, index_nonNeg); 

		}



		static public BigInteger Eval_basePlural_indexPositive(BigInteger base_plural, BigInteger index_positive)
		{
			//

			if (index_positive == 1)
			{
				return base_plural;

			}
			BigInteger remainder;
			var half = BigInteger.DivRem(index_positive, 2, out remainder);

			var halfPow = Eval_basePlural_indexPositive(base_plural, half);
			//var halfPowSquared = halfPow * halfPow;

			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * base_plural;

		}

		static private BigInteger Eval_indexNonNeg(BigInteger _base, BigInteger index_nonNeg)
		{
			if (index_nonNeg == 0)
			{
				if (_base == 0)
				{
					throw new ZeroPowZeroException();

				}
				else
				{
					return 1;
				}

			}

			if (index_nonNeg == 1)
			{
				return _base;

			}

			BigInteger remainder;
			var half = BigInteger.DivRem(index_nonNeg, 2, out remainder);

			var halfPow =Eval_basePlural_indexPositive(_base, half);
			//var halfPowSquared = halfPow * halfPow;

			return remainder == 0 ? halfPow * halfPow : halfPow * halfPow * _base;



		}



	}

	
}
