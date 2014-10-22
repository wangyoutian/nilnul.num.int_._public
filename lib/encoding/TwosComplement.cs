using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.int_.encoding
{
	public partial class TwosComplement
	{
		static public string Encode(BigInteger x, nilnul.num.natural.PositiveNatural_inheritNatural2 bitsLength)
		{

			if (x >= 0)
			{
				return "0"+nilnul.num.natural.encoding.FixedLen.Encode(new natural.Natural_bigInteger(x), bitsLength-1);

			}

			if (x<  -nilnul.num.natural.op.PowX2.Eval(2,bitsLength.val-1))
			{
				return "overflown";
			}

			return nilnul.num.natural.encoding.FixedLen.Encode(
				new natural.Natural_bigInteger(x + nilnul.num.natural.op.PowX2.Do_nonNeg_nonNeg(2, bitsLength))
				,
				bitsLength
			);


			throw new NotImplementedException();


		}


		static public string Encode1(BigInteger x, nilnul.num.natural.PositiveNatural_inheritNatural2 bitsLength)
		{

			if (x >= 0)
			{
				try
				{
				return "0" + nilnul.num.natural.encoding.FixedLen.Encode1(new natural.Natural_bigInteger(x), bitsLength - 1);

				}
				catch (nilnul.num.natural.encoding.FixedLen.OverflowException e)
				{

					return "overflown";
				}

			}

			if (x < -nilnul.num.natural.op.PowX2.Eval(2, bitsLength.val - 1))
			{
				return "overflown";
			}

			return nilnul.num.natural.encoding.FixedLen.Encode1(
				new natural.Natural_bigInteger(x + nilnul.num.natural.op.PowX2.Do_nonNeg_nonNeg(2, bitsLength))
				,
				bitsLength
			);


			throw new NotImplementedException();


		}

		static public string Encode(int x, nilnul.num.natural.PositiveNatural_inheritNatural2 bitsLength)
		{

			return Encode1((BigInteger)x, bitsLength);


		}

		static public string Encode2(BigInteger x, nilnul.num.natural.PositiveNatural_inheritNatural2 bitsLength)
		{

			if (x >= 0)
			{
				
					return "0" + nilnul.num.natural.encoding.FixedLen.Encode1(new natural.Natural_bigInteger(x), bitsLength - 1);

				

			}

			

			var r= nilnul.num.natural.encoding.FixedLen.Encode1(
				new natural.Natural_bigInteger(x + nilnul.num.natural.op.PowX2.Do_nonNeg_nonNeg(2, bitsLength))
				,
				bitsLength
			);

			if (r.StartsWith("0"))
			{
				throw new OverflowException();
			}

			return r;


			throw new NotImplementedException();


		}

		static public string Encode(int x, int bitsLen) {
			return Encode2(x, new natural.PositiveNatural_inheritNatural2(bitsLen));
		}




		//static public string Encode_complement(BigInteger x, nilnul.num.natural.PositiveNatural_inheritNatural2 bitsLength)
		//{

		//	if (x >= 0)
		//	{

		//		return "0" + nilnul.num.natural.encoding.FixedLen.Encode1(new natural.Natural_bigInteger(x), bitsLength - 1);



		//	}



		//	var r = nilnul.num.natural.encoding.FixedLen.Encode1(
		//		new natural.Natural_bigInteger(-x)
		//		,
		//		bitsLength
		//	);

		//	//complement

		//	r=r.Replace('0', '_').Replace('1', '0').Replace('_', '1');

		//	if (r.StartsWith("0"))
		//	{
		//		throw new OverflowException();
		//	}


		//	throw new NotImplementedException();


		//}

		[Serializable]
		public class OverflowException : Exception
		{
			public OverflowException() { }
			public OverflowException(string message) : base(message) { }
			public OverflowException(string message, Exception inner) : base(message, inner) { }
			protected OverflowException(
			  System.Runtime.Serialization.SerializationInfo info,
			  System.Runtime.Serialization.StreamingContext context)
				: base(info, context) { }
		}


		



	}
}
