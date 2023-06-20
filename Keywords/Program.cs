// keywords of different languages are stored in an array;
// tags are also stored in an array;
// each keyword is tagged by a set of tags;
// use an jagged array for storing the tags for an item and write methods that provide the following functions:
// - print tags for each keyword
// - search for an tag 
// - change tags for the given keyword

using System.Security.Cryptography.X509Certificates;

Console.WriteLine();

string[] keywords = new string[] { "class", "record", "struct", "using", "virtual" };
string[] tags = new string[] { "C#", "Java", "polymorphism" };

Index[][] itemTags = new Index[][] { new Index[] { 0, 1 }, new Index[] { 1 }, new Index[]{ 0 }, new Index[] { 0 }, new Index[] { 0, 1, 2 } };

PrintAll(keywords, tags, itemTags);

static void PrintAll(string[] keywords, string[] tags, Index[][] itemTags)
{
    if (keywords==null)
    {
        throw new ArgumentNullException(nameof(keywords));
    }

    if (itemTags==null)
    {
        throw new ArgumentNullException (nameof(itemTags));
    }

    if (tags==null)
    {
        throw new ArgumentNullException (nameof(tags));
    }

    if (keywords.Length != itemTags.Length)
    {
        throw new ArgumentException($"keywords number and tagged nummber must be equal");
    }

    int n = keywords.Length;

    for(int i = 0; i < n; i++) 
    {
        Console.Write($"{keywords[i]}:" );
        for(int j=0; j < itemTags[i].Length; j++)
        {
            Console.Write($"{ tags[ itemTags[i][j] ],12}");
        }
        Console.WriteLine();
    }
}