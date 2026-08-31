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
            // ========================== Part B    theme  adventure game   ========================== //
            Console.WriteLine("\n====== ADVENTURE GAME PARTY STATUS  =====");
            string playerName    = "Halo";    // warrior player //
            char   partyRank   = 'E';
            int    haloLevel   = 1;
            int    playerMaxhp   = 200;
            float  playerAttackpower   = 5.5f;
            double baseSpeed     = 2.5;
            bool    isPlayer     = true;
            
            Console.WriteLine("=====  PLAYER STATUS : INITIAL =====");
            Console.WriteLine($"Name : {playerName}");
            Console.WriteLine($"Rank : {partyRank}");
            Console.WriteLine($"level : {haloLevel}");
            Console.WriteLine($"HP   : {playerMaxhp}");
            Console.WriteLine($"Attack Power : {playerAttackpower}");
            Console.WriteLine($"Base Speed : {baseSpeed}");
            Console.WriteLine($"Is Player : {isPlayer}");
            
            string Name = "Marlin";  //    Magic player //
            int    maxMana  = 350;
            double doubleMagicBaseSpeed = 3.5;
            double manaRegenRate = 1.5;
            float  manaMagicPower   =  10.2f;
            bool isMage = true;

            Console.WriteLine($"Name : {Name}"); 
            Console.WriteLine($"Max Mana : {maxMana}");
            Console.WriteLine($"Base Speed : {doubleMagicBaseSpeed}");
            Console.WriteLine($"Mana Regen Rate : {manaRegenRate}");
            Console.WriteLine($"Magic Power : {manaMagicPower}");
            Console.WriteLine($"Is Mage : {isMage}");

            string name = "goku";  //    Archer player //
            int    maxArrow  = 50;
            double archerBaseSpeed = 4.0;
            double arrowReloadrate = 1.0;
            float  archerAttackPower   =  8.0f;
            bool isArcher = true;

            Console.WriteLine($"Name : {name}"); 
            Console.WriteLine($"Max Arrows : {maxArrow}");
            Console.WriteLine($"Base Speed : {archerBaseSpeed}");
            Console.WriteLine($"Arrow Reload Rate : {arrowReloadrate}");
            Console.WriteLine($"Attack Power : {archerAttackPower}");
            Console.WriteLine($"Is Archer : {isArcher}");

            string name1 = "Luffy";  //    Healer player //
            int    maxHealth  = 300;
            double healerBaseSpeed = 2.0;
            double healthRegenRate = 1.5;
            float  healerAttackPower   =  6.0f;
            bool isHealer = true;

            Console.WriteLine($"Name : {name1}"); 
            Console.WriteLine($"Max Health : {maxHealth}");
            Console.WriteLine($"Base Speed : {healerBaseSpeed}");
            Console.WriteLine($"Health Regen Rate : {healthRegenRate}");
            Console.WriteLine($"Attack Power : {healerAttackPower}");
            Console.WriteLine($"Is Healer : {isHealer}");

            string  name2 = "Zoro";  // rogue player //
            int     maxStamina = 250;
            double rogueBaseSpeed = 3.0;
            double staminaRegenRate = 1.2;
            float  rogueAttackPower   =  7.5f;
            bool    isRogue = true;

            Console.WriteLine($"Name : {name2}"); 
            Console.WriteLine($"Max Stamina : {maxStamina}");
            Console.WriteLine($"Base Speed : {rogueBaseSpeed}");
            Console.WriteLine($"Stamina Regen Rate : {staminaRegenRate}");
            Console.WriteLine($"Attack Power : {rogueAttackPower}");
            Console.WriteLine($"Is Rogue : {isRogue}");

        }
    }
}
