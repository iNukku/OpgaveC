using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveC
{
    interface IUnit
    {
        int FireWeapon();

        void TakeDamage();

        void PickUpWeapon();

        void DropWeapon();
    }
}
