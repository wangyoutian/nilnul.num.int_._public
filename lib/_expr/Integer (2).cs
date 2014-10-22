using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.num.integer
{
	public partial struct Integer : IntegerI
	

	{
		private BigInteger _bigInt;
		public BigInteger bigInt
		{
			get{
				return _bigInt;
			}
			


		}

		public BigInteger toBigint() {

			return _bigInt;
		
		}


		public Integer(BigInteger a)
		{
			_bigInt = a;
		}
					

		public Integer(params byte[] a)
			
			
		{
			_bigInt = new BigInteger(a);
			//bigInt = new BigInteger(a);
		}


		public Integer(int a)
		{
			_bigInt = new BigInteger(a);
		}
					

		static public implicit operator BigInteger(Integer a){
			return a.bigInt;
		}
		static public implicit operator Integer(BigInteger a){
			return new Integer(a);
		}

		public override string ToString()
		{
			return this.bigInt.ToString();
		}
					

	}

	

   
}
