using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveC
{
    public enum Armortype {light, medium, heavy, none };

    public abstract class AbstractArmor : IArmor
    {
        private Armortype type;
        private int armor;

        public Armortype Type
        {
            get { return type; }
        }

        public int GetRemainingArmor()
        {
            return armor;
        }

        public void ReduceArmor(int damageAmount)
        {
            armor = armor - damageAmount;
        }

        public AbstractArmor(Armortype typeOfArmor)
        {
            type = typeOfArmor;

            switch (typeOfArmor)
            {
                case Armortype.light:
                    armor = 100;
                    break;
                case Armortype.medium:
                    armor = 150;
                    break;
                case Armortype.heavy:
                    armor = 200;
                    break;
                default:
                    armor = 0;
                    break;
            }
        }
    }
}
