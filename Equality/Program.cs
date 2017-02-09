using System;

namespace Equality {
	class Program {
		static void Main(string[] args) {
			Food banana = new Food("banana");
			Food banana2 = new Food("banana");
			Food chocolate = new Food("chocolate");

			//IEquatable Demo

			//.Equals(banana2) is string's implementation of IEquatable<string>
			Console.WriteLine(banana.Equals(banana2));

			/* 2 methods 
				1. The overridden object.Equals method
				2. The strongly typed overload is int's implementation of IEquatable<int>
			*/
			int three = 3;
			three.Equals(3);
		}
	}
}
