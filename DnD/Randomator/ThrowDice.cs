using System;

namespace DnD
{
	public static class ThrowDice
	{
		private static Random random = new Random();
		public static int ThrowOneDTwo(){
			return random.Next (1, 3);
		}
		public static int ThrowOneDThree(){
			return random.Next (1, 4);
		}
		public static int ThrowOneDFour(){
			return random.Next (1, 5);
		}
		public static int ThrowOneDSix(){
			return random.Next (1, 7);
		}
		public static int ThrowOneDEight(){
			return random.Next (1, 9);
		}
		public static int ThrowOneDTen(){
			return random.Next (1, 11);
		}
		public static int ThrowOneDTwelve(){
			return random.Next (1,13);
		}
		public static int ThrowOneDTwenty(){
			return random.Next (1, 21);
		}
        
        public static int ThrowDiceWithInsp(AbstractRaces abstractRace, int idStng)
        {
            int result;
            return 0;
            /*
            if (abstractRace.Inspiration > 0)
            {
                switch (idStng){
                    
                    case 1:
                        abstractRace.Inspiration--;
                        Console.WriteLine("Inspiration was used");
                        result = ThrowOneDTwenty() + ThrowOneDSix();
                        return result;
                        break;
                    case 2:
                        abstractRace.Inspiration--;
                        result = ThrowOneDTwenty();
                        break;
                        
                }
                
            }*/
         
            
        } 

        public static int ThrowDiceFromHealthDice(int heathDice){
            switch(heathDice){
            case 2:
              return random.Next (1, 3);
            case 3:
                return random.Next (1, 4);
            case 4:
                  return random.Next (1, 5);
            case 6:
                  return random.Next (1, 7);
            case 8:
                   return random.Next (1, 9);
            case 10:
                   return random.Next (1, 11);
            case 12:
                   return random.Next (1, 13);
            case 20:
                  return random.Next (1, 21);
            default:
                    return 0;
                    
            }

        }
    }
}

