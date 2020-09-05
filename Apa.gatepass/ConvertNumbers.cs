using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aorc.gatepass
{
	public static class ConvertNumbers
	{
		private static char[] baseChars = new char[]
		                           	{
		                           		'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
		                           		'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
		                           		'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
		                           	};



		public static string Int64ToBase36( Int64 value )
		{
			string result = string.Empty;
			int targetBase = baseChars.Length;
			do
			{
				result = baseChars[value%targetBase] + result;
				value = value/targetBase;
			} while (value > 0);

			return result;
		}



		private static int findIndex( char c )
		{
			for (int i = 0; i < baseChars.Length; i++)
			{
				if (baseChars[i] == c)
				{
					return i;
				}
			}
			return -1;
		}



		public static Int64 Base36ToInt64( string base34Value )
		{
			//string result = string.Empty;
			int targetBase = baseChars.Length;
			Int64 result = 0;
			for (int i = 0; i < base34Value.Length; i++)
			{
				int index = findIndex(base34Value[i]);
				if (index == -1)
				{
					throw new Exception("مقدار ورودی حاوی مشخصه نامعتبری می باشد");
				}
				var t1 = base34Value.Length - i - 1;
				var t3 = (Int64) Math.Pow(targetBase, t1);
				var t2 = t3*index;
				result = t2 + result;
			}
			return result;
		}



		public static string IntToStringFast( int value , char [] baseChars )
		{
			// 32 is the worst cast buffer size for base 2 and int.MaxValue
            
			int i = 32;
			char[] buffer = new char[i];
			int targetBase = baseChars.Length;

			do
			{
				buffer[--i] = baseChars[value%targetBase];
				value = value/targetBase;
			} while (value > 0);

			char[] result = new char[32 - i];
			Array.Copy(buffer, i, result, 0, 32 - i);

			return new string(result);
		}
	}
}
