using System;

namespace DnD
{
	public class MountGnome : Gnome
	{

		public MountGnome(string name,int year, string sex, int growth, int weight,AbstractClass abstractClass) : base(name,year,sex,growth,weight,abstractClass){
			
			addCharacteristic (getArrOfRandomPoints());
			addGnomeBonus ();
			addMountGnomeBonus ();
			Mod_wisdom = addModCharacteristic (Dexterity);
			Mod_dexterity = addModCharacteristic (Dexterity);
			Mod_constitution = addModCharacteristic (Constitution);
			Mod_intelligence = addModCharacteristic (Intelligence);
			Mod_wisdom = addModCharacteristic (Wisdom);
			Mod_charisma = addModCharacteristic (Charisma);
			recoveryHealth ();

		}

		public void addMountGnomeBonus(){

			Constitution++;
			// еще плюшки
			Console.WriteLine ("MountGnomeBonus complete");
		}
	}
}

