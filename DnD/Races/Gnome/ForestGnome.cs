using System;

namespace DnD
{
	public class ForestGnome : Gnome
	{
		

		public ForestGnome(string name,int year, string sex, int growth, int weight,AbstractClass abstractClass) : base(name,year,sex,growth,weight,abstractClass){
			

			addCharacteristic (getArrOfRandomPoints());
			addGnomeBonus ();
			addForestGnomeBonus ();
			Mod_wisdom = addModCharacteristic (Dexterity);
			Mod_dexterity = addModCharacteristic (Dexterity);
			Mod_constitution = addModCharacteristic (Constitution);
			Mod_intelligence = addModCharacteristic (Intelligence);
			Mod_wisdom = addModCharacteristic (Wisdom);
			Mod_charisma = addModCharacteristic (Charisma);
			recoveryHealth ();

		}

		public void addForestGnomeBonus(){

			Dexterity++;
			//знаете малая илюзия, общение с малыми звверями
			Console.WriteLine ("ForestGnomeBonus complete");
		}
	}
}

