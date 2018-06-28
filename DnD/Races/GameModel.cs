using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Runtime.CompilerServices;
using System.Dynamic;

namespace DnD
{
	public abstract class GameModel
	{
		internal ItemClassDictionary<string,Dictionary<string, AItem>> itemClassDictionary 
        = new ItemClassDictionary<string,Dictionary<string, AItem>>();
		internal Money money = new Money();

       // private int freeLevelPoint;
        //private int initiative;
		private int health = 0;
		private int current_health;

		private int strength; //сила
		private int dexterity; //ловкость
		private int constitution; //телосложение
		private int intelligence; //интелект
		private int wisdom; //мудрость
		private int charisma; //харизма


		private int mod_strength; //сила
		private int mod_dexterity; //ловкость
		private int mod_constitution; //телосложение
		private int mod_intelligence; //интелект
		private int mod_wisdom; //мудрость
		private int mod_charisma; //харизма

		public GameModel(){
			itemClassDictionary.Add ("Armor", new Dictionary<string, AItem>(){});
			itemClassDictionary.Add ("Weapon", new Dictionary<string, AItem>(){});
			itemClassDictionary.Add ("Instrument", new Dictionary<string, AItem>(){});
			itemClassDictionary.Add ("Equipment", new Dictionary<string, AItem>(){});
			itemClassDictionary.Add ("FoodandDrink", new Dictionary<string, AItem>(){});
            itemClassDictionary.Add ("Item", new Dictionary<string, AItem> () { }); //add for type

		}

        public void  addToHeroItems (string key, dynamic obj){
		    itemClassDictionary [key].Add (obj.Name, obj);

		}

		public void  removeToHeroItems (string key, object obj){
			
		}

		public AItem getItem (string key,string key2){

			if (itemClassDictionary.ContainsKey(key) && itemClassDictionary[key].ContainsKey(key2))
				return this.itemClassDictionary [key] [key2];
			else {
				Console.WriteLine (new Exception ("Object is null"));
				return null;
			}
				
		}

        public int Health {
			get {
				return this.health;
			}
			set {
				health = value;
			}
		}

		public int Current_health {
			get {
				return this.current_health;
			}
			set {
				current_health = value;
			}
		}

		public int Strength {
			get {
				return this.strength;
			}
			set {
				strength = value;
			}
		}

		public int Dexterity {
			get {
				return this.dexterity;
			}
			set {
				dexterity = value;
			}
		}

		public int Constitution {
			get {
				return this.constitution;
			}
			set {
				constitution = value;
			}
		}

		public int Intelligence {
			get {
				return this.intelligence;
			}
			set {
				intelligence = value;
			}
		}

		public int Wisdom {
			get {
				return this.wisdom;
			}
			set {
				wisdom = value;
			}
		}

		public int Charisma {
			get {
				return this.charisma;
			}
			set {
				charisma = value;
			}
		}

		public int Mod_strength {
			get {
				return this.mod_strength;
			}
			set {
				mod_strength = value;
			}
		}

		public int Mod_dexterity {
			get {
				return this.mod_dexterity;
			}
			set {
				mod_dexterity = value;
			}
		}

		public int Mod_constitution {
			get {
				return this.mod_constitution;
			}
			set {
				mod_constitution = value;
			}
		}

		public int Mod_intelligence {
			get {
				return this.mod_intelligence;
			}
			set {
				mod_intelligence = value;
			}
		}

		public int Mod_wisdom {
			get {
				return this.mod_wisdom;
			}
			set {
				mod_wisdom = value;
			}
		}

		public int Mod_charisma {
			get {
				return this.mod_charisma;
			}
			set {
				mod_charisma = value;
			}
		}
			
		public void recoveryHealth(){
			current_health = health;
		}

