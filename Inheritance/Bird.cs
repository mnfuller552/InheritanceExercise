using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}

		// Create a class Bird
		// give this class 4 members that are specific to Bird
		// Set this class to inherit from your Animal Class

		public string BeakSize { get; set; }
		public string EggColor { get; set; }
		public bool Migrates { get; set; }
		public bool CanFly { get; set; }

    }
}

