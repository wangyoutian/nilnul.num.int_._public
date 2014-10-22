using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace nilnul.num.int_
{
	/// <summary>
	/// Convert a binary representation to a decimal representation
	/// </summary>
	/// <remarks>
	/// You want to see the binary representation of an int using the C# language. Integers have 32 bits and you want to see which ones are turned on, and which ones aren't. You want to see the sign bit. The method I show here is special in a couple ways: it has some improvements over the method in one book I own, and has a simpler calling pattern.
	/// 
	/// </remarks>
	static public class IntToBinaryX
	{

		static public string ToBinaryRepresentation(this int number) {
			int size=sizeof(int)*8;
			
			char[] str=new char[size];
			
			//place the most insignificant digit to the farthest of the array.
			int pos = size-1;
			for (int i = 0; i < size; i++)
			{
				
				str[pos] = ((number & (1 << i)) == 0 ? '0' : '1');
				pos--;
			 
			}
			return new string(str).TrimStart('0');

			
		}


	}
}
