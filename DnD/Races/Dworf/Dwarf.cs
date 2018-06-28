using System;

namespace DnD
{
	public abstract class Dwarf : AbstractRaces
	{
		private int year;
		private int growth;
		private int weight;
		private int basicSpeed = 25;

		public Dwarf(string name,int year, string sex, int growth, int weight, AbstractClass abstractClass) : base(name,sex,abstractClass){

			if (year > 0 && year < 400) {
				this.year = year;
			} else {
				Console.WriteLine( new Exception ("Year not true"));
			}
			if (weight > 0 && weight < 70) {
				this.weight = weight;
			} else {
				Console.WriteLine( new Exception ("Weight not true"));
			}
			if (growth > 0 && growth < 160) {
				this.growth = growth;
			} else {
				Console.WriteLine( new Exception ("Growth not true"));
			}
							
		}

		public override int Year {
			get {
				return this.year;
			}
			set {
				if (value > 0 && value < 400) {
					year = value;
				} else {
					Console.WriteLine( new Exception ("Year not true"));
				}
			}
		}

		public override int Growth {
			get {
				return this.growth;
			}
			set {
				if (value > 0 && value < 160) {
					growth = value;
				} else {
					Console.WriteLine( new Exception ("Growth not true"));
				}
			}
		}

		public override int Weight {
			get {
				return this.weight;
			}
			set {
				if (value > 0 && value < 70) {
					weight = value;
				} else {
					Console.WriteLine( new Exception ("Weight not true"));
				}
			}
		}

		public override int Speed {
			get {
				return this.basicSpeed;
			}
			set {
				basicSpeed = value;
			}
		}

		public void addDwarfBonus(){
			Constitution = Constitution + 2;
			Console.WriteLine ("DwarfBonus complete");
		}


		public  string ToString2 () 
		{
			return string.Format (this.GetType() + " : [name={0}, year={1}, sex={2}, growth={3}, weight={4}, basicSpeed={5}]",  Name,year,Sex, growth, weight, basicSpeed);
		}
		
			
	}
}

