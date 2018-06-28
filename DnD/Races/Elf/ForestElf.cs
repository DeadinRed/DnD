using System;

namespace DnD
{
	public class ForestElf : Elf
	{
		public ForestElf (string name,int year, string sex, int growth, int weight,AbstractClass abstractClass) : base(name,year,sex,growth,weight,abstractClass){
			


			addCharacteristic (getArrOfRandomPoints());
			addElfBonus ();
			addForestElfBonus ();
			Mod_wisdom = addModCharacteristic (Dexterity);
			Mod_dexterity = addModCharacteristic (Dexterity);
			Mod_constitution = addModCharacteristic (Constitution);
			Mod_intelligence = addModCharacteristic (Intelligence);
			Mod_wisdom = addModCharacteristic (Wisdom);
			Mod_charisma = addModCharacteristic (Charisma);
			recoveryHealth ();

		}

		public void addForestElfBonus(){

			Wisdom++;
			Speed = Speed + 5;
			//maskirovka
			Console.WriteLine ("ForestElfBonus complete");
		}
	}
}

