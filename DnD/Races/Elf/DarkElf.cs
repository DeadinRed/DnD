using System;

namespace DnD
{
	public class DarkElf : Elf
	{
		
		public DarkElf (string name,int year, string sex, int growth, int weight,AbstractClass abstractClass) : base(name,year,sex,growth,weight,abstractClass){
			

			addCharacteristic (getArrOfRandomPoints());
			addElfBonus ();
			addDarkElfBonus ();
			Mod_wisdom = addModCharacteristic (Dexterity);
			Mod_dexterity = addModCharacteristic (Dexterity);
			Mod_constitution = addModCharacteristic (Constitution);
			Mod_intelligence = addModCharacteristic (Intelligence);
			Mod_wisdom = addModCharacteristic (Wisdom);
			Mod_charisma = addModCharacteristic (Charisma);
			recoveryHealth ();

		}

		public void addDarkElfBonus(){
			/*
Магия дроу. Вы знаете заклинание пляшущие
огоньки. Когда вы достигаете 3 уровня, вы мо-
жете один раз в день использовать заклинание
огонь фей. При достижении 5 уровня вы также
сможете раз в день использовать заклинание тьма.
«Раз в день» означает, что вы должны окончить
продолжительный отдых, прежде чем сможете
наложить это заклинание ещё раз посредством
данного умения. Базовой характеристикой для их
использования является Харизма.

Чувствительность к солнцу. Вы совершаете с
помехой броски атаки и проверки Мудрости (Вни-
мательность), основанные на зрении, если вы, цель
вашей атаки или изучаемый предмет располо-
жены на прямом солнечном свете.
			 */
			Charisma++;
			//Зрение в темноте 120 футов 
			Console.WriteLine ("DarkElfBonus complete");
		}
	}
}

