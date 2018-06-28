using System;

namespace DnD
{
	public class MountDwarf : Dwarf
	{


		public MountDwarf (string name,int year, string sex, int growth, int weight,AbstractClass abstractClass) : base(name,year,sex,growth,weight,abstractClass){

			addCharacteristic (getArrOfRandomPoints());
			addDwarfBonus ();
			addBonusForMountDwarf ();
			Mod_wisdom = addModCharacteristic (Dexterity);
			Mod_dexterity = addModCharacteristic (Dexterity);
			Mod_constitution = addModCharacteristic (Constitution);
			Mod_intelligence = addModCharacteristic (Intelligence);
			Mod_wisdom = addModCharacteristic (Wisdom);
			Mod_charisma = addModCharacteristic (Charisma);
			recoveryHealth ();

		}

		public void addBonusForMountDwarf(){

			Strength = Strength + 2;
			// Вы владеете лёгкими и средними доспехами.

		}
	}
}

