using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaAndBoss
{
    /*
     * 1. Add class Boss to the project.
        2. Define private field name of type string.
        3. Define private field mafia of type Mafia.
        4. Implement a constructor that initialize the private fields.
        5. Implement public method GiveOrder which calls method
        PeformSecreteActivity on the Mafia object.
        6. Override method ToString to convert a Boss to a string. 
        */

    class Boss
    {
        private string _name;
        private Mafia _mafia;

        public Boss(
            string name,
            Mafia mafia
        )
        {
            _name = name;
            _mafia = mafia;
        }

        public void GiveOrder()
        {
            _mafia.PerformSecretActivity();
        }

        public override string ToString()
        {
            return $"Boss name: {_name}";
        }
    }
}
