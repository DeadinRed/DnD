using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Dynamic;
using System.IO;
using System.Reflection;


namespace DnD
{
    class MainClass
    {
        private const int V = 1;

        public static void Main (string [] args)
        {
            //AbstractClass abstractClass = new AbstractClass ();
            //Dragonborn model = new Dragonborn ("Sashka1", 80, "Man", 80, 63, new AbstractClass () { });

            //dynamic leather = new Armor.Leather ();
            //dynamic club = new Weapon.Club ();
            //model.addToHeroItems (leather.ClassName, leather);

            //Console.WriteLine (model.ToString() + " " + model.ToString2());
            int [] o;
            int [] k =  { 1, 2, 3 };
            Array array = k;
            o = (int [])k.Clone ();
            Console.WriteLine (o.ToString() + " " + array.ToString());

        }

    }
       
}
