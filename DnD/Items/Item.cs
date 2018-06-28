using System;

namespace DnD
{
	public class Item

	{

		public class AbstractItem : AItem{
           

			protected  string name = "";
			protected  string type = "Item";

			protected bool isUse = false;
			protected bool canUse = true;
			protected int count = 1;
			protected string text = "";

			protected  int cost;
			protected  string typeMoney = "gp";
			protected  int weight;

			public AbstractItem (string name)
			{
				this.name = name;

			}
			public AbstractItem ()
			{

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

			public    int Weight {
				get {
					return this.weight;
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

            public override string ToString ()
			{
				return string.Format ("[AbstractItem: name={0}, type={1}, isUse={2}, canUse={3}, count={4}, text={5}, cost={6}, typeMoney={7}, weight={8}]", name, type, isUse, canUse, count, text, cost, typeMoney, weight);
			}
			
		}

		public class MasterItem : AItem{

			protected  string name = "";
			protected  string type = "Item";

			protected bool isUse = false;
			protected bool canUse = true;
			protected int count = 1;
			protected string text = "";

			protected  int cost;
			protected  string typeMoney = "gp";
			protected  int weight;

			public MasterItem (string name)
			{
				this.name = name;

			}
			public MasterItem ()
			{

			}

			public  string Name {
				get {
					return this.name;
				}
				set {
					name = value;
				}
			}

			public  string Type {
				get {
					return this.type;
				}
				set {
					type = value;
				}
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
				set {
					cost = value;
				}
			}

			public  string TypeMoney {
				get {
					return this.typeMoney;
				}
				set {
					typeMoney = value;
				}
			}

			public  int Weight {
				get {
					return this.weight;
				}
				set {
					weight = value;
				}
			}

            public override string ToString ()
			{
				return string.Format ("[AbstractItem: name={0}, type={1}, isUse={2}, canUse={3}, count={4}, text={5}, cost={6}, typeMoney={7}, weight={8}]", name, type, isUse, canUse, count, text, cost, typeMoney, weight);
			}

		}

		public class Abacus : AbstractItem {
			
			public Abacus() {

				cost = 2;
				weight = 2;

				name = "Abacus";
				type = "Item";
			}
		}

		public class VialAcid : AbstractItem { 

			public VialAcid() {

				cost = 25;
				weight = 1;

				name = "VialAcid";
				type = "Item";
			}
		}

		public class Antitoxin : AbstractItem {

			public Antitoxin() {

				cost = 50;
				weight = 0;

				name = "Antitoxin";
				type = "Item";
			}
		}

		public class AlchimistsFire : AbstractItem {

			public AlchimistsFire() {

				cost = 50;
				weight = 1;

				name = "AlchimistsFire";
				type = "Item";
			}
		}

		public class Arrows : AbstractItem {

			public Arrows() {

				cost = 1;
				weight = 1;
				count = 20;
				name = "Arrows";
				type = "Ammunition";
			}
		}

		public class BlowgunNeedles : AbstractItem {

			public BlowgunNeedles() {

				cost = 1;
				weight = 1;
				count = 50;
				name = "BlowgunNeedles";
				type = "Ammunition";
			}
		}

		public class CrossbowBolts : AbstractItem {

			public CrossbowBolts() {

				cost = 1;
				weight = 1;
				count = 20;
				name = "CrossbowBolts";
				type = "Ammunition";
			}
		}

		public class SlingBullets : AbstractItem {

			public SlingBullets() {

				cost = 4;
				weight = 1;
				count = 20;
				typeMoney = "cp";
				name = "SlingBullets";
				type = "Ammunition";
			}
		}

		public class Crystal : AbstractItem {

			public Crystal() {

				cost = 10;
				weight = 1;

				name = "Crystal";
				type = "Item";
			}
		}

		public class Orb : AbstractItem {

			public Orb() {

				cost = 20;
				weight = 3;

				name = "Orb";
				type = "Item";
			}
		}

		public class Rod : AbstractItem {

			public Rod() {

				cost = 10;
				weight = 2;

				name = "Rod";
				type = "Item";
			}
		}

		public class Staff : AbstractItem {

			public Staff() {

				cost = 5;
				weight = 4;

				name = "Staff";
				type = "Item";
			}
		}

		public class Wand : AbstractItem {

			public Wand() {

				cost = 10;
				weight = 1;

				name = "Abacus";
				type = "Item";
			}
		}

		public class Backpack : AbstractItem {

			public Backpack() {

				cost = 2;
				weight = 5;

				name = "Backpack";
				type = "Item";
			}
		}

		public class BallBearings : AbstractItem {

			public BallBearings() {

				cost = 5;
				weight = 8;
				count = 1000;
				name = "BallBearings";
				type = "Item";
			}
		}

		public class Barrel : AbstractItem {

			public Barrel() {

				cost = 2;
				weight = 70;

				name = "Barrel";
				type = "Item";
			}
		}

		public class Basket : AbstractItem {

			public Basket() {

				cost = 4;
				weight = 2;
				typeMoney = "sp";
				name = "Basket";
				type = "Item";
			}
		}

		public class Bedroll : AbstractItem {

			public Bedroll() {

				cost = 1;
				weight = 7;

				name = "Bedroll";
				type = "Item";
			}
		}

		public class Bell : AbstractItem {

			public Bell() {

				cost = 1;
				weight = 0;

				name = "Bell";
				type = "Item";
			}
		}

		public class Blanket : AbstractItem {

			public Blanket() {

				cost = 5;
				weight = 3;
				typeMoney = "сp";
				name = "Blanket";
				type = "Item";
			}
		}

		public class BlockAndTackle : AbstractItem {

			public BlockAndTackle() {

				cost = 1;
				weight = 5;

				name = "BlockAndTackle";
				type = "Item";
			}
		}

		public class Book : AbstractItem {

			public Book() {

				cost = 25;
				weight = 5;

				name = "Book";
				type = "Item";
			}
		}

		public class Bottle : AbstractItem {

			public Bottle() {

				cost = 2;
				weight = 2;

				name = "Bottle";
				type = "Item";
			}
		}

		public class Bucket : AbstractItem {

			public Bucket() {

				cost = 5;
				weight = 2;

				name = "Bucket";
				type = "Item";
			}
		}

		public class Caltrops : AbstractItem {

			public Caltrops() {

				cost = 1;
				weight = 2;
				count = 20;
				name = "Caltrops";
				type = "Item";
			}
		}

		public class Candle : AbstractItem {

			public Candle() {

				cost = 1;
				weight = 0;
				typeMoney = "cp";
				name = "Candle";
				type = "Item";
			}
		}

		public class CaseOfCrossbowBolt : AbstractItem {

			public CaseOfCrossbowBolt() {

				cost = 1;
				weight = 1;

				name = "CaseOfCrossbowBolt";
				type = "Item";
			}
		}
			
		public class CaseOfCrossbowMap : AbstractItem {

			public CaseOfCrossbowMap() {

				cost = 1;
				weight = 1;

				name = "CaseOfCrossbowMap";
				type = "Item";
			}
		}
		public class Chain : AbstractItem {

			public Chain() {

				cost = 5;
				weight = 10;
				count = 10;
				name = "Chain";
				type = "Item";
			}
		}

		public class Chalk : AbstractItem {

			public Chalk() {

				cost = 1;
				weight = 0;
				typeMoney = "cp";
				name = "Chalk";
				type = "Item";
			}
		}

		public class Chest : AbstractItem {

			public Chest() {

				cost = 5;
				weight = 25;

				name = "Chest";
				type = "Item";
			}
		}

		public class ClimberKit : AbstractItem {

			public ClimberKit() {

				cost = 25;
				weight = 12;

				name = "ClimberKit";
				type = "Item";
			}
		}

		public class Clothes_Common : AbstractItem {

			public Clothes_Common() {

				cost = 5;
				weight = 3;
				typeMoney = "sp";
				name = "ClothesCommon";
				type = "Item";
			}
		}

		public class Clothes_Costume : AbstractItem {

			public Clothes_Costume() {

				cost = 5;
				weight = 4;

				name = "ClothesCostume";
				type = "Item";
			}
		}

		public class Clothes_Traveler : AbstractItem {

			public Clothes_Traveler() {

				cost = 5;
				weight = 6;

				name = "ClothesTraveler";
				type = "Item";
			}
		}

		public class ComponentPouch : AbstractItem {

			public ComponentPouch() {

				cost = 25;
				weight = 2;

				name = "ComponentPouch";
				type = "Item";
			}
		}

		public class SprigOfMistletoe : AbstractItem {

			public SprigOfMistletoe() {

				cost = 1;
				weight = 0;

				name = "SprigOfMistletoe";
				type = "Item";
			}
		}

		public class Totem : AbstractItem {

			public Totem() {

				cost = 1;
				weight = 0;

				name = "Totem";
				type = "Item";
			}
		}

		public class WoodenStaff : AbstractItem {

			public WoodenStaff() {

				cost = 5;
				weight = 4;

				name = "WoodenStaff";
				type = "Item";
			}
		}

		public class YewWand : AbstractItem {

			public YewWand() {

				cost = 10;
				weight = 1;

				name = "YewWand";
				type = "Item";
			}
		}

		public class FishingTackle : AbstractItem {

			public FishingTackle() {

				cost = 1;
				weight = 4;

				name = "FishingTackle";
				type = "Item";
			}
		}

		public class FlaskOrTankard : AbstractItem {

			public FlaskOrTankard() {

				cost = 2;
				weight = 1;
				typeMoney = "cp";
				name = "FlaskOrTankard";
				type = "Item";
			}
		}

		public class GrapplingHook : AbstractItem {

			public GrapplingHook() {

				cost = 2;
				weight = 4;

				name = "GrapplingHook";
				type = "Item";
			}
		}

		public class Hammer : AbstractItem {

			public Hammer() {

				cost = 1;
				weight = 3;

				name = "Hammer";
				type = "Item";
			}
		}

		public class HammerSledge : AbstractItem {

			public HammerSledge() {

				cost = 2;
				weight = 10;

				name = "HammerSledge";
				type = "Item";
			}
		}

		public class HealerKit : AbstractItem {

			public HealerKit() {

				cost = 5;
				weight = 3;

				name = "HealerKit";
				type = "Item";
			}
		}

		public class Amulet : AbstractItem {

			public Amulet() {

				cost = 5;
				weight = 1;

				name = "Amulet";
				type = "Item";
			}
		}

		public class Emblem : AbstractItem {

			public Emblem() {

				cost = 5;
				weight = 0;

				name = "Emblem";
				type = "Item";
			}
		}

		public class Reliquary : AbstractItem {

			public Reliquary() {

				cost = 5;
				weight = 2;

				name = "Reliquary";
				type = "Item";
			}
		}

		public class HolyWater_flask : AbstractItem {

			public HolyWater_flask() {

				cost = 25;
				weight = 1;

				name = "HolyWater";
				type = "Item";
			}
		}

		public class Hourglass : AbstractItem {

			public Hourglass() {

				cost = 25;
				weight = 1;

				name = "Hourglass";
				type = "Item";
			}
		}

		public class HuntingTrap : AbstractItem {

			public HuntingTrap() {

				cost = 5;
				weight = 25;

				name = "HuntingTrap";
				type = "Item";
			}
		}

		public class FlaskOfInk : AbstractItem {

			public FlaskOfInk() {

				cost = 10;
				weight = 0;

				name = "FlaskOfInk";
				type = "Item";
			}
		}

		public class Ink : AbstractItem {

			public Ink() {

				cost = 10;
				weight = 0;

				name = "Ink";
				type = "Item";
			}
		}

		public class InkPen : AbstractItem {

			public InkPen() {

				cost = 2;
				weight = 0;
				typeMoney = "cp";
				name = "InkPen";
				type = "Item";
			}
		}

		public class JugOrPitcher : AbstractItem {

			public JugOrPitcher() {

				cost = 2;
				weight = 4;
				typeMoney = "cp";
				name = "JugOrPitcher";
				type = "Item";
			}
		}

		public class Ladder : AbstractItem {

			public Ladder() {

				cost = 5;
				weight = 8;
				count = 10;
				typeMoney = "sp";
				name = "Ladder";
				type = "Item";
			}
		}

		public class Lamp : AbstractItem {

			public Lamp() {

				cost = 5;
				weight = 1;

				name = "Lamp";
				type = "Item";
			}
		}

		public class Lantern_Bullseye : AbstractItem {

			public Lantern_Bullseye() {

				cost = 10;
				weight = 2;

				name = "Lantern_Bullseye";
				type = "Item";
			}
		}

		public class Lantern_Hooded : AbstractItem {

			public Lantern_Hooded() {

				cost = 5;
				weight = 2;

				name = "AbaLantern_Hoodedcus";
				type = "Item";
			}
		}

		public class Lock : AbstractItem {

			public Lock() {

				cost = 10;
				weight = 1;

				name = "Lock";
				type = "Item";
			}
		}

		public class MagnifyingGlass : AbstractItem {

			public MagnifyingGlass() {

				cost = 100;
				weight = 0;

				name = "MagnifyingGlass";
				type = "Item";
			}
		}

		public class Manacles : AbstractItem {

			public Manacles() {

				cost = 2;
				weight = 6;

				name = "Manacles";
				type = "Item";
			}
		}

		public class MessKit : AbstractItem {

			public MessKit() {

				cost = 2;
				weight = 1;
				typeMoney = "sp";
				name = "MessKit";
				type = "Item";
			}
		}
			
		public class Mirror_steel : AbstractItem {

			public Mirror_steel() {

				cost = 5;
				weight = 1;

				name = "Mirror_steel";
				type = "Item";
			}
		}

		public class FlaskOfOil : AbstractItem {

			public FlaskOfOil() {

				cost = 1;
				weight = 1;

				name = "FlaskOfOil";
				type = "Item";
			}
		}

		public class Paper : AbstractItem {

			public Paper() {

				cost = 2;
				weight = 0;
				typeMoney = "sp";
				name = "Paper";
				type = "Item";
			}
		}

		public class Parchment : AbstractItem {

			public Parchment() {

				cost = 1;
				weight = 0;
				typeMoney = "sp";
				name = "Parchment";
				type = "Item";
			}
		}

		public class Perfume : AbstractItem {

			public Perfume() {

				cost = 5;
				weight = 0;

				name = "Perfume";
				type = "Item";
			}
		}

		public class Pick_miner : AbstractItem {

			public Pick_miner() {

				cost = 2;
				weight = 10;

				name = "Pick_miner";
				type = "Item";
			}
		}

		public class Piton : AbstractItem {

			public Piton() {

				cost = 5;
				weight = 1;
				typeMoney = "cp";
				name = "Piton";
				type = "Item";
			}
		}

		public class Poison : AbstractItem {

			public Poison() {

				cost = 100;
				weight = 0;

				name = "Poison";
				type = "Item";
			}
		}

		public class Pole : AbstractItem {

			public Pole() {

				cost = 5;
				weight = 7;
				count = 10;
				typeMoney = "cp";
				name = "Pole";
				type = "Item";
			}
		}

		public class Pot : AbstractItem {

			public Pot() {

				cost = 2;
				weight = 10;

				name = "Pot";
				type = "Item";
			}
		}

		public class PotionOfHealing : AbstractItem {

			public PotionOfHealing() {

				cost = 50;
				weight = 1;

				name = "PotionOfHealing";
				type = "Item";
			}
		}

		public class Pouch : AbstractItem {

			public Pouch() {

				cost = 5;
				weight = 1;
				typeMoney = "sp";
				name = "Pouch";
				type = "Item";
			}
		}

		public class Quiver : AbstractItem {

			public Quiver() {

				cost = 1;
				weight = 1;

				name = "Quiver";
				type = "Item";
			}
		}

		public class Ram : AbstractItem {

			public Ram() {

				cost = 4;
				weight = 35;

				name = "Ram";
				type = "Item";
			}
		}

		public class Rations : AbstractItem {

			public Rations() {

				cost = 5;
				weight = 2;
				typeMoney = "sp";
				name = "Rations (1 day)";
				type = "Item";
			}
		}

		public class Robes : AbstractItem {

			public Robes() {

				cost = 1;
				weight = 4;

				name = "Robes";
				type = "Item";
			}
		}

		public class Rope_hempen : AbstractItem {

			public Rope_hempen() {

				cost = 1;
				weight = 10;
				count = 10;
				name = "Rope_hempen";
				type = "Item";
			}
		}

		public class Rope_silk : AbstractItem {

			public Rope_silk() {

				cost = 10;
				weight = 5;
				count = 10;
				name = "Rope_silk";
				type = "Item";
			}
		}

		public class Sack : AbstractItem {

			public Sack() {

				cost = 1;
				weight = 1;
				typeMoney = "cp";
				name = "Sack";
				type = "Item";
			}
		}

		public class Scale : AbstractItem {

			public Scale() {

				cost = 5;
				weight = 3;

				name = "Scale";
				type = "Item";
			}
		}

		public class SealingWax : AbstractItem {

			public SealingWax() {

				cost = 5;
				weight = 0;
				typeMoney = "sp";
				name = "SealingWax";
				type = "Item";
			}
		}

		public class Shovel : AbstractItem {

			public Shovel() {

				cost = 2;
				weight = 5;

				name = "Shovel";
				type = "Item";
			}
		}

		public class SignalWhistle : AbstractItem {

			public SignalWhistle() {

				cost = 5;
				weight = 0;

				name = "SignalWhistle";
				type = "Item";
			}
		}

		public class SignetRing : AbstractItem {

			public SignetRing() {

				cost = 5;
				weight = 0;

				name = "SignetRing";
				type = "Item";
			}
		}

		public class Soap : AbstractItem {

			public Soap() {

				cost = 2;
				weight = 0;
				typeMoney = "cp";
				name = "Soap";
				type = "Item";
			}
		}

		public class Spellbook : AbstractItem {

			public Spellbook() {

				cost = 50;
				weight = 3;

				name = "Spellbook";
				type = "Item";
			}
		}

		public class Spikes : AbstractItem {

			public Spikes() {

				cost = 1;
				weight = 5;
				count = 10;
				name = "Spikes";
				type = "Item";
			}
		}

		public class Spyglass : AbstractItem {

			public Spyglass() {

				cost = 1000;
				weight = 1;

				name = "Spyglass";
				type = "Item";
			}
		}

		public class Tent : AbstractItem {

			public Tent() {

				cost = 2;
				weight = 20;

				name = "Tent (2 person)";
				type = "Item";
			}
		}

		public class Tinderbox : AbstractItem {

			public Tinderbox() {

				cost = 5;
				weight = 1;

				name = "Tinderbox";
				type = "Item";
			}
		}

		public class Torch : AbstractItem {

			public Torch() {

				cost = 1;
				weight = 1;
				typeMoney = "cp";
				name = "Torch";
				type = "Item";
			}
		}

		public class Vial : AbstractItem {

			public Vial() {

				cost = 1;
				weight = 0;

				name = "Vial";
				type = "Item";
			}
		}

		public class Waterskin : AbstractItem {

			public Waterskin() {

				cost = 2;
				weight = 5;
				typeMoney = "sp";
				name = "Waterskin";
				type = "Item";
			}
		}

		public class Whetstone : AbstractItem {

			public Whetstone() {

				cost = 1;
				weight = 1;
				typeMoney = "cp";
				name = "Whetstone";
				type = "Item";
			}
		}

			
	}
}

