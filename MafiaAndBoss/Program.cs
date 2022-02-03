using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaAndBoss
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Code page: {Console.Out.Encoding.CodePage}");
            Console.WriteLine($"Encoding name: {Console.Out.Encoding.EncodingName}");

            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1250);

            Console.WriteLine($"Code page: {Console.Out.Encoding.CodePage}");
            Console.WriteLine($"Encoding name: {Console.Out.Encoding.EncodingName}");

            //1. Create a Mafia object mafia.
            Mafia mafia = new Mafia("Cosa Nostra", "Dealing drugs");

            //2. Create a Boss object boss.
            //3. Link mafia to boss.
            Boss boss = new Boss("Vito Corleone", mafia);

            //4. Display object mafia to the console window.
            Console.WriteLine(mafia);

            //5. Display object boss to the console window.
            Console.WriteLine(boss);

            //6. Invoke method GiveOrder on object boss (better: on the object boss refers to). 
            boss.GiveOrder();
        }
    }
}
