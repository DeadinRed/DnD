using System;

namespace DnD
{
	public class HillDwarf : Dwarf
	{
		public HillDwarf(string name,int year, string sex, int growth, int weight,AbstractClass abstractClass) : base(name,year,sex,growth,weight,abstractClass){
			addCharacteristic (getArrOfRandomPoints());
			addDwarfBonus ();
			addBonusForHillDwarf ();
			Mod_wisdom = addModCharacteristic (Dexterity);
			Mod_dexterity = addModCharacteristic (Dexterity);
			Mod_constitution = addModCharacteristic (Constitution);
			Mod_intelligence = addModCharacteristic (Intelligence);
			Mod_wisdom = addModCharacteristic (Wisdom);
			Mod_charisma = addModCharacteristic (Charisma);
			recoveryHealth ();

		}

		public void addBonusForHillDwarf(){
			Wisdom = Wisdom + 1;
			Health = Health + 1;
			Console.WriteLine ("HillDwarfBonus complete");
		}

	}
}

