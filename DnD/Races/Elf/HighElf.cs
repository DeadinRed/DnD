using System;

namespace DnD
{
	public class HighElf : Elf
	{
		public HighElf (string name,int year, string sex, int growth, int weight,AbstractClass abstractClass) : base(name,year,sex,growth,weight,abstractClass){
			
			addCharacteristic (getArrOfRandomPoints());
			addElfBonus ();
			addHighElfBonus ();
			Mod_wisdom = addModCharacteristic (Dexterity);
			Mod_dexterity = addModCharacteristic (Dexterity);
			Mod_constitution = addModCharacteristic (Constitution);
			Mod_intelligence = addModCharacteristic (Intelligence);
			Mod_wisdom = addModCharacteristic (Wisdom);
			Mod_charisma = addModCharacteristic (Charisma);
			recoveryHealth ();

		}

		public void addHighElfBonus(){

			Intelligence++;
			//Внимательность
			//Спас бросок + очарованию, невозможно усыпить магиией 
			// 1 заговор из заклинаний волшебника + доп язык
			Console.WriteLine ("HighElfBonus complete");
		}
	}
}

