using System;
using System.Dynamic;
namespace DnD
{
	
	public static class Weapon
	{
		
		public abstract class AbstractWeapon : AItem{
			protected bool isUse = false;
			private bool canUse = true;
			protected int count = 1;
			protected string text = "";

			protected  int cost;
			protected  string typeMoney = "gp";
			protected  int damage;
			protected string textOfDamage;
			protected  int weight;
			protected string properties;

			protected  string  name;
			protected  string type;

            public AbstractWeapon(){
                ClassName = "Armor";
            }


			public  bool IsUse {
				get {
					return this.isUse;
				}
				set {
					isUse = value;
				}
			}

			public  bool CanUse {
				get {
					return this.canUse;
				}
				set {
					canUse = value;
				}
			}

			public  int Count {
				get {
					return this.count;
				}
				set {
					count = value;
				}
			}

			public  string Text {
				get {
					return this.text;
				}
				set {
					text = value;
				}
			}

			public  int Cost {
				get {
					return this.cost;
				}
			}

			public  string TypeMoney {
				get {
					return this.typeMoney;
				}
			}
				
			public  string TextOfDamage {
				get {
					return this.textOfDamage;
				}
				set {
					textOfDamage = value;
				}
			}

			public  int Weight {
				get {
					return this.weight;
				}
			}

			public  string Properties {
				get {
					return this.properties;
				}
			}

			public  string  Name {
				get {
					return this. name;
				}
			}

			public  string Type {
				get {
					return this.type;
				}
			}

            public override string ToString ()
			{
				return string.Format ("[AbstractWeapon: isUse={0}, canUse={1}, count={2}, text={3}, cost={4} {5}, damage={6}, textOfDamage={7}, weight={8}, properties={9}, name={10}, type={11}]", isUse, canUse, count, text, cost, typeMoney, damage, textOfDamage, weight, properties, name, type);
			}
			
				
		}

		public class Club : AbstractWeapon{
			public Club(){
				this.cost = 1;
				this.typeMoney = "sp";
				this.textOfDamage = "1d4 bludgeoning";
				this.weight = 2;
				this.properties = "Light";

				this.name = "Club";
				this.type = "Simple Melee Weapons";
			}

		}

		public class Dagger : AbstractWeapon{
			public Dagger(){
				this.cost = 2;
				
				this.textOfDamage = "1d4 piercing";
				this.weight = 1;
				this.properties = "Finesse, light, thrown (range 20/60)";

				this.name = "Dagger";
				this.type = "Simple Melee Weapons";
			}
		}

		public class GreatClub : AbstractWeapon{
			public GreatClub(){
				this.cost = 2;
				this.typeMoney = "sp";
				this.textOfDamage = "1d8 bludgeoning";
				this.weight = 0;
				this.properties = "Two-handed";
				this.name = "GreatClub";
				this.type = "Simple Melee Weapons";
			}
		}

		public class HandAxe : AbstractWeapon{

			public HandAxe(){
				this.cost = 5;
				
				this.textOfDamage = "1d6 slashing";
				this.weight = 2;
				this.properties = "Light, thrown (range 20/60)";
				this.name = "Handaxe";
				this.type = "Simple Melee Weapons";
			}
		}

		public class Javelin : AbstractWeapon{

			public Javelin(){
				this.cost = 5;
				this.typeMoney = "sp";
				this.textOfDamage = "1d6 piercing";
				this.weight = 2;
				this.properties = "Thrown (range 30/120)";
				this.name = "Javelin";
				this.type = "Simple Melee Weapons";
			}
		}

		public class LightHammer : AbstractWeapon{

			public LightHammer(){
				this.cost = 2;
				
				this.textOfDamage = "1d4 bludgeoning";
				this.weight = 2;
				this.properties = "Light, thrown (range 20/60)";
				this.name = "LightHammer";
				this.type = "Simple Melee Weapons";
			}
		}

		public class Mace : AbstractWeapon{

			public Mace(){
				this.cost = 5;
				
				this.textOfDamage = "1d6 bludgeoning";
				this.weight = 4;
				this.properties = "-";
				this.name = "Mace";
				this.type = "Simple Melee Weapons";
			}
		}

		public class Quarterstaff : AbstractWeapon{

			public Quarterstaff(){
				this.cost = 2;
				this.typeMoney = "sp";
				this.textOfDamage = "1d6 bludgeoning";
				this.weight = 4;
				this.properties = "Versatile (1d8)";
				this.name = "Quarterstaff";
				this.type = "Simple Melee Weapons";
			}
		}

		public class Sickle : AbstractWeapon{

			public Sickle(){
				this.cost = 1;
				
				this.textOfDamage = "1d4 slashing";
				this.weight = 2;
				this.properties = "Light";
				this.name = "Sickle";
				this.type = "Simple Melee Weapons";
			}
		}

