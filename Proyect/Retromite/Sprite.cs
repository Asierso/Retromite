using System;
using System.Collections.Generic;
using System.Threading;
namespace Retromite
{
	public class Sprite
	{
		public static void CreateSprite(int posX,int posY,List<string> texture,bool pixelArt = false,ConsoleColor color = ConsoleColor.White)
		{
			ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            Console.SetCursorPosition(posX,posY);
            int arraided = 0;
			foreach(string pixelGroup in texture)
			{
				
				foreach (char pixelAlone in pixelGroup) 
				{
					if(pixelArt == true)
					{
						Console.BackgroundColor = color;
						Console.ForegroundColor = color;
					}
					else
					{
						Console.ForegroundColor = color;
					}
					if(char.IsWhiteSpace(pixelAlone) && pixelArt == true)
					{
						Console.BackgroundColor = oldBgColor;
					}
					Console.Write(pixelAlone.ToString());
					Console.BackgroundColor = oldBgColor;
					Console.ForegroundColor = oldFgColor;
				}
				Console.WriteLine("");
				arraided++;
				Console.SetCursorPosition(posX,posY + arraided);

			}
		}
		/**/
	}
}
