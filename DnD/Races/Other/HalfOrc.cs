using System;

namespace DnD
{
	public class HalfOrc : AbstractRaces
	{

		private int year;
		private int growth;
		private int weight;
		private int basicSpeed = 30;

		public HalfOrc (string name,int year, string sex, int growth, int weight, AbstractClass abstractClass) : base(name,sex,abstractClass){
			

				if (year > 0 && year < 80) {
					this.year = year;
				} else {
					Console.WriteLine( new Exception ("Year not true"));
				}
				if (weight > 0 && weight < 115) {
					this.weight = weight;
				} else {
					Console.WriteLine( new Exception ("Weight not true"));
				}
				if (growth > 0 && growth < 215) {
					this.growth = growth;
				} else {
					Console.WriteLine( new Exception ("Growth not true"));
				}

				addCharacteristic (getArrOfRandomPoints());
				addHalfOrcBonus ();
				Mod_wisdom = addModCharacteristic (Dexterity);
				Mod_dexterity = addModCharacteristic (Dexterity);
				Mod_constitution = addModCharacteristic (Constitution);
				Mod_intelligence = addModCharacteristic (Intelligence);
				Mod_wisdom = addModCharacteristic (Wisdom);
				Mod_charisma = addModCharacteristic (Charisma);
				
				recoveryHealth ();

			}

			public void addHalfOrcBonus(){

			//запугивание
			//если здоровье 0 то здоровье +1
			// свирепые атаки
			Console.WriteLine ("HalfOrcBonus complete");
			}


			public override int Year {
				get {
					return this.year;
				}
				set {
					if (value > 0 && value < 80) {
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
					if (value > 0 && value < 215) {
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
					if (value > 0 && value < 115) {
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

