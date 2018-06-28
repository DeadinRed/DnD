using System;

namespace DnD
{
	public class HalfElf : AbstractRaces
	{
		
		private int year;
		private int growth;
		private int weight;
		private int basicSpeed = 30;

		public HalfElf (string name,int year, string sex, int growth, int weight, AbstractClass abstractClass) : base(name,sex,abstractClass){
			if (year > 0 && year < 180) {
				this.year = year;
			} else {
				Console.WriteLine( new Exception ("Year not true"));
			}
			if (weight > 0 && weight < 65) {
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
			//addHalfElfBonus (Wisdom,Intelligence);// не работает
			Mod_wisdom = addModCharacteristic (Dexterity);
			Mod_dexterity = addModCharacteristic (Dexterity);
			Mod_constitution = addModCharacteristic (Constitution);
			Mod_intelligence = addModCharacteristic (Intelligence);
			Mod_wisdom = addModCharacteristic (Wisdom);
			Mod_charisma = addModCharacteristic (Charisma);
			recoveryHealth ();

		}
		public void addHalfElfBonus(string  tmp1,string tmp2){
			Charisma = Charisma + 2;
			upgradeCharacteristic (tmp1);
			upgradeCharacteristic (tmp2);


			// темное зрение, наследике фей, + 2 навыка
			Console.WriteLine ("HalfElfBonus complete");
		}


		public override int Year {
			get {
				return this.year;
			}
			set {
				if (value > 0 && value < 180) {
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
				if (value > 0 && value < 65) {
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

