using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.integer
{
	public partial class IntegerAdd
	{

		static private readonly IntegerAdd _Instance=new IntegerAdd();
		static public IntegerAdd Instance{
			get{
				return _Instance;
			}
		}
		public IntegerAdd(){
		}

	
	}
}
