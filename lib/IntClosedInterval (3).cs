using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using nilnul.collection.interval;

namespace nilnul.realNumber
{
	public partial class IntClosedInterval
	{
		public int left
		{
			get;
			set;
		}
		public int right
		{
			get;
			set;
		}


		
					


		public IntClosedInterval(int left,int right,bool leftOpenClose, bool rightOpenClose) {

			if (leftOpenClose)
			{

				this.left = left+1;
			}
			else
			{
				this.left = left;
			}

			if (rightOpenClose)
			{
				this.right = right-1;
			}
			else
			{
				this.right = right;
			}
		

	
		}

		public IntClosedInterval(int left,int right) 
			:this(left,right,false,false)
		{

				

		
		}
		public int min {
			get {
				
				if (left>right)
				{
					throw new Exception();
				}
				return left ;
				
			}
		}

		public int max {
			get
			{
				if (left>right)
				{
					throw new Exception();
				}
				return right;
				
			}
		}

		public override string ToString()
		{
			return "["+this.left+","+this.right+"]";
		}

	

	}

	
	
}
