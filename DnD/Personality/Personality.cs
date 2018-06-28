using System;
namespace DnD.Personality
{
    public abstract class Personality
    {
        private string personalityName;
        private string personalityText;
        private string personalityTrait, ideal, bond, flaw;

        public Personality ()
        {


        }

        public string PersonalityName {
            get {
                return personalityName;
            }

            set {
                personalityName = value;
            }
        }

        public string PersonalityText {
            get {
                return personalityText;
            }

            set {
                personalityText = value;
            }
        }

        protected abstract void AddPersonalityBonus ();

    }
}
