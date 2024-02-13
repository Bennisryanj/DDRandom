using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Character;
using Combat;
using DDDungeon;


namespace DDRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Dungeon dungeon = new Dungeon();
            dungeon.Start();
            // Character1 test = new Character1("test", 10, 10, 10, 10, 10, 10, 10, false);

            // Character1 enemy = new Character1("enemy", 10, 10, 10, 10, 10, 10, 10, true);

            // Combat1 combat = new Combat1();

            // combat.Fight(test, enemy);


        }
    }
}
