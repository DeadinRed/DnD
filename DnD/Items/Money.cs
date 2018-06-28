using System;
using DnD;

namespace DnD
{
	public class Money 
	{
		private int gold;
		private int silver;
		private int copper;
		private int platinum;


		public Money ()
		{
			this.gold = 0;
			this.silver = 0;
			this.copper = 0;
			this.platinum = 0;

		}
		

		public int Gold {
			get {
				return this.gold;
			}
			set {
				gold = value;
			}
		}

		public int Silver {
			get {
				return this.silver;
			}
			set {
				silver = value;
			}
		}

		public int Copper {
			get {
				return this.copper;
			}
			set {
				copper = value;
			}
		}

		public int Platinum {
			get {
				return this.platinum;
			}
			set {
				platinum = value;
			}
		}


        public override string ToString ()
		{
			return string.Format ("[Money: gold={0}, silver={1}, copper={2}, platinum={3}]", gold, silver, copper, platinum);
		}
		

	}

		
}

