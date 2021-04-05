using System;

namespace 0405
{
	class CommandLineArgsApp
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < args.Length; ++i)
			Console.WriteLine("Argument[{0}] = {1}", i, args[i]);
		}
	}
}