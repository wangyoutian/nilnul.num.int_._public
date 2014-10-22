using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.natural;

namespace nilnul.num.integer
{
    public class Gcd
    {
       
  

        static public BigInteger Eval(BigInteger a,BigInteger b) {

			return BigInteger.GreatestCommonDivisor(a, b); //If either parameter is zero, the method returns the absolute value of the non-zero parameter. If both values are zero, the method returns zero. http://msdn.microsoft.com/query/dev10.query?appId=Dev10IDEF1&l=EN-US&k=k(System.Numerics.BigInteger.GreatestCommonDivisor);k(SolutionItemsProject);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5);k(DevLang-csharp)&rd=true 


        
        }

		static public BigInteger Eval(IntegerI a, PositiveNaturalI b) {

			return BigInteger.GreatestCommonDivisor(IntegerX.ToBigint(a), natural.NaturalX.ToBigint(b));

		
		}

		


       
    }
}
