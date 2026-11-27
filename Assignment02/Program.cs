/*
- Student ID : 1690701543
- Name       : ภูสิทธิ์ บุญเซ่ง
- Section    : 129B
- No.        :  24
- Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string MaterialName = "Gold";
            const double SmeltRate = 0.1500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 1000.0;


            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--     Welcome to the Forge      --");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(@"       
                         .      
                     .......    
              .......      ...  
            .   .  .......    .#
            ..    .        ....#
            .. .     ........ .#
             .. . ..........##  
               .....###        
                ..##   ");


            Console.WriteLine();

            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");


            Console.Write("=> Choose Menu: ");
            bool isMenuValid = char.TryParse(Console.ReadLine(), out char menuChoice);

            Console.Write("=> How much would you like: ");
            bool isAmountValid = double.TryParse(Console.ReadLine(), out double amount);


            if (isAmountValid && amount > 0 && amount <= MaxBatch)
            {
                if (isMenuValid && (menuChoice == 'S' || menuChoice == 's'))
                {
                    double TotalIngot = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {TotalIngot:F2} {MaterialName} Ingot");
                }
                else if (isMenuValid && (menuChoice == 'B' || menuChoice == 'b'))
                {
                    double TotalOre = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {TotalOre:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Error: Invalid menu choice. Please enter 'S' or 'B'.");
                }
            }
            else
            {
                Console.WriteLine($"Error: Invalid amount. Must be greater than 0 and not exceed {MaxBatch}.");
            }
        }
    }
}