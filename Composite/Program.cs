using Composite.Enums;
using Composite;
using Composite.States;

var div = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);

var table = new LightElementNode("table", DisplayType.Block, ClosingType.Paired);
DomEditor.AddClass(table, "data-table");

// Заголовок таблиці
var headerRow = new LightElementNode("tr", DisplayType.Block, ClosingType.Paired);

var th1 = new LightElementNode("th", DisplayType.Inline, ClosingType.Paired);
DomEditor.AppendChild(th1, new LightTextNode("Name"));

var th2 = new LightElementNode("th", DisplayType.Inline, ClosingType.Paired);
DomEditor.AppendChild(th2, new LightTextNode("Age"));

DomEditor.AppendChild(headerRow, th1);
DomEditor.AppendChild(headerRow, th2);
DomEditor.AppendChild(table, headerRow);

// Рядок з даними
var dataRow = new LightElementNode("tr", DisplayType.Block, ClosingType.Paired);

var td1 = new LightElementNode("td", DisplayType.Inline, ClosingType.Paired);
DomEditor.AppendChild(td1, new LightTextNode("Alice"));

var td2 = new LightElementNode("td", DisplayType.Inline, ClosingType.Paired);
DomEditor.AppendChild(td2, new LightTextNode("30"));
DomEditor.AddClass(td2, "age-td");

DomEditor.AppendChild(dataRow, td1);
DomEditor.AppendChild(dataRow, td2);
DomEditor.AppendChild(table, dataRow);

// Ще один рядок
var dataRow2 = new LightElementNode("tr", DisplayType.Block, ClosingType.Paired);
var td3 = new LightElementNode("td", DisplayType.Inline, ClosingType.Paired);
DomEditor.AppendChild(td3, new LightTextNode("Bob"));

var td4 = new LightElementNode("td", DisplayType.Inline, ClosingType.Paired);
DomEditor.AppendChild(td4, new LightTextNode("25"));
DomEditor.AddClass(td4, "age-td");

DomEditor.AppendChild(dataRow2, td3);
DomEditor.AppendChild(dataRow2, td4);
DomEditor.AppendChild(table, dataRow2);

var a = new LightElementNode("a", DisplayType.Block, ClosingType.SelfClosing);
DomEditor.AddClass(a, "active");

DomEditor.AppendChild(div, table);
DomEditor.AppendChild(div, a);

// Перевірка роботи нових методів DOM
var container = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
DomEditor.AppendChild(div, container);

var span = new LightElementNode("span", DisplayType.Inline, ClosingType.Paired);
DomEditor.AppendChild(container, span);

var p = new LightElementNode("p", DisplayType.Inline, ClosingType.Paired);
var p_text = new LightTextNode("Regular Text");
DomEditor.AppendChild(p, p_text);

DomEditor.AppendChild(span, p);

DomEditor.ReplaceText(p_text, "Uncommon Text");

DomEditor.ReplaceText(p_text, "NEW Text");

DomEditor.Undo();

DomEditor.RemoveNode(span);

DomEditor.Undo();

DomEditor.RemoveNode(p);
DomEditor.RemoveNode(container);

DomEditor.Undo();
DomEditor.Undo();

DomEditor.ReplaceText(p_text, "NEW Text");

// Вивід
Console.WriteLine(div.OuterHTML());

// Ітерування
Console.WriteLine("\nBFS:");
foreach (var node in div)
{
    Console.WriteLine(node);
}

Console.WriteLine("\nDFS:");
div.SetDepthFirstEnumerator();

foreach (var node in div)
{
    Console.WriteLine(node);
}


// Команди
CommandsHistory.ShowHistoryConsole();

DomEditor.ShowAllTagsInDomConsole();


// Випробовування стейтів
Console.WriteLine("\nState: ReadOnly");
div.SetReadOnlyState();
DomEditor.AddClass(div, "container");
Console.WriteLine(div);

Console.WriteLine("\nState: Editable");
div.SetEditableState();
DomEditor.AddClass(div, "container");
Console.WriteLine(div);
div.RemoveClass("container");

Console.WriteLine("\nState: Locked(Not Admin)");
div.SetLockedState(new User("Basic", "123"));
DomEditor.AddClass(div, "container");
Console.WriteLine(div);

Console.WriteLine("\nState: Locked(As Admin)");
div.SetLockedState(new User("Admin", "SuperPassword"));
DomEditor.AddClass(div, "container");
Console.WriteLine(div);