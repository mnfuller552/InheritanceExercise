using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

		public bool LaysEggs { get; set; }
		public string LivesIn { get; set; }
		public bool IsPoisinous { get; set; }
		public string TailSize { get; set; }



    }
}

