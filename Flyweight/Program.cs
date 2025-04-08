using Flyweight;

string[] lines = File.ReadAllLines("pg1513.txt");

var lightweight = new LightWeightHTML();

LightElementNode html;
long memoryBefore;
long memoryAfter;

memoryBefore = GC.GetTotalMemory(true);
html = GenerateHtmlTree(lines);
memoryAfter = GC.GetTotalMemory(true);
long usedMemoryWithoutCache = memoryAfter - memoryBefore;


memoryBefore = GC.GetTotalMemory(true);
html = GenerateHtmlTreeWithCache(lines, lightweight);
memoryAfter = GC.GetTotalMemory(true);
long usedMemoryWithCache = memoryAfter - memoryBefore;

Console.WriteLine(html.OuterHTML);

Console.WriteLine($"Number of elements in memory: {lightweight.GetCacheCount()}");

Console.WriteLine($"With {usedMemoryWithCache}");
Console.WriteLine($"Without {usedMemoryWithoutCache}");

Console.ReadKey();

static LightElementNode GenerateHtmlTree(string[] lines)
{
    var html = new LightElementNode("html");

    string previousLine = "";
    foreach (var line in lines)
    {
        LightElementNode node;
        if (string.IsNullOrWhiteSpace(line))
        {
            node = new LightElementNode("p");
        }
        else if (line.Length < 20)
        {
            node = new LightElementNode("h2");
        }
        else if (line.StartsWith(" "))
        {
            node = new LightElementNode("blockquote");
        }
        else if (string.IsNullOrWhiteSpace(previousLine))
        {
            node = new LightElementNode("h1");
        }
        else
        {
            node = new LightElementNode("p");
        }
        node.AddChild(new LightTextNode(line));

        html.AddChild(node);
        previousLine = line;
    }

    return html;
}
static LightElementNode GenerateHtmlTreeWithCache(string[] lines, LightWeightHTML lightweight)
{
    var html = new LightElementNode(lightweight.GetTagType("html"));

    string previousLine = "";
    foreach (var line in lines)
    {
        LightElementNode node;
        if (string.IsNullOrWhiteSpace(line))
            node = lightweight.CreateElement("p", line);
        else if (line.Length < 20)
            node = lightweight.CreateElement("h2", line);
        else if (line.StartsWith(" "))
            node = lightweight.CreateElement("blockquote", line);
        else if (string.IsNullOrWhiteSpace(previousLine))
            node = lightweight.CreateElement("h1", line);
        else
            node = lightweight.CreateElement("p", line);

        html.AddChild(node);
        previousLine = line;
    }

    return html;
}