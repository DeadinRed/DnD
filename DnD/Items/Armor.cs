using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.CSharp;

namespace DnD
{
	
	 public static class Armor{
        

		 public  abstract class AbstractArmor  : AItem{

			protected  string name;
			protected  string type;


			protected bool isUse = false;
			protected bool canUse = true;
			protected int count = 1;
			protected string text = "";

			protected  int cost;
			protected  string typeMoney = "gp";
			protected  int weight;

			protected  int armorClass;
			protected  int armorStrength;
			protected  bool stealth;

            public AbstractArmor(){
                ClassName = "Armor";
            }

            public override string ToString ()
		 	{
		 		return string.Format ("[AbstractArmor: isUse={0}, canUse={1}, count={2}, text={3}, cost={4} {5}, armorClass={6}, weight={7}, armorStrength={8}, stealth={9}, name={10}, type={11}]", isUse, canUse, count, text, cost, typeMoney, armorClass, weight, armorStrength, stealth, name, type);
		 	}



            public  bool IsUse {
				get {
					return this.isUse;
				}
				set {
					isUse = value;
				}
			}

			public    bool CanUse {
				get {
					return this.canUse;
				}
				set {
					canUse = value;
				}
			}
				
			public    int Count {
				get {
					return this.count;
				}
				set {
					count = value;
				}
			}

			public    string Text {
				get {
					return this.text;
				}
				set {
					text = value;
				}
			}
				
			public    int Cost {
				get {
					return this.cost;
				}
			}
		
			public  string TypeMoney {
		 		get {
		 			return this.typeMoney;
		 		}
		 	}
				
			public int ArmorClass {
				get {
					return this.armorClass;
				}

			}

			public    int Weight {
				get {
					return this.weight;
				}
			}

			public    int ArmorStrength {
				get {
					return this.armorStrength;
				}
			}

			public    bool Stealth {
				get {
					return this.stealth;
				}
			}

			public   string Name {
				get {
					return this.name;
				}
			}

			public   string Type {
				get {
					return this.type;
				}
			}


			
		}

		 public class Padded : AbstractArmor{
			
			 public Padded ()
			{
				cost = 5;
				armorClass =  11;
				weight = 8;
				armorStrength = 0;
				stealth = true;

				name = "Padded";
				type = "Light Armor";

			}
			

		}
		 public class Leather : AbstractArmor{


            public Leather () : base ()
			{
				this.cost = 10;
				this.armorClass =  11;
				this.weight = 10;
				this.armorStrength = 0;
				this.stealth = true;

				this.name = "Leather";
				this.type = "Light Armor";

			}

		}
		 public class Hide : AbstractArmor{

            public Hide () : base ()
			{
				this.cost = 10;
				this.armorClass =  12;
				this.weight = 12;
				this.armorStrength = 0;
				this.stealth = true;

				this.name = "Hide";
				this.type = "Medium Armor";

			}

		}
		 public class ScaleMail : AbstractArmor{

            public ScaleMail () : base ()
			{
				this.cost = 50;
				this.armorClass =  14;
				this.weight = 45;
				this.armorStrength = 0;
				this.stealth = false;

				this.name = "ScaleMail";
				this.type = "Medium Armor";

			}

		}
		 public class Breastplate : AbstractArmor{

            public Breastplate () : base ()
			{
				this.cost = 400;
				this.armorClass =  14;
				this.weight = 20;
				this.armorStrength = 0;
				this.stealth = true;

				this.name = "Breastplate";
				this.type = "Medium Armor";

			}

		}
		 public class RingMail : AbstractArmor{

            public RingMail () : base ()
			{
				this.cost = 30;
				this.armorClass =  14;
				this.weight = 40;
				this.armorStrength = 0;
				this.stealth = false;

				this.name = "RingMail";
				this.type = "Heavy Armor";

			}

		}
		 public class ChainMail : AbstractArmor{


            public ChainMail () : base ()
			{
				this.cost = 75;
				this.armorClass =  16;
				this.weight = 55;
				this.armorStrength = 13;
				this.stealth = false;

				this.name = "ChainMail";
				this.type = "Heavy Armor";

			}

		}
		 public class Splint : AbstractArmor{

            public Splint () : base ()
			{
				this.cost = 200;
				this.armorClass =  17;
				this.weight = 60;
				this.armorStrength = 15;
				this.stealth = false;

				this.name = "Splint";
				this.type = "Heavy Armor";

			}

		}
		 public class Plate : AbstractArmor{

            public Plate () : base ()
			{
				this.cost = 1500;
				this.armorClass =  18;
				this.weight = 65;
				this.armorStrength = 15;
				this.stealth = false;

				this.name = "Plate";
				this.type = "Heavy Armor";

			}
		}
		 public class Shield : AbstractArmor{

            public Shield () : base ()
			{
				this.cost = 10;
				this.armorClass =  2;
				this.weight = 6;
				this.armorStrength = 0;
				this.stealth = true;

				this.name = "Shield";
				this.type = "Shield";

			}
					
		}
			
	}
}

