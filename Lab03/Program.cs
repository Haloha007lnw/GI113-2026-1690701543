/*
  * Student ID : 1690701543
  * Name       : ภูสิทธิ์ บุญเซ่ง
  * Section    : 129B
  * No.        :  NA
   * Course     : GI113 Computer Programming (GI)
   */
namespace Lab03
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const int Maxlevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine($"===== KIRIN  SAVE CONVERSATION =====");
            Console.WriteLine($"Boss Name: {bossName}" +

                $"\nRank: {rank}" +
                $"\nLevel: {level}" +
                $"\nMax HP: {maxHp}" +
                $"\nCurrent HP: {currentHp}" +
                $"\nAttack Power: {attackPower}" +
                $"\nCritical Multiplier: {critMultiplier}" +
                $"\nIs Boss: {isBoss}");
            

            Console.WriteLine(("\n----- implicit conversion Hp an double -----"));
            double currentHpDouble = currentHp;
            Console.WriteLine($"Current HP (double): {currentHpDouble}");
            
            Console.WriteLine(("\n----- Exact HP Percent (no integer truncation -----"));
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine(($"HP Percent (exact): {hpPercentExact}%"));

            Console.WriteLine(("\n----- Explicit Cast: Attack Power -> Display Int -----"));
             int attack_display = (int)attackPower;
            Console.WriteLine($"Attack Power (int): {attack_display}");

            Console.WriteLine(("\n----- Cast vs Convert: Crit Multiplier -----"));
            int  critdisplay = (int)critMultiplier;
            int  critconvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (cast): {critdisplay}");
            Console.WriteLine($"Crit Multiplier (convert): {critconvert}");






        }
    }
}
