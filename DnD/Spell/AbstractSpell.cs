using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class AbstractSpell
    {
        private bool canUse;
        private bool isUse;

        private int count;
        private int lvl;

        private string name;
        private string spellText;

        private int damage;
        private string damageDice;

        public bool CanUse
        {
            get
            {
                return canUse;
            }

            set
            {
                canUse = value;
            }
        }

        public bool IsUse
        {
            get
            {
                return isUse;
            }

            set
            {
                isUse = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public int Lvl
        {
            get
            {
                return lvl;
            }

            set
            {
                lvl = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string SpellText
        {
            get
            {
                return spellText;
            }

            set
            {
                spellText = value;
            }
        }

        public int Damage
        {
            get
            {
                return damage;
            }

            set
            {
                damage = value;
            }
        }

        public string DamageDice
        {
            get
            {
                return damageDice;
            }

            set
            {
                damageDice = value;
            }
        }
    }
}
