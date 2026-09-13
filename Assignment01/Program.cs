/*
* Student ID : 1690701543
* Name       : ภูสิทธิ์ บุญเซ่ง
* Section    : 129B
* No.        :  NA
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Dex  = "PokemonDex: ";
            
            Console.WriteLine("        .   .  ..            .               ..                                .  ....:==++++++=:....                                                                ");
            Console.WriteLine("               ::..::-:...:::---.          .           .....   .....      ...=*******#*+*%#######=++=:.                                                              ");                                       
            Console.WriteLine("   ......--.:::::++*#**********#***#*=..             ... ..=########*.  .########=.-######***=..   ...-*#.                .                                          ");      //ยาวมาก ผมกะจะย่อกว่านี้ 
            Console.WriteLine("   .::..::-**#*********#++**#******#**#####=.          .=*##############+::-*########*##*#=+++++*########.      .:+********##########+===-...                 "); 
            Console.WriteLine("        ..=##**********#***********#########++=++**************###########***########################=...-*########+:.....-+*********##############=.       ");           //เเต่มันดูไม่เหมือน kyogre เท่าไหร่//
            Console.WriteLine("            ....-===+++#%%%%#*=++*#######*##**#****#############*########################%*##########################*****##+:..                       "); 
            Console.WriteLine("                    ..==+*#**+**####+=::::::::::*################*#######*=--%##--##=...           ..:+######%*+=...                                    ");                                                
            Console.WriteLine("                 .==##########*:::::::::::::-*##+:::::*############*####--=*#*.....:--=--:............                             .                    ");             
            Console.WriteLine("              .++#####################*#################################***###***######**######****+++******:::::::=.           ..                    "); 
            Console.WriteLine("      .     ...+*#########*%%+*@#**###*######**#++*#####%##############**#################**#################*-:-:....         .                        ");                  
            Console.WriteLine("         ..      ..:--:::::::::::::::::::::::-==++==:..    ..#%*##########*+***###****++#########**########=:::::::::-.                                "); 
            Console.WriteLine("                        ....::-------:-::::--.               .:#%#################**#####****#**##########=::::::::::-.                                "); 
            Console.WriteLine("    .                            ...  .. ... .          .       .:+%%###############+##########***####*==+.......::::.                                 "); 
            Console.WriteLine("                            .                                  ..   ..-*%##**#########+*##########*-:::::::::-...      .                               ");             
            Console.WriteLine("                         ..           .                      .                         ..     .          ...-+**+::::::::::::....:::.:--..             ");                     

            var pokeName  =     "Kyogre";
            var typeElement =   'W';
            int specialAttack = 150;
            float catchRate = 0.04f;
            double weight = 352.8;
            bool isLegendaryPokemon = true;
            
            Console.WriteLine($"+---------------------------------------------------+");
            Console.WriteLine($"|    POKEDEX  POKEMON STATUS                        |");
            Console.WriteLine($"+---------------------------------------------------+"); 
            Console.WriteLine($"pokeName  : {pokeName}");
            Console.WriteLine($"Type Element : {typeElement}");
            Console.WriteLine($"Sp.Attack : {specialAttack}");
            Console.WriteLine($"Catch Rate : {catchRate}");
            Console.WriteLine($"Weight : {weight}");
            Console.WriteLine($"IsLegendary : {isLegendaryPokemon}");
            Console.WriteLine();
            
            Double specialAttackDouble = specialAttack;  
            Console.WriteLine($"specialAttackDouble as double (implicit)  : {specialAttackDouble}");

            int weightTruncated = (int)weight;
            int weightRounded = Convert.ToInt32(weight);
            Console.WriteLine($"WeightTruncated (truncated)  : {weightTruncated}");
            Console.WriteLine($"WeightRounded   (converted)  : {weightRounded}");    











        }
    }
}
