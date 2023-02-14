using System.Diagnostics;

class Program
{
	static public int Main(string[] args)
	{
		if (1 != args.Length)
		{
			Console.Error.WriteLine("input one file name");
			return 1;
		}
		if (false == File.Exists(args[0]))
		{
			Console.Error.WriteLine($"can not found file : \"{args[0]}\"");
			return 2;
		}

		Debug.WriteLine($"input file name : {args[0]}");

		var bytes = File.ReadAllBytes(args[0]);
		Console.Write(Convert.ToHexString(bytes));

		return 0;
	}
}