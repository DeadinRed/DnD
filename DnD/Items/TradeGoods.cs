using System;

namespace DnD
{
	public class TradeGoods
	{
		public abstract class AbstractTradeGoods : AItem {

			protected  string name = "";
			protected  string type = "Goods";

			protected bool isUse = false;
			protected bool canUse = true;
			protected int count = 1;
			protected string text = "";

			protected  int cost;
			protected  string typeMoney = "gp";
			protected  int weight = 1;

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
				return string.Format ("[AbstractTradeGoods: name={0}, type={1}, isUse={2}, canUse={3}, count={4}, text={5}, cost={6}, typeMoney={7}, weight={8}]", name, type, isUse, canUse, count, text, cost, typeMoney, weight);
			}

		}

		public class Wheat : AbstractTradeGoods{
			public Wheat(){
				name = "Wheat";

				text = "";
				cost = 1;
				typeMoney = "cp";
			}
		}
		public class Flour : AbstractTradeGoods{
			public Flour(){
				name = "Flour";

				text = "";
				cost = 2;
				typeMoney = "cp";
			}
		}
		public class Chicken : AbstractTradeGoods{
			public Chicken(){
				name = "Chicken";

				text = "";
				cost = 2;
				typeMoney = "cp";
			}
		}
		public class Salt : AbstractTradeGoods{
			public Salt(){
				name = "Salt";
				text = "";
				cost = 5;
				typeMoney = "cp";
			}
		}
		public class Iron : AbstractTradeGoods{
			public Iron(){
				name = "Iron";

				text = "";
				cost = 1;
				typeMoney = "sp";
			}
		}
		public class Canvas : AbstractTradeGoods{
			public Canvas(){
				name = "Canvas";

				text = "";
				cost = 1;
				typeMoney = "sp";
			}
		}
		public class Copper : AbstractTradeGoods{
			public Copper(){
				name = "Copper";

				text = "";
				cost = 5;
				typeMoney = "sp";
			}
		}
		public class CottonCloth : AbstractTradeGoods{
			public CottonCloth(){
				name = "CottonCloth";

				text = "";
				cost = 5;
				typeMoney = "sp";
			}
		}
		public class Ginger : AbstractTradeGoods{
			public Ginger(){
				name = "Ginger";

				text = "";
				cost = 1;
				typeMoney = "gp";
			}
		}
		public class Goat : AbstractTradeGoods{
			public Goat(){
				name = "Goat";

				text = "";
				cost = 1;
				typeMoney = "gp";
			}
		}
		public class Sheep : AbstractTradeGoods{
			public Sheep(){
				name = "Sheep";

				text = "";
				cost = 2;
				typeMoney = "gp";
			}
		}
		public class Cinnamon : AbstractTradeGoods{
			public Cinnamon(){
				name = "Cinnamon";

				text = "";
				cost = 2;
				typeMoney = "gp";
			}
		}
		public class Pepper : AbstractTradeGoods{
			public Pepper(){
				name = "Pepper";

				text = "";
				cost = 2;
				typeMoney = "gp";
			}
		}
		public class Cloves : AbstractTradeGoods{
			public Cloves(){
				name = "Cloves";

				text = "";
				cost = 3;
				typeMoney = "gp";
			}
		}
		public class Pig : AbstractTradeGoods{
			public Pig(){
				name = "Pig";

				text = "";
				cost = 3;
				typeMoney = "gp";
			}
		}
		public class Silver : AbstractTradeGoods{
			public Silver(){
				name = "Silver";

				text = "";
				cost = 5;
				typeMoney = "gp";
			}
		}
		public class Linen : AbstractTradeGoods{
			public Linen(){
				name = "Linen";

				text = "";
				cost = 5;
				typeMoney = "gp";
			}
		}public class Silk : AbstractTradeGoods{
			public Silk(){
				name = "Silk";

				text = "";
				cost = 10;
				typeMoney = "gp";
			}
		}public class Cow : AbstractTradeGoods{
			public Cow(){
				name = "Cow";

				text = "";
				cost = 10;
				typeMoney = "gp";
			}
		}
		public class Saffron : AbstractTradeGoods{
			public Saffron(){
				name = "Saffron";

				text = "";
				cost = 15;
				typeMoney = "gp";
			}
		}
		public class Ox : AbstractTradeGoods{
			public Ox(){
				name = "Ox";

				text = "";
				cost = 15;
				typeMoney = "gp";
			}
		}
		public class Gold : AbstractTradeGoods{
			public Gold(){
				name = "Gold";

				text = "";
				cost = 50;
				typeMoney = "gp";
			}
		}
		public class Platinum : AbstractTradeGoods{
			public Platinum(){
				name = "Platinum";

				text = "";
				cost = 500;
				typeMoney = "gp";
			}
		}





	}
}

