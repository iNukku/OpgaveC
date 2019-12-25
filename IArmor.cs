using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveC
{
    interface IArmor
    {
        int GetRemainingArmor();

        void ReduceArmor();
    }
}
