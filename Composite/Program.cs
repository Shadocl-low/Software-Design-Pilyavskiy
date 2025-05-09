using Composite.Enums;
using Composite;
using Composite.States;

var div = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);

var table = new LightElementNode("table", DisplayType.Block, ClosingType.Paired);
table.AddClass("data-table");

// Заголовок таблиці
var headerRow = new LightElementNode("tr", DisplayType.Block, ClosingType.Paired);

var th1 = new LightElementNode("th", DisplayType.Inline, ClosingType.Paired);
th1.AddChild(new LightTextNode("Name"));

var th2 = new LightElementNode("th", DisplayType.Inline, ClosingType.Paired);
th2.AddChild(new LightTextNode("Age"));

headerRow.AddChild(th1);
headerRow.AddChild(th2);
table.AddChild(headerRow);

// Рядок з даними
var dataRow = new LightElementNode("tr", DisplayType.Block, ClosingType.Paired);

var td1 = new LightElementNode("td", DisplayType.Inline, ClosingType.Paired);
td1.AddChild(new LightTextNode("Alice"));

var td2 = new LightElementNode("td", DisplayType.Inline, ClosingType.Paired);
td2.AddChild(new LightTextNode("30"));
td2.AddClass("age-td");

dataRow.AddChild(td1);
dataRow.AddChild(td2);
table.AddChild(dataRow);

// Ще один рядок
var dataRow2 = new LightElementNode("tr", DisplayType.Block, ClosingType.Paired);
var td3 = new LightElementNode("td", DisplayType.Inline, ClosingType.Paired);
td3.AddChild(new LightTextNode("Bob"));

var td4 = new LightElementNode("td", DisplayType.Inline, ClosingType.Paired);
td4.AddChild(new LightTextNode("25"));
td4.AddClass("age-td");

dataRow2.AddChild(td3);
dataRow2.AddChild(td4);
table.AddChild(dataRow2);

var a = new LightElementNode("a", DisplayType.Block, ClosingType.SelfClosing);
a.AddClass("active");

div.AddChild(table);
div.AddChild(a);

// Вивід
Console.WriteLine(div.OuterHTML());


// Випробовування стейтів
Console.WriteLine("\nState: ReadOnly");
div.SetReadOnlyState();
div.AddClass("container");
Console.WriteLine(div);

Console.WriteLine("\nState: Editable");
div.SetEditableState();
div.AddClass("container");
Console.WriteLine(div);
div.RemoveClass("container");

Console.WriteLine("\nState: Locked(Not Admin)");
div.SetLockedState(new User("Basic", "123"));
div.AddClass("container");
Console.WriteLine(div);

Console.WriteLine("\nState: Locked(As Admin)");
div.SetLockedState(new User("Admin", "SuperPassword"));
div.AddClass("container");
Console.WriteLine(div);