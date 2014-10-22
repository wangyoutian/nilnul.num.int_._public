using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.real;
using nilnul.number.rational;

namespace nilnul.number.integer
{
    /// <summary>
    /// primitive value or variable
    /// positive, 0, or negative integer numbers.
    /// </summary>
    public class Integer:Rational,
		IInteger
    {
        
        private bool? _posNegInf;    //postive infite or negative infinite
        private int? _value;
        public Integer() {
            this._value = null;
            this._posNegInf = null;

        }
        public Integer(int value) {
            this._value = value;
        }
        public Integer(bool isPositiveInf) {
            if (isPositiveInf)
            {
                isPositiveInf = true;

            }
            else {
                isPositiveInf = false;
            }
        }
        public bool? isPositiveInfinite {
            get {
                return _posNegInf;
            }
            set {
                _posNegInf = value;
            }
        }

		static public implicit operator int(Integer a)
		{
			if (a.value is int || a.value is uint || a.value is ulong || a.value is uint)
			{
				return (int)((uint)(a.value));
			}
			else if (a.value is Integer)
			{
				return (int)((Integer)(a.value));


			}
			else
			{
				throw new Exception("Not convertible.");
			}

		}
        public static Integer PositiveInfinite;
        static Integer(){
            PositiveInfinite = new Integer();
        }
        public enum Infinte { 
            PositiveInfinite,
            Finite,
            NegativeInfinite,
            NotKnown
            
        }
        
    }//class
    
}
