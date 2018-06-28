using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace DnD
{
	public class AbstractClass
	{

		public AbstractClass(){
		        
		}

		protected  string className;
		protected  string description;
		protected  string hit;
		protected  string primaryAbility;
       
        protected int healthDice = 4;
        

		private int level = 0 ;
	
		protected List<string> list = new List<string> ();
		protected string[] arrOfSavingThrows;

        private string[] useWeapon = { "Simple Ranged Weapons" };
        private string[] useArmor;
        private string[] useTools;

        public string ClassName {
			get {
				return this.className;
			}
		}

		public string Description {
			get {
				return this.description;
			}
		}

		public string Hit {
			get {
				return this.hit;
			}
		}

		public string PrimaryAbility {
			get {
				return this.primaryAbility;
			}
		}

		public string[] ArrOfSavingThrows {
			get {
				return this.arrOfSavingThrows;
			}
			set {
				arrOfSavingThrows = value;
			}
		}

		

		public List<string> List {
			get {
				return this.list;
			}
			set {
				list = value;
			}
		}

		public int Level {
			get {
				return this.level;
			}
		}

        public string[] UseWeapon
        {
            get
            {
                return useWeapon;
            }

            set
            {
                useWeapon = value;
            }
        }

        public string[] UseArmor
        {
            get
            {
                return useArmor;
            }

            set
            {
                useArmor = value;
            }
        }

        public string[] UseTools
        {
            get
            {
                return useTools;
            }

            set
            {
                useTools = value;
            }
        }

        public void lvlUp(AbstractRaces model){
			level = ++level;
                        switch(level){
                case 1:
                  firstLevel(model);  
                break;
                    case 2:
                    addHealthAfterFirstLevel(model);
                break;
                    case 3:
                    addHealthAfterFirstLevel(model);
                    break;
                    case 4:
                    addHealthAfterFirstLevel(model);
                    break;
                    case 5:
                    addHealthAfterFirstLevel(model);
                    break;
                    case 6:
                    addHealthAfterFirstLevel(model);
                    break;
                    case 7:
                    addHealthAfterFirstLevel(model);
                    break;
                    case 8:
                    addHealthAfterFirstLevel(model);
                    break;
                    case 9:
                    addHealthAfterFirstLevel(model);
                    break;
                    case 10:
                    addHealthAfterFirstLevel(model);
                    break;
                    default:

                    break;
            }
		}

		public void lvlDown(){
			if(level > 1)
				level = --level;
		}

        public void firstLevel(AbstractRaces model){
            model.Health = (healthDice + model.Mod_constitution + model.Mod_dexterity);
            if(ArrOfSavingThrows != null){
                 foreach(string tmp in ArrOfSavingThrows){
                    model.addSavingThrow(tmp);
                
                 }
            }
  
        }

        public void addHealthAfterFirstLevel(AbstractRaces model){
                model.Health += ThrowDice.ThrowDiceFromHealthDice(healthDice);
                model.recoveryHealth(); 
        }

	}
}

