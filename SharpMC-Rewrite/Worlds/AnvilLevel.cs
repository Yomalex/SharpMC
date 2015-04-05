﻿using SharpMCRewrite.Classes;

namespace SharpMCRewrite.Worlds
{
	internal class AnvilLevel : Level
	{
		public AnvilLevel(string worldname)
		{
			Difficulty = 0;
			LVLName = worldname;
			LevelType = LVLType.Default;
			Generator = new AnvilWorldProvider(worldname);
			ConsoleFunctions.WriteInfoLine("Level Type: Anvil");
		}
	}
}