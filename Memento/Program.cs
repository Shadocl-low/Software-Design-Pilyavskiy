using Memento;

TextEditor editor = new TextEditor("Welcome.");

editor.ShowContent();

editor.Write("Hello");
editor.ShowContent();

await Task.Delay(1000);

editor.Write("World!");
editor.ShowContent();

await Task.Delay(4000);

editor.Write("I like potato.");
editor.ShowContent();

editor.ShowHistory();

editor.Undo();
editor.ShowContent();

editor.Undo();
editor.ShowContent();

editor.Undo();
editor.ShowContent();

editor.Write("New text.");
editor.ShowContent();

editor.Erase();
editor.ShowContent();

editor.Undo();
editor.ShowContent();