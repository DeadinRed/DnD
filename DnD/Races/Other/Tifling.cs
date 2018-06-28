using System;

namespace DnD
{
	public class Tifling : AbstractRaces
	{
		
		private int year;
		private int growth;
		private int weight;
		private int basicSpeed = 30;

		public Tifling (string name,int year, string sex, int growth, int weight, AbstractClass abstractClass) : base(name,sex,abstractClass){

			if (year > 0 && year < 90) {
				this.year = year;
			} else {
				Console.WriteLine( new Exception ("Year not true"));
			}
			if (weight > 0 && weight < 120) {
				this.weight = weight;
			} else {
				Console.WriteLine( new Exception ("Weight not true"));
			}
			if (growth > 0 && growth < 190) {
				this.growth = growth;
			} else {
				Console.WriteLine( new Exception ("Growth not true"));
			}

			addCharacteristic (getArrOfRandomPoints());
			addTiflingBonus ();
			Mod_wisdom = addModCharacteristic (Dexterity);
			Mod_dexterity = addModCharacteristic (Dexterity);
			Mod_constitution = addModCharacteristic (Constitution);
			Mod_intelligence = addModCharacteristic (Intelligence);
			Mod_wisdom = addModCharacteristic (Wisdom);
			Mod_charisma = addModCharacteristic (Charisma);
			
			recoveryHealth ();

		}

		public void addTiflingBonus(){

			Intelligence++;
			Charisma = Charisma +2;
			Console.WriteLine ("TiflingBonus complete");
		}


		public override int Year {
			get {
				return this.year;
			}
			set {
				if (value > 0 && value < 90) {
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
				if (value > 0 && value < 190) {
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
				if (value > 0 && value < 120) {
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

		public  string ToString2 () 
		{
			return string.Format (this.GetType() + " : [name={0}, year={1}, sex={2}, growth={3}, weight={4}, basicSpeed={5}]",  Name,year,Sex, growth, weight, basicSpeed);
		}
	}
}

