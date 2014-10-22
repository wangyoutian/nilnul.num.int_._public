using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.int_.op
{
	public partial class ToStrX
	{
		static public string Do(BigInteger i, natural.Radix radix) {

			return i >= 0 ? natural.op.ToStrX.Do(i, radix) : "-"+natural.op.ToStrX.Do(-i, radix);
		
		}

		static public string Do(BigInteger i, int radix_2to17)
		{

			return Do(i, natural.Radix.Create(radix_2to17));

		}

		static public string Do_binary(BigInteger i)
		{

			return Do(i, 2);

		}
		static public string Do_oct(BigInteger i)
		{

			return Do(i, 8);

		}
		static public string Do_dec(BigInteger i)
		{

			return Do(i, 10);

		}
		static public string Do_hex(BigInteger i)
		{

			return Do(i, 16);

		}


	}
}
