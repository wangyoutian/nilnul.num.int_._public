using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;

namespace nilnul.num.i.op
{
    public class Gcd
    {
       
  

        static public BigInteger Eval(BigInteger a,BigInteger b) {

			return BigInteger.GreatestCommonDivisor(a, b); 

			
			/*If either parameter is zero, the method returns the absolute value of the non-zero parameter. If both values are zero, the method returns zero. 
			The value returned by the GreatestCommonDivisor method is always positive regardless of the sign of the left and right parameters.
			 * 
			 * http://msdn.microsoft.com/query/dev10.query?appId=Dev10IDEF1&l=EN-US&k=k(System.Numerics.BigInteger.GreatestCommonDivisor);k(SolutionItemsProject);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5);k(DevLang-csharp)&rd=true 
			*/

        
        }

		static public num.natural.__bigint.be.Positive.Asserted Eval(
			BigInteger x
			,
			num.natural.__bigint.be.Positive.Asserted y
		) {
			return new natural.__bigint.be.Positive.Asserted(Eval(x,y.val));
		
		}
		static public num.natural.__bigint.be.Natural.Asserted Eval(
			num.natural.__bigint.be.Positive.Asserted y
			,

			BigInteger x
		) {
			return Eval_retN(x, y.val);
		
		}

		static public num.natural.__bigint.be.Natural.Asserted Eval_retN(
			BigInteger x
			,
			BigInteger y

			
		) {

			return  new natural.__bigint.be.Natural.Asserted( Eval(x, y));
		
		}



	
    }
}
