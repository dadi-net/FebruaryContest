using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';

		static void Main(string[] args)
		{
			int width = 30;
			int height = 15;         
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					Console.BackgroundColor = ConsoleColor.Yellow;
					if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
						Console.BackgroundColor = ConsoleColor.Green;
			    		Console.Write(block);
				}
				Console.WriteLine();
			}

			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}
	}
}
