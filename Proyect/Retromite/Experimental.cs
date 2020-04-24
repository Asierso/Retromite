using System;
using System.Collections.Generic;
using System.Threading;
namespace Retromite
{
	public class Experimental //Class of functions that not are prepared to use
	{
		//Functions that are able for all
		#region Public
		public static void CreateAnimateSprite(List<int> posXVariant,List<int> posYVariant,List<string> texture,int frameTime,bool pixelArt = false,ConsoleColor color = ConsoleColor.White)
		{
			ConsoleColor oldBgColor = Console.BackgroundColor;
            ConsoleColor oldFgColor = Console.ForegroundColor;
            for(int i=0;i<posXVariant.ToArray().Length;i++) //Position Array Runner
            {
            	Console.SetCursorPosition(posXVariant[i],posYVariant[i]);
				foreach(string pixelGroup in texture) //Drawer Method
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
							Console.BackgroundColor = color;
						}
						Console.Write(pixelAlone.ToString());
						Console.BackgroundColor = oldBgColor;
						Console.ForegroundColor = oldFgColor;
					}
					Console.WriteLine("");
					Thread.Sleep(frameTime);
				}
				Console.ForegroundColor = oldBgColor;
				Console.SetCursorPosition(posXVariant[i],posYVariant[i]);
				foreach(string pixelGroup in texture) //Clear Method
				{
					Console.Write(pixelGroup.ToString());
				}
				Console.BackgroundColor = oldBgColor;
				Console.ForegroundColor = oldFgColor;
            }
            
		}
		#endregion Public
		//Functions that are only for developer
		#region Blocked
		#endregion Blocked
	}
}
