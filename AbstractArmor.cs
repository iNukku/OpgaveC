using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveC
{
    public enum Armortype {light, medium, heavy };

    class AbstractArmor : IArmor
    {
        private Armortype type;


        public Armortype Type
        {
            get { return type; }
        }

        public int GetRemainingArmor()
        {
            throw new NotImplementedException();
        }

        public void ReduceArmor()
        {
            throw new NotImplementedException();
        }
    }
}
