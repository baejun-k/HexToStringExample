using System.Security.Cryptography;

using Utils;


class Program
{
	static public int Main(string[] args)
	{
		string test = "FFccCF";

		if ( HexToString.ConvertTo(test, out byte[]? result))
		{
			for(int i = 0; i < result?.Length; ++i)
			{
				Console.WriteLine($"{result?[i]}");
			}

		}

		return 0;
	}
}