using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaAndBoss
{
    /*
      * 1. Add class Mafia to the project.
        2. Define private field name of type string.
        3. Define private field business of type string.
        4. Define private field boss of type Boss.
        5. Implement a constructor that initialize the private fields.
        6. Implement public method SetBoss which assigns a Boss to a mafia.
        7. Implement public method PeformSecretActivity which displays a string to
        the console window.
        8. Override method ToString to convert a Mafia to a string. 
        */
    class Mafia
    {
        private string _name;
        private string _business;
        private Boss _boss;

        public Mafia(
            string name,
            string business
        )
        {
            _name = name;
            _business = business;
            _boss = null;
        }

        public void SetBoss(Boss newBoss)
        {
            _boss = newBoss;
        }

        public void PerformSecretActivity()
        {
            Console.WriteLine($"Mafia named: {_name} performed secret activity: {_business}");
        }

        public override string ToString()
        {
            return $"Mafia: {_name}\n" +
                $"Business: {_business}";
        }
    }
}
