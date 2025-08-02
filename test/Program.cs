using PointsBet_Backend_Online_Code_Test;

string[] items = { "item 1", "item 2", "item 3", "another item", "item 5" };
string result = StringFormatter.ToCommaSeparatedList(items, "\"");

Console.WriteLine(result);
