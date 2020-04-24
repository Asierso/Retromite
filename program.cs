using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace retromite
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            //draw.drawSymetricCube(2,2,3,ConsoleColor.Red);
            //draw.drawCube(10,1,12,4,ConsoleColor.Red);
            //draw.drawTextureCube(1,1,4,3,new List<ConsoleColor>{ConsoleColor.Red,ConsoleColor.Yellow,ConsoleColor.Green,ConsoleColor.Blue,ConsoleColor.Red,ConsoleColor.Blue});
            //draw.drawTextureSymetricCube(1,1,3,new List<ConsoleColor>{ConsoleColor.Green,ConsoleColor.Yellow,ConsoleColor.Yellow,ConsoleColor.Green,ConsoleColor.Yellow,ConsoleColor.Yellow,ConsoleColor.Green,ConsoleColor.Yellow,ConsoleColor.Yellow});
            //window.textWindow(1,3,5,"Hello World","Im a example text");
            //Not works => window.buttonWindow(60,3,3,"H","W",new List<string>{"B1","B2"});
                while(true)
                {
                    player.useMold("plane",new List<string>{"=|>","  |===|>","     ==========>","  |===|>","=|>"},false);
                    //draw.drawCube(1,15,Console.WindowWidth,20,ConsoleColor.Red);
                    Console.CursorVisible  = false;
                }
            
            
        }
    }
}