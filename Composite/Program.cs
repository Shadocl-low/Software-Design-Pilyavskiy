using Composite.Enums;
using Composite;

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
a.AddClass("colorful");

var section = new LightElementNode("section", DisplayType.Block, ClosingType.Paired);
section.AddChild(new LightTextNode("New section"));

div.AddChild(table);
div.AddChild(a);

// Вивід
Console.WriteLine(div.OuterHTML());

var clickLogger = new ConsoleLogListener("[ClickLogger]");
var addClassLogger = new ConsoleLogListener("[AddClassLogger]");
var addChildLogger = new ConsoleLogListener("[AddChildLogger]");

// Підпис на події
div.AddEventListner(EventType.Click, clickLogger);
div.AddEventListner(EventType.AddClass, addClassLogger);
div.AddEventListner(EventType.AddChild, addChildLogger);

a.AddEventListner(EventType.AddClass, addClassLogger);
a.AddEventListner(EventType.Click, clickLogger);

section.AddEventListner(EventType.AddClass, addClassLogger);

// Робота з тегами
div.ClickTag();

a.ClickTag();
a.ClickTag();

div.AddChild(section);

section.AddClass("section-view");

// Вивід
Console.WriteLine(div.OuterHTML());