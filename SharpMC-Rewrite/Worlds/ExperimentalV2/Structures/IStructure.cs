﻿using SharpMCRewrite.Blocks;

namespace SharpMCRewrite.Worlds.ExperimentalV2.Structures
{
	public class Structure
	{
		public virtual string Name
		{
			get { return null; }
		}

		public virtual Block[] Blocks
		{
			get { return null; }
		}

		public virtual int Height { get { return 0; } }

		public void Create(ChunkColumn chunk, int x, int y, int z)
		{
			if (chunk.GetBlock(x, y + Height, z) == 0)
			{
				foreach (var b in Blocks)
				{
					chunk.SetBlock(x + (int)b.Coordinates.X, y + (int)b.Coordinates.Y, z + (int)b.Coordinates.Z, b);
				}
			}
		}
	}
}