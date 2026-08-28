/*
 * Student ID : 1690701543 
 * Name       : Lab02 
 * Section    : 129B
 * No.        : NA
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            
            Console.WriteLine("===== Boss STATUS : INITIAL =====");
            Console.WriteLine($"Name : {bossName}");
            Console.WriteLine($"Rank : {rank}");
            Console.WriteLine($"Level : {level}");
            Console.WriteLine($"HP   : {currentHp}  / {maxHp}");
            Console.WriteLine($"Attack Power : {attackPower}");
            Console.WriteLine($"Crit Multiplier : {critMultiplier}");
            Console.WriteLine($"Is Boss : {isBoss}");
            Console.WriteLine();
            
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent  : {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes damage of 60 damage.");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine("===== Boss STATUS : AFTER DAMAGE =====");
            Console.WriteLine($"HP:   {currentHp}  / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent  : {hpPercent}%");

            // Wait for user input before closing the console window
            string wizardName = "Chisa";
             
        }
    }
}
