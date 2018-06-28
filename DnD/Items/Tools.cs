using System;

namespace DnD
{
	public static class Tools
	{

		public abstract class AbstractTools : AItem{
			protected  string name = "";
			protected  string type = "Item";

			protected bool isUse = false;
			protected bool canUse = true;
			protected int count = 1;
			protected string text = "";

			protected  int cost;
			protected  string typeMoney = "gp";
			protected  int weight;

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
				return string.Format ("[AbstractTools: name={0}, type={1}, isUse={2}, canUse={3}, count={4}, text={5}, cost={6}, typeMoney={7}, weight={8}]", name, type, isUse, canUse, count, text, cost, typeMoney, weight);
			}
		}

		public class AlchemistSupplies : AbstractTools{

			public AlchemistSupplies(){
				name = "AlchemistSupplies";
				type = "Artisan’s tools";

				text = "";
				cost = 50;
				typeMoney = "gp";
				weight = 8;
			}
		}
		public class BrewerSupplies : AbstractTools{

			public BrewerSupplies(){
				name = "BrewerSupplies";
				type = "Artisan’s tools";

				text = "";
				cost = 20;
				typeMoney = "gp";
				weight = 9;
			}
		}
		public class CalligrapherSupplies : AbstractTools{

			public CalligrapherSupplies(){
				name = "CalligrapherSupplies";
				type = "Artisan’s tools";

				text = "";
				cost = 10;
				typeMoney = "gp";
				weight = 5;
			}
		}
		public class CarpenterTools : AbstractTools{

			public CarpenterTools(){
				name = "CarpenterTools";
				type = "Artisan’s tools";

				text = "";
				cost = 8;
				typeMoney = "gp";
				weight = 6;
			}
		}
		public class CartographerTools : AbstractTools{

			public CartographerTools(){
				name = "CartographerTools";
				type = "Artisan’s tools";

				text = "";
				cost = 15;
				typeMoney = "gp";
				weight = 6;
			}
		}
		public class CobblerTools : AbstractTools{

			public CobblerTools(){
				name = "CobblerTools";
				type = "Artisan’s tools";

				text = "";
				cost = 5;
				typeMoney = "gp";
				weight = 5;
			}
		}
		public class CookUtensils : AbstractTools{

			public CookUtensils(){
				name = "CookUtensils";
				type = "Artisan’s tools";

				text = "";
				cost = 1;
				typeMoney = "gp";
				weight = 8;
			}
		}
		public class GlassblowerTools : AbstractTools{

			public GlassblowerTools(){
				name = "GlassblowerTools";
				type = "Artisan’s tools";

				text = "";
				cost = 30;
				typeMoney = "gp";
				weight = 5;
			}
		}
		public class JewelerTools : AbstractTools{

			public JewelerTools(){
				name = "JewelerTools";
				type = "Artisan’s tools";

				text = "";
				cost = 25;
				typeMoney = "gp";
				weight = 2;
			}
		}
		public class LeatherworkerTools : AbstractTools{

			public LeatherworkerTools(){
				name = "LeatherworkerTools";
				type = "Artisan’s tools";

				text = "";
				cost = 5;
				typeMoney = "gp";
				weight = 5;
			}
		}
		public class MasonTools : AbstractTools{

			public MasonTools(){
				name = "MasonTools";
				type = "Artisan’s tools";

				text = "";
				cost = 10;
				typeMoney = "gp";
				weight = 8;
			}
		}
		public class PainterSupplies : AbstractTools{

			public PainterSupplies(){
				name = "PainterSupplies";
				type = "Artisan’s tools";

				text = "";
				cost = 10;
				typeMoney = "gp";
				weight = 5;
			}
		}
		public class PotterTools : AbstractTools{

			public PotterTools(){
				name = "PotterTools";
				type = "Artisan’s tools";

				text = "";
				cost = 10;
				typeMoney = "gp";
				weight = 3;
			}
		}
		public class SmithTools : AbstractTools{

			public SmithTools(){
				name = "SmithTools";
				type = "Artisan’s tools";

				text = "";
				cost = 20;
				typeMoney = "gp";
				weight = 8;
			}
		}
		public class TinkerTools : AbstractTools{

			public TinkerTools(){
				name = "TinkerTools";
				type = "Artisan’s tools";

				text = "";
				cost = 50;
				typeMoney = "gp";
				weight = 10;
			}
		}
		public class WeaverTools : AbstractTools{

			public WeaverTools(){
				name = "WeaverTools";
				type = "Artisan’s tools";

				text = "";
				cost = 1;
				typeMoney = "gp";
				weight = 5;
			}
		}
		public class WoodcarverTools : AbstractTools{

			public WoodcarverTools(){
				name = "WoodcarverTools";
				type = "Artisan’s tools";

				text = "";
				cost = 1;
				typeMoney = "gp";
				weight = 5;
			}
		}
		public class DisguiseKit : AbstractTools{

			public DisguiseKit(){
				name = "DisguiseKit";
				type = "Kit";

				text = "";
				cost = 15;
				typeMoney = "gp";
				weight = 3;
			}
		}
		public class ForgeryKit : AbstractTools{

			public ForgeryKit(){
				name = "ForgeryKit";
				type = "Kit";

				text = "";
				cost = 15;
				typeMoney = "gp";
				weight = 5;
			}
		}

		public class DiceSet : AbstractTools{

			public DiceSet(){
				name = "DiceSet";
				type = "Gaming set";

				text = "";
				cost = 1;
				typeMoney = "sp";
				weight = 0;
			}
		}
		public class DragonchessSet : AbstractTools{

			public DragonchessSet(){
				name = "DragonchessSet";
				type = "Gaming set";

				text = "";
				cost = 1;
				typeMoney = "gp";
				weight = 1;
			}
		}
		public class PlayingCardSet : AbstractTools{

			public PlayingCardSet(){
				name = "PlayingCardSet";
				type = "Gaming set";

				text = "";
				cost = 5;
				typeMoney = "sp";
				weight = 0;
			}
		}
		public class ThreeDragonAnteSet : AbstractTools{

			public ThreeDragonAnteSet(){
				name = "ThreeDragonAnteSet";
				type = "Gaming set";

				text = "";
				cost = 1;
				typeMoney = "gp";
				weight = 0;
			}
		}
		public class HerbalismKit : AbstractTools{

			public HerbalismKit(){
				name = "HerbalismKit";
				type = "Kit";

				text = "";
				cost = 5;
				typeMoney = "gp";
				weight = 3;
			}
		}
		public class Bagpipes : AbstractTools{

			public Bagpipes(){
				name = "Bagpipes";
				type = "Musical instrument";

				text = "";
				cost = 30;
				typeMoney = "gp";
				weight = 6;
			}
		}
		public class Drum : AbstractTools{

			public Drum(){
				name = "Drum";
				type = "Musical instrument";

				text = "";
				cost = 6;
				typeMoney = "gp";
				weight = 3;
			}
		}
		public class Dulcimer : AbstractTools{

			public Dulcimer(){
				name = "Dulcimer";
				type = "Musical instrument";

				text = "";
				cost = 25;
				typeMoney = "gp";
				weight = 10;
			}
		}
		public class Flute : AbstractTools{

			public Flute(){
				name = "Flute";
				type = "Musical instrument";

				text = "";
				cost = 2;
				typeMoney = "gp";
				weight = 1;
			}
		}
		public class Lute : AbstractTools{

			public Lute(){
				name = "Lute";
				type = "Musical instrument";

				text = "";
				cost = 35;
				typeMoney = "gp";
				weight = 2;
			}
		}
		public class Lyre : AbstractTools{

			public Lyre(){
				name = "Lyre";
				type = "Musical instrument";

				text = "";
				cost = 30;
				typeMoney = "gp";
				weight = 2;
			}
		}
		public class Horn : AbstractTools{

			public Horn(){
				name = "Horn";
				type = "Musical instrument";

				text = "";
				cost = 3;
				typeMoney = "gp";
				weight = 2;
			}
		}
		public class PanFlute : AbstractTools{

			public PanFlute(){
				name = "PanFlute";
				type = "Musical instrument";

				text = "";
				cost = 12;
				typeMoney = "gp";
				weight = 2;
			}
		}
		public class Viol : AbstractTools{

			public Viol(){
				name = "Viol";
				type = "Musical instrument";

				text = "";
				cost = 30;
				typeMoney = "gp";
				weight = 1;
			}
		}
		public class NavigatoTools : AbstractTools{

			public NavigatoTools(){
				name = "NavigatoTools";
				type = "Kit";

				text = "";
				cost = 25;
				typeMoney = "gp";
				weight = 2;
			}
		}
		public class PoisonerKit : AbstractTools{

			public PoisonerKit(){
				name = "PoisonerKit";
				type = "Kit";

				text = "";
				cost = 50;
				typeMoney = "gp";
				weight = 2;
			}
		}
		public class ThievesTools : AbstractTools{

			public ThievesTools(){
				name = "ThievesTools";
				type = "Kit";

				text = "";
				cost = 25;
				typeMoney = "gp";
				weight = 1;
			}
		}

	}
}

