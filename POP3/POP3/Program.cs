using System;
using Newtonsoft.Json;

namespace POP3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try {
				// Load the country collection
				Country.Load ();

				// Load the state collection
				State.Load ();
			} catch (FileDoesNotExist) {
				Console.WriteLine ("There is not a previous state");
			}


			// Check if there are no countries
			if (!(Country.getInstances ().Count > 0)) {
				Console.WriteLine ("We'll create country models now!");
				// Create example countries
				new Country ("Uruguay");
				new Country ("Argentina");
			 	new Country ("Brasil");

				Country.Save ();
			}

			// Check if there are no states
			if (!(State.getInstances ().Count > 0)) {
				Console.WriteLine ("We'll create some states models now!");
				// Create example states
				new State ("S1", Country.GetBy("Name", "Uruguay"));
				new State ("S2", Country.GetBy("Name", "Uruguay"));
				new State ("S3", Country.GetBy("Name", "Uruguay"));
				new State ("S4", Country.GetBy("Name", "Argentina"));

				State.Save ();
			}

			// Display the countries instances
			Console.WriteLine ("This are the created countries");
			foreach (Country i in Country.getInstances ()) {
				Console.WriteLine (i);
			}

			// Display the states instances
			Console.WriteLine ("This are the created states");
			foreach (State s in State.getInstances ()) {
				Console.WriteLine (s);
			}
		}
	}
}
