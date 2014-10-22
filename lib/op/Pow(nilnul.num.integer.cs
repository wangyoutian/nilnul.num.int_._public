using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer
{
	static public partial  class PowX
	{
		

		static public BigInteger Pow(this BigInteger @base, BigInteger exp)
		{
			if (exp==0)
			{
				if (@base==0)
				{
					throw new ZeroPowZeroException();
					
				}
				else
				{
					return 1;
				}
				
			}
			else
			{
				//
				if (exp>0)
				{
						return _Pow(@base, exp);

				}
				else
				{
					if (@base==0)
					{
						throw new DivideByZeroException();
						
					}
					else if(@base==1)
					{
						return 1;

					}
					else
					{
						throw new PowFractionException();
					}
				}


			}


		}

		static private BigInteger _Pow(BigInteger _base,BigInteger _powPositive) {
			//
			
			if (_powPositive==1)
			{
				return _base;
				
			}
			BigInteger remainder;
			var half=BigInteger.DivRem(_powPositive, 2,out remainder);

			var halfPow=_Pow(_base, half);
			//var halfPowSquared = halfPow * halfPow;

			return remainder==0? halfPow * halfPow :halfPow*halfPow*_base;


			
		}

	}

	[Serializable]
	public class ZeroPowZeroException : Exception
	{
		public ZeroPowZeroException() { }
		public ZeroPowZeroException(string message) : base(message) { }
		public ZeroPowZeroException(string message, Exception inner) : base(message, inner) { }
		protected ZeroPowZeroException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}

	[Serializable]
	public class PowFractionException : Exception
	{
		public PowFractionException() { }
		public PowFractionException(string message) : base(message) { }
		public PowFractionException(string message, Exception inner) : base(message, inner) { }
		protected PowFractionException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}
}
