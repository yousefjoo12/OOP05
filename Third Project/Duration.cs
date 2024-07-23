using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
	internal class Duration
	{
			public int Hours { get; set; }
			public int Minutes { get; set; }
			public int Seconds { get; set; }

		public Duration() : this(0, 0, 0)
		{
		}
		public Duration(int _H, int _M, int _S)
		{
			Hours = _H;
			Minutes = _M;
			Seconds = _S;
		}
        public Duration(int totalSeconds) 
        {
			Hours =  totalSeconds / 3600;
			Minutes = (totalSeconds %3600) / 60;
			Seconds = totalSeconds % 60;
		}
        public override string ToString()
			{
				return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
			}
		public override bool Equals(object? obj)
		{
			return base.Equals(obj);
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

	}
	}

