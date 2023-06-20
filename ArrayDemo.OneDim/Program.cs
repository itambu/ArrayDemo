// item names are stored in an array. Implement methods that provide the following actions
// print all items
// print last item
// search an item by name

internal class Program
{
    private static void Main(string[] args)
    {
        //const int num = 4;
        string[] names = new string[] { "iron", "sneak", "table", "pencil" };
        PrintAll(names);
        PrintLast(names);
        Console.WriteLine(ContainItem(names, "table1"));
    }

    static void PrintAll(string[] names)
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
    }

    static void PrintLast(string[] names)
    {
        //Console.WriteLine(names[names.Length - 1]);
        Index index = ^1;
        Console.WriteLine(names[index]);
    }

    static bool ContainItem(string[] names, string n)
    {
        return Array.IndexOf(names, n) != -1;
    }
}