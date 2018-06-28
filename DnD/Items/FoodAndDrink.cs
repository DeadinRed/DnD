using System;

namespace DnD
{
	public static class FoodAndDrink 
	{
	
		public class AbstractFood : AItem{
			protected  string name;
			protected  string type = "Food";

			protected bool isUse = false;
			protected bool canUse = true;
			protected int count = 1;
			protected string text = "";

			protected  int cost = 5;
			protected  string typeMoney = "sp";
			protected  int weight;

            public AbstractFood(){
                ClassName = "FoodAndDrink";
            }

            public override string ToString ()
			{
				return string.Format ("[AbstractFood: name={0}, type={1}, isUse={2}, canUse={3}, count={4}, text={5}, cost={6}, typeMoney={7}, weight={8}]", name, type, isUse, canUse, count, text, cost, typeMoney, weight);
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

			public    int Weight {
				get {
					return this.weight;
				}
			}

			public    int Cost {
				get {
					return this.cost;
				}
			}

			public  string Type {
				get {
					return this.type;
				}
			}
				
			public   string Name {
				get {
					return this.name;
				}
			}

			public   string TypeMoney {
				get {
					return this.typeMoney;
				}
			}

		}

		public class AbstractDrink : AItem{
			protected  string name;
			protected  string type = "Drink";

			protected bool isUse = false;
			protected bool canUse = true;
			protected int count = 1;
			protected string text = "";

			protected  int cost;
			protected  string typeMoney = "sp";
			protected  int weight;

            public AbstractDrink ()
            {
                ClassName = "FoodAndDrink";
            }

            public override string ToString ()
			{
				return string.Format ("[AbstractDrink: name={0}, type={1}, isUse={2}, canUse={3}, count={4}, text={5}, cost={6}, typeMoneyMoney={7}, weight={8}]", name, type, isUse, canUse, count, text, cost, typeMoney, weight);
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

			public  string Type {
				get {
					return this.type;
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

			public   string TypeMoney {
				get {
					return this.typeMoney;
				}
			}

		}

		public class Wine : AbstractDrink{

            public Wine(string status) : base(){

				switch(status){
					case "Pitcher":
						name = "Common Wine";
						cost = 2;
						typeMoney = "sp";
						break;
					case "Bottle":
						name = "Fine Wine";
						cost = 10;
						typeMoney = "gp";
						break;
					default:
						Console.WriteLine(new Exception("status is not true"));
						break;
				}
			}


		}

		public class Ale : AbstractDrink{
            public Ale(string status): base (){
				name = "Ale";
				switch(status){
					case "Gallon":
						
						cost = 2;
						typeMoney = "sp";
						weight = 4;
						text = "Gallon of Ale";
						break;
					case "Mug":
						text = "Mug of Ale";
						cost = 4;
						typeMoney = "cp";
						break;
					default:
						Console.WriteLine(new Exception("status is not true"));
						break;
				}
			}
		}

		public class Bread : AbstractFood{
            public Bread() : base (){
				name = "Bread";
				cost = 2;
				typeMoney = "cp";
			}
		}
		public class Cheese : AbstractFood{
            public Cheese(): base (){
				name = "Cheese";
				cost = 1;
				typeMoney = "cp";
			}
		}
		public class Meat : AbstractFood{
            public Meat(): base (){
				name = "Meat";
				cost = 3;
				typeMoney = "sp";
			}
		}


		public class Banquet : AItem{
			protected int cost;
			protected string typeMoney, name;
			public Banquet(){
				name = "Banquet";
				cost = 10;
				typeMoney = "gp";
			}
		}
		public class InnStay : AItem{
			protected int cost;
			protected string typeMoney, name;
			public InnStay(string tmp){
				name = tmp;
				switch(tmp){
					case "Squalid":
						cost = 7;
						typeMoney = "cp";
					break;
					case "Poor":
						cost = 1;
						typeMoney = "sp";
					break;
					case "Modest":
						cost = 5;
						typeMoney = "sp";
					break;
					case "Comfortable":
						cost = 8;
						typeMoney = "sp";
					break;
					case "Wealthy":
						cost = 2;
						typeMoney = "gp";
					break;
					case "Aristocratic":
						cost = 4;
						typeMoney = "gp";
					break;
					default:
					Console.WriteLine(new Exception("type is not true"));
					break;
				}
			}
		}
		public class Meals : AItem{
			protected int cost;
			protected string typeMoney, name;
			public Meals(string tmp){
				name = tmp;
				switch(tmp){
					case "Squalid": 
						cost = 3;
						typeMoney = "cp";
						break;
					case "Poor":
						cost = 6;
						typeMoney = "cp";
						break;
					case "Modest":
						cost = 3;
						typeMoney = "sp";
						break;
					case "Comfortable":
						cost = 5;
						typeMoney = "sp";
						break;
					case "Wealthy":
						cost = 8;
						typeMoney = "gp";
						break;
					case "Aristocratic":
						cost = 2;
						typeMoney = "gp";
						break;
					default:
						Console.WriteLine(new Exception("type is not true"));
						break;
				}
			}
		}

		public class LifestyleExpence : AItem {
			protected int cost;
			protected string typeMoney, name;
			public LifestyleExpence(string tmp){
				name = tmp;
				switch(tmp){
					case "Wretched": 
						cost = 0;
						break;
					case "Squalid": 
						cost = 1;
						typeMoney = "sp";
						break;
					case "Poor":
						cost = 2;
						typeMoney = "sp";
						break;
					case "Modest":
						cost = 1;
						typeMoney = "gp";
						break;
					case "Comfortable":
						cost = 2;
						typeMoney = "gp";
						break;
					case "Wealthy":
						cost = 4;
						typeMoney = "gp";
						break;
					case "Aristocratic":
						cost = 10;
						typeMoney = "gp";
						break;
					default:
						Console.WriteLine(new Exception("LifestyleExpence is not true"));
						break;
				}
			}
		}
	}
}

