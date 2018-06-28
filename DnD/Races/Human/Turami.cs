using System;

namespace DnD
{
	public class Turami : Human
	{

		public Turami (string name,int year, string sex, int growth, int weight,AbstractClass abstractClass) : base(name,year,sex,growth,weight,abstractClass){
			
			addCharacteristic (getArrOfRandomPoints());
			addHumanBonus (true);
			Mod_wisdom = addModCharacteristic (Dexterity);
			Mod_dexterity = addModCharacteristic (Dexterity);
			Mod_constitution = addModCharacteristic (Constitution);
			Mod_intelligence = addModCharacteristic (Intelligence);
			Mod_wisdom = addModCharacteristic (Wisdom);
			Mod_charisma = addModCharacteristic (Charisma);
			
			recoveryHealth ();

		}
	}
}