		public int[] getArrOfRandomPoints(){
			int[] finalSum = new int[6];
			int[,] arrSum = new int[6,4];
			for (int i = 0; i < 6; i++) {
				for (int j = 0; j < 4; j++) {
					arrSum[i,j] = ThrowDice.ThrowOneDSix();
				}
				int minElement = arrSum[i, 0];
				int sumPoint = 0;
				for(int g = 0; g < 4;g++){
					sumPoint += arrSum [i, g];
					if (minElement > arrSum[i, g])
						minElement = arrSum[i, g];
				}
				finalSum [i] = sumPoint - minElement; 
			}
				
			return finalSum;
		}

		public int getRandomPoint(){
			int[] arrSum = new int[4];
			for (int j = 0; j < 4; j++) {
				arrSum[j] = ThrowDice.ThrowOneDSix();
			}
			int minElement = arrSum[0];
			int sumPoint = 0;
			for(int g = 0; g < 4;g++){
				sumPoint += arrSum [g];
				if (minElement > arrSum[g])
					minElement = arrSum[g];
			}
			return sumPoint - minElement;
		}
			
		public void addCharacteristic(int[] arr){
			
				strength = arr[0]; //сила
				dexterity= arr[1]; //ловкость
				constitution= arr[2]; //телосложение
				intelligence= arr[3]; //интелект
				wisdom= arr[4]; //мудрость
				charisma= arr[5]; //харизма

		}

		public int addModCharacteristic(int ch){
			int chmod;
			if (ch == 1) {
				chmod = -5;
			} else if(ch > 1 && ch < 4) {
				chmod = -4;
			} else if (ch > 3 && ch < 6) {
				chmod = -3;
			} else if (ch > 5 && ch < 8) {
				chmod = -2;
			} else if (ch > 7 && ch < 10) {
				chmod = -1;
			} else if (ch > 9 && ch < 12) {
				chmod = 0;
			} else if (ch > 11 && ch < 14) {
				chmod = 1;
			} else if (ch > 13 && ch < 16) {
				chmod = 2;
			} else if (ch > 15 && ch < 18) {
				chmod = 3;
			} else if (ch > 17 && ch < 20) {
				chmod = 4;
			} else if (ch > 19 && ch < 22) {
				chmod = 5;
			} else if (ch > 21 && ch < 24) {
				chmod = 6;
			} else if (ch > 23 && ch < 26) {
				chmod = 7;
			} else if (ch > 25 && ch < 28) {
				chmod = 8;
			} else if (ch > 27 && ch < 30) {
				chmod = 9;
			} else if (ch == 30) {
				chmod = 10;
			} else {
				chmod = 0;
				Console.Write( new Exception ("characterictic is not true"));
			} 
			return chmod;
		}

		public void upgradeCharacteristic(string arg){
			switch (arg)
			{
				case "strength":
					Strength++;
					break;
				case "constitution":
					Constitution++;
					break;
				case "dexterity":
					Dexterity++;
					break;
				case "intelligence":
					Intelligence++;
					break;
				case "wisdom":
					Wisdom++;
					break;
				case "charisma":
					Charisma++;
					break;
				default:
					Console.WriteLine (new Exception("Data is not true"));
					break;
			}
		}

		public override string ToString ()
		{
			
			return string.Format (this.GetType() +  " : [strength={0}, dexterity={1}, constitution={2}, intelligence={3}, wisdom={4}, charisma={5},\n" +
				"mod_strength={6}, mod_dexterity={7}, mod_constitution={8}, mod_intelligence={9}, mod_wisdom={10}, mod_charisma={11},\n" +
				"  health={12}, current_health={13}]",
				strength, dexterity, constitution, intelligence, wisdom, charisma, 
				Mod_strength, Mod_dexterity, mod_constitution, mod_intelligence, mod_wisdom, mod_charisma,
				 health, current_health);
		}

	}

	class ItemClassDictionary<T,V>  : Dictionary<string,Dictionary<string,AItem>>{

		public new void Remove(string key){
			Console.WriteLine( new Exception ("Bolt, a ne ydalenie"));
		}
		public new void Clear(){
            Console.WriteLine( new Exception ("Bolt, a ne ochishchenie"));
		}
			
	}


}
