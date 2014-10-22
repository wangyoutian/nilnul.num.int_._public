using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.order;

namespace nilnul.num.integer
{
	public class Order_BigInteger
		:nilnul.order.TotalOrderA<BigInteger>
	{

		static private readonly Order_BigInteger _Instance = new Order_BigInteger();
		static public Order_BigInteger Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Order_BigInteger()
		{
		}
				

		public override order.Sign compare(BigInteger x, BigInteger y)
		{
			return x.CompareTo(y).ToSign();
			
		}
	}
}
