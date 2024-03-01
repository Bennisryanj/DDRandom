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
        }
    }
}
