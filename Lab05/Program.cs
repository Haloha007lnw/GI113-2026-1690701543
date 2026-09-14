/*
* Student ID : 1690701543
* Name       : ภูสิทธิ์ บุญเซ่ง
* Section    : 129B
* No.        :  NA
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==>> GAME TITLE ,, ==");
            Console.WriteLine("Hero VS Monster -- Calculate Damage");

            Console.Write("Hero HP: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);


            Console.Write("\nmonster HP: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            // check for valid input


            bool heroinputVailld = heroHpOk && heroAtkOk && heroDefOk;
            bool monsterinputVailld = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"Hero stats valid: {heroinputVailld}");
            Console.WriteLine($"Monster stats valid: {monsterinputVailld}");
            Console.WriteLine($"[HERO]          HP: {heroHp}, ATK: {heroAtk}, DEF; {heroDef}");
            Console.WriteLine($"[MONSTER]       HP: {monHp}, ATK: {monAtk}, DEF; {monDef}");


            // Hero drinks potion before the fight (compund assignemt: +=)
            int potionHeal = 14;                     // heroHp = Herohp + potionHeal = 114,  //hero += potionHeal; =114
            heroHp += potionHeal;
            Console.WriteLine($"\nHero drinks a potion, healing {potionHeal} Hp, Hero HP is: {heroHp}");

            int normalDamage = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"Normal attack deals: {normalDamage} DMG");

            int powerDamage = Math.Max(0, (heroAtk * 2) - monDef);
            Console.WriteLine($"Power attack deals: {powerDamage} DMG");

            int counterDamge = Math.Max(0, (monAtk - heroDef));
            Console.WriteLine($"Conunter attack deals: {counterDamge} DMG");

            Random randomSomethings = new Random();
            int roll = randomSomethings.Next(1, 101);     //สุ่ม 1-100 หรือค่าอื่นๆ ต้อง +1 เสมอ
            bool isCrit = roll <= 10;
            int critDamage = normalDamage + Convert.ToInt32(isCrit);
            Console.WriteLine($"crit Damage roll: {roll} (crit?: {isCrit})");
            Console.WriteLine($"If critical, normal attack would deal : {critDamage} DMG ");
             
        }

    }
}
   

