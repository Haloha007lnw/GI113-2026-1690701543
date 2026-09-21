/*
* Student ID : 1690701543
* Name       : ภูสิทธิ์ บุญเซ่ง
* Section    : 129B
* No.        :  NA
* Course     : GI113 Computer Programming (GI)
*/
using System;
using System.ComponentModel.Design;
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        int lives = 0;
            //        if (lives <= 0)
            //         {
            //             Console.WriteLine("Game Over!");
            //        }
            //           else
            //           {
            //               Console.WriteLine("Continue to play!");
            //            }

            //            Console.WriteLine("continue to run! ");

            //int level = 10;

            //      bool hasKey = true;

            //      Console.WriteLine("Your level is (1-99): ");
            //      bool ok = int.TryParse(Console.ReadLine(), out int level);

            //     if (!ok || level < 1 || level > 99)
            //     {
            //         Console.WriteLine("Invalid Level Input");
            //      }
            //     else if (level >= 10 && hasKey)
            //      {
            //        Console.WriteLine("Boss floor unlocked!.");
            //     }
            //   else if (level >= 5)
            //   {
            // if (hasKey == true)
            //      {
            //           Console.WriteLine("The door opens!");
            //      }
            //      else
            //      {
            //          Console.WriteLine("Locked. Find a key.");
            //      }

            //int heroHp = 100;
            //int monHp = 100;
            //int heroAtk = 100;
            //int potionHeal = 50;

            //Console.WriteLine("GAME TITLE: ADVENTURES OF BRIAN");
            //Console.WriteLine(">===HERO BRAIN ENCOUNTER A MONSTER<===");
            //Console.WriteLine("ACTION 1: ATTACK");
            //Console.WriteLine("ACTION 2: DRINK HP POTION");

            //Console.Write("CHOOSE YOUR ACTION (1-2): ");
            //bool isInputValid = int.TryParse(Console.ReadLine(), out int choice);

            //if (isInputValid == false || choice < 1 || choice > 2)
            //{
            //    Console.WriteLine("Invalid Input. Please enter action between 1 and 2 ");
            //}
            //else if (choice == 1)
            //{
            //    monHp -= heroAtk;
            //    if (monHp <= 0)
            //    {
            //        Console.WriteLine($"Hero attacked the monster!!! with {heroAtk} DMG, Monster is defeated!:");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Hero attacked the monster!!! with {heroAtk} DMG, Monster now have {monHp} Hp left!");
            //    }

            //}
            //else if (choice == 2)
            //{
            //    heroHp += potionHeal;
            //    Console.WriteLine($"Hero drank a potion, Hero Hp {heroHp} Potions");
            //}
           
            Console.WriteLine("===== Fear & Hunger =====");
            Console.WriteLine("You try to run away from a hungry Wolf, but you fail.");
            Console.WriteLine("===== Your Turn =====");
            Console.WriteLine("ACTION 1:    Attack leg wolf ");
            Console.WriteLine("ACTION 2:    Guard your body ");
            Console.WriteLine("ACTION 3:        Run         ");

            Console.Write("CHOOSE YOUR ACTION (1-3): ");
            bool isFear = int.TryParse(Console.ReadLine(), out int choice);

            if (!isFear || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid action! Your mind breaks from the creeping terror.");
                Console.WriteLine("You stand frozen stiff as the wolf attacks. Game over  You have become part of the dungeon.");
            }
            else if (choice == 1)
            {
                Console.WriteLine("Your focus  attack on his his leg! ");
                Console.WriteLine("Critical hit! leg wolf Sever the wolf leg Succeed  Stuns the wolf. ");
            }
            else if (choice == 2)
            {
                Console.WriteLine("You raise your arms and brace for impact.");
                Console.WriteLine("You block the attack, but you are suffering from bleeding in your right arm.");
            }
            else if (choice == 3)
            {
                Console.WriteLine("You turn your back and sprint into the darkness.");
                Console.WriteLine("Coin flip: FAILS... you can't escape.  Wolf bites you. Next turn.");
            }
                











            }


        }
        }

   
    