		public class Spear : AbstractWeapon{

			public Spear(){
				this.cost = 1;
				
				this.textOfDamage = "1d6 piercing";
				this.weight = 3;
				this.properties = "Thrown (range 20/60), versatile (1d8)";
				this.name = "Spear";
				this.type = "Simple Melee Weapons";
			}

		}

		public class UnarmedStrike : AbstractWeapon{
		
			public UnarmedStrike(){
				this.cost = 0;
				
				this.textOfDamage = "";
				this.weight = 0;
				this.properties = "-";
				this.name = "UnarmedStrike";
				this.type = "Simple Melee Weapons";
			}
		}

		public class CrossbowLight : AbstractWeapon{

			public CrossbowLight(){
				this.cost = 25;
				
				this.textOfDamage = "1d8 piercing";
				this.weight = 5;
				this.properties = "Ammunition (range 80/320), loading, two-handed";
				this.name = "CrossbowLight";
				this.type = "Simple Ranged Weapons";
			}
		}

		public class Dart : AbstractWeapon{

			public Dart(){
				this.cost = 5;
				this.typeMoney = "cp";
				this.textOfDamage = "1d4 piercing";
				this.weight = 1;
				this.properties = "Finesse, thrown (range 20/60)";
				this.name = "Dart";
				this.type = "Simple Ranged Weapons";
			}
		}

		public class Shortbow : AbstractWeapon{

			public Shortbow(){
				this.cost = 25;
				
				this.textOfDamage = "1d6 piercing";
				this.weight = 2;
				this.properties = "Ammunition (range 80/320), two-handed";
				this.name = "Shortbow";
				this.type = "Simple Ranged Weapons";
			}
		}
			
		public class Sling : AbstractWeapon{

			public Sling(){
				this.cost = 1;
				this.typeMoney = "sp";
				this.textOfDamage = "1d4 bludgeoning";
				this.weight = 0;
				this.properties = "Ammunition (range 30/120)";
				this.name = "Sling";
				this.type = "Simple Ranged Weapons";
			}
			
		}

		public class BattleAxe : AbstractWeapon{

			public BattleAxe(){
				this.cost = 10;
				
				this.textOfDamage = "1d8 slashing";
				this.weight = 4;
				this.properties = "Versatile (1d10)";
				this.name = "BattleAxe";
				this.type = "Martial Melee Weapons";
			}
		}

		public class Flail : AbstractWeapon{
			
			public Flail(){
				this.cost = 10;
				
				this.textOfDamage = "1d8 bludgeoning";
				this.weight = 3;
				this.properties = "-";
				this.name = "Flail";
				this.type = "Martial Melee Weapons";
			}
		}

		public class Glaive : AbstractWeapon{

			public Glaive(){
				this.cost = 20;
				
				this.textOfDamage = "1d10 slashing";
				this.weight = 6;
				this.properties = "Heavy, reach, two-handed";
				this.name = "Glaive";
				this.type = "Martial Melee Weapons";
			}
		}

		public class GreatAxe : AbstractWeapon{

			public GreatAxe(){
				this.cost = 30;
				
				this.textOfDamage = "1d12 slashing";
				this.weight = 7;
				this.properties = "Heavy, two-handed";
				this.name = "GreatAxe";
				this.type = "Martial Melee Weapons";
			}
		}

		public class GreatSword : AbstractWeapon{

			public GreatSword(){
				this.cost = 50;
				
				this.textOfDamage = "2d6 slashing";
				this.weight = 6;
				this.properties = "Heavy, two-handed";
				this.name = "GreatSword";
				this.type = "Martial Melee Weapons";
			}
		}
			
		public class Halberg : AbstractWeapon{

			public Halberg(){
				this.cost = 20;
				
				this.textOfDamage = "";
				this.weight = 6;
				this.properties = "Heavy, reach, two-handed";
				this.name = "Halberg";
				this.type = "Martial Melee Weapons";
			}
		}

		public class Lance : AbstractWeapon{

			public Lance(){
				this.cost = 10;
				
				this.textOfDamage = "1d12 piercing";
				this.weight = 6;
				this.properties = "Reach, specia";
				this.name = "Lance";
				this.type = "Martial Melee Weapons";
			}
		}

		public class LongSword : AbstractWeapon{

			public LongSword(){
				this.cost = 15;
				
				this.textOfDamage = "1d8 slashing";
				this.weight = 3;
				this.properties = "Versatile (1d10)";
				this.name = "LongSword";
				this.type = "Martial Melee Weapons";
			}
		}

		public class Maul : AbstractWeapon{

			public Maul(){
				this.cost = 10;
				
				this.textOfDamage = "2d6 bludgeoning";
				this.weight = 10;
				this.properties = "Heavy, two-handed";
				this.name = "Maul";
				this.type = "Martial Melee Weapons";
			}
		}

		public class Morningstar : AbstractWeapon{

			public Morningstar(){
				this.cost = 15;
				
				this.textOfDamage = "1d8 piercing";
				this.weight = 4;
				this.properties = "-";
				this.name = "Morningstar";
				this.type = "Martial Melee Weapons";
			}
		}

		public class Pike : AbstractWeapon{

			public Pike(){
				this.cost = 5;
				
				this.textOfDamage = "1d10 piercing";
				this.weight = 18;
				this.properties = "Heavy, reach, two-handed";
				this.name = "Pike";
				this.type = "Martial Melee Weapons";
			}
		}

		public class Rapier : AbstractWeapon{

			public Rapier(){
				this.cost = 25;
				
				this.textOfDamage = "1d8 piercing";
				this.weight = 2;
				this.properties = "Finesse";
				this.name = "Rapier";
				this.type = "Martial Melee Weapons";
			}
		}

		public class Scimitar : AbstractWeapon{

			public Scimitar(){
				this.cost = 25;
				
				this.textOfDamage = "1d6 slashing";
				this.weight = 3;
				this.properties = "Finesse, light";
				this.name = "Scimitar";
				this.type = "Martial Melee Weapons";
			}
		}

		public class ShortSword : AbstractWeapon{
		
			public ShortSword(){
				this.cost = 10;
				
				this.textOfDamage = "1d6 piercing";
				this.weight = 2;
				this.properties = "Finesse, light";
				this.name = "ShortSword";
				this.type = "Martial Melee Weapons";
			}
		}

		public class Trident : AbstractWeapon{

			public Trident(){
				this.cost = 5;
				
				this.textOfDamage = "1d6 piercing";
				this.weight = 4;
				this.properties = "Thrown (range 20/60), versatile (1d8)";
				this.name = "Trident";
				this.type = "Martial Melee Weapons";
			}
		}

		public class WarPick : AbstractWeapon{

			public WarPick(){
				this.cost = 5;
				
				this.textOfDamage = "1d8 piercing";
				this.weight = 2;
				this.properties = "-";
				this.name = "WarPick";
				this.type = "Martial Melee Weapons";
			}
		}

		public class WarHammer : AbstractWeapon{

			public WarHammer(){
				this.cost = 15;
				
				this.textOfDamage = "1d8 bludgeoning";
				this.weight = 2;
				this.properties = "Versatile (1d10)";
				this.name = "WarHammer";
				this.type = "Martial Melee Weapons";
			}
		}

		public class Whip : AbstractWeapon{

			public Whip(){
				this.cost = 2;
				
				this.textOfDamage = "1d4 slashing";
				this.weight = 3;
				this.properties = "Finesse, reach";
				this.name = "Whip";
				this.type = "Martial Melee Weapons";
			}
		}

		public class Blowgun : AbstractWeapon{

			public Blowgun(){
				this.cost = 10;
				
				this.textOfDamage = "1 piercing";
				this.weight = 3;
				this.properties = "Ammunition (range 25/100), loading";
				this.name = "Blowgun";
				this.type = "Martial Ranged Weapons";
			}
		}

		public class CrossbowHand : AbstractWeapon{

			public CrossbowHand(){
				this.cost = 75;
				
				this.textOfDamage = "1d6 piercing";
				this.weight = 3;
				this.properties = "Ammunition (range 30/120), light, loading";
				this.name = "CrossbowHand";
				this.type = "Martial Ranged Weapons";
			}
		}
			
		public class CrossbowHeavy : AbstractWeapon{

			public CrossbowHeavy(){
				this.cost = 50;
				
				this.textOfDamage = "1d10 piercing";
				this.weight = 18;
				this.properties = "Ammunition (range 100/400), heavy, loading, two-handed";
				this.name = "CrossbowHeavy";
				this.type = "Martial Ranged Weapons";
			}
		}

		public class Longbow : AbstractWeapon{

			public Longbow(){
				this.cost = 50;
				
				this.textOfDamage = "1d8 piercing";
				this.weight = 2;
				this.properties = "Ammunition (range 150/600), heavy, two-handed";
				this.name = "Longbow";
				this.type = "Martial Ranged Weapons";
			}

		}

		public class Net : AbstractWeapon{
			public Net(){
				this.cost = 1;
				
				this.textOfDamage = "-";
				this.weight = 3;
				this.properties = "Special, thrown (range 5/15)";
				this.name = "Net";
				this.type = "Martial Ranged Weapons";
			}
		}
	
	}


}

