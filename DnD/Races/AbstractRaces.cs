using System;
using System.Collections.Generic;

namespace DnD
{
	public abstract class AbstractRaces : GameModel
	{

		private string name;
		private string sex;
		 
		private AbstractClass abstractClass;

		private int proficiency_bonus = 2;//бонус мастерства
		private int inspiration = 0;//вдохновение

		private bool savingThrowStrength = false;
		private bool savingThrowConstitution = false;
		private bool savingThrowDexterity = false;
		private bool savingThrowIntelligence = false;
		private bool savingThrowWisdom = false;
		private bool savingThrowCharisma = false;

        private bool[] canUseItem;



		public AbstractRaces (string name, string sex, AbstractClass abstractClass) 
		{
			this.name = name;
			this.abstractClass = abstractClass;
			if (sex == "Man" || sex == "Woman" || sex == "Other") {
				this.sex = sex;
			} else {
				Console.WriteLine (new Exception ("String is false"));
			}
			foreach(string str in abstractClass.List)
				this.addSavingThrow (str);
							
		}

		public string Name {
			get {   
				return this.name;
			}
			set {
				name = value;
			}
		}

		public abstract int Year {
			get;
			set;
		}
		public abstract int Growth {
			get;
			set;
		}
		public abstract int Weight {
			get;
			set;
		}
		public abstract int Speed {
			get;
			set;
		}
		public string Sex {
			get {
				return this.sex;
			}
		}

		public int Proficiency_bonus {
			get {
				return this.proficiency_bonus;
			}
			set {
				proficiency_bonus = value;
			}
		}

		public int Inspiration {
			get {
				return this.inspiration;
			}
			set {
				inspiration = value;
			}
		}

		public AbstractClass AbstractClass {
			get {
				return this.abstractClass;
			}
		}

		public bool SavingThrowStrength {
			get {
				return this.savingThrowStrength;
			}
			set {
				savingThrowStrength = value;
			}
		}

		public bool SavingThrowConstitution {
			get {
				return this.savingThrowConstitution;
			}
			set {
				savingThrowConstitution = value;
			}
		}

		public bool SavingThrowDexterity {
			get {
				return this.savingThrowDexterity;
			}
			set {
				savingThrowDexterity = value;
			}
		}

		public bool SavingThrowIntelligence {
			get {
				return this.savingThrowIntelligence;
			}
			set {
				savingThrowIntelligence = value;
			}
		}

		public bool SavingThrowWisdom {
			get {
				return this.savingThrowWisdom;
			}
			set {
				savingThrowWisdom = value;
			}
		}

		public bool SavingThrowCharisma {
			get {
				return this.savingThrowCharisma;
			}
			set {
				savingThrowCharisma = value;
			}
		}

		public void upProficiencyBonus(){
			proficiency_bonus++;
		}

		public void downProficiencyBonus(){
			if(proficiency_bonus > 2)
				proficiency_bonus--;
		}

		public void addSavingThrow(string arg){
			switch (arg)
			{
				case "strength":
					savingThrowStrength = true;
					break;
				case "constitution":
					savingThrowConstitution = true;
					break;
				case "dexterity":
					savingThrowDexterity = true;
					break;
				case "intelligence":
					savingThrowIntelligence = true;
					break;
				case "wisdom":
					savingThrowWisdom = true;
					break;
				case "charisma":
					savingThrowCharisma = true;
					break;
				default:
					Console.WriteLine (new Exception("Data is not true"));
					break;
			}
		}

        public bool[] CanUseItem {
			get {
				return this.canUseItem;
			}
			set {
				canUseItem = value;
			}
		}

        public void showSavingThrows(){
            Console.WriteLine(SavingThrowCharisma + " " + SavingThrowConstitution + " " + SavingThrowDexterity +  " " +
                SavingThrowIntelligence + " " + SavingThrowStrength + " " + SavingThrowWisdom);
        }

	}
}

