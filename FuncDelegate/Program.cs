
using System.Linq;

List<string> names = new() { "Enes", "Fatih", "Bilal", "Yusuf" };

//Func<string, bool> names = new Func<string, bool>(FindA);
Func<string, bool> func = new(FindA);

var result1 = names.Where(func);  // 1.Method
var result2 = names.Where(FindA); // 2.Method

var result3 = names.Where(x => x.Contains("a") || x.Contains("A")); // 3.Method
Console.WriteLine("Hello World!");

static bool FindA(string args)
{
	if (args.Contains("a") || args.Contains("A"))
	{
		return true;

	}
	else
	{
		return false;
	}
}