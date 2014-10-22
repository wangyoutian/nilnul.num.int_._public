using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace nilnul.num.integer
{
	static public class IntCollectionSampleX
	{
		/// <summary>
		/// this will sample a ceratin number of ints from all the ints. an element can be sampled more than once.
		/// </summary>
		/// <returns></returns>
		static public List<int> Sample(int count) {
			List<int> a = new List<int>(count);
			Random rnd = new Random();

			for (int i = 0; i < count; i++)
			{
				a.Add(rnd.Next());
			}
			return a;
 

		
		}

		/// <summary>
		/// the whole is a multiset. the index of each element can be sampled more than once.
		/// </summary>
		/// <param name="whole"></param>
		/// <param name="count"></param>
		/// <returns></returns>

		static public List<int> Sample(IEnumerable<int> whole,int count)
		{
			List<int> a = new List<int>(count);
			Random rnd = new Random();

			for (int i = 0; i < count; i++)
			{
				a.Add(whole.ElementAt(rnd.Next(count)));
			}
			return a;



		}
		
	}
}