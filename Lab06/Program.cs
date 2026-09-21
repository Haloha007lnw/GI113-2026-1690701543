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

                int heroHp = 100;
                int monHp = 100;
                int heroAtk = 100;
                int potionHeal = 50;

                Console.WriteLine("GAME TITLE: ADVENTURES OF BRIAN");
                Console.WriteLine(">===HERO BRAIN ENCOUNTER A MONSTER<===");
                Console.WriteLine("ACTION 1: ATTACK");
                Console.WriteLine("ACTION 2: DRINK HP POTION");

                Console.Write("CHOOSE YOUR ACTION (1-2): ");
                bool isInputValid = int.TryParse(Console.ReadLine(), out int choice);

                if (isInputValid == false || choice < 1 || choice > 2)
                {
                    Console.WriteLine("Invalid Input. Please enter action between 1 and 2 ");
                }
                else if (choice == 1)
                {
                    monHp -= heroAtk;
                    if (monHp <= 0)
                    {
                        Console.WriteLine($"Hero attacked the monster!!! with {heroAtk} DMG, Monster is defeated!:");
                    }
                    else
                    {
                        Console.WriteLine($"Hero attacked the monster!!! with {heroAtk} DMG, Monster now have {monHp} Hp left!");
                    }

                }
                else if (choice == 2)
                {
                    heroHp += potionHeal;
                    Console.WriteLine($"Hero drank a potion, Hero Hp {heroHp} Potions");
                }




            }

                
            }
        }

   
    









