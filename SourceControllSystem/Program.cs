
using SourceControllSystem;
using SourceControllSystem.Composite;
using SourceControllSystem.Momento;
using SourceControllSystem.State;

Console.WriteLine("Hello, World!");

Branch a = new Branch();
Branch b = new Branch();
Branch c = new Branch();
Branch d = new Branch();
MyFile f = new MyFile();
Folder f2 = new Folder();
a.AddChild(b);
a.AddChild(c);
a.AddChild(f);
b.AddChild(d);
b.AddChild(f2);
Console.WriteLine(a.Execute());

#region
Originator originator = new Originator("Super-duper-super-puper-super.");
CareTaker caretaker = new CareTaker(originator);

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

Console.WriteLine();
caretaker.ShowHistory();

Console.WriteLine("\nClient: Now, let's rollback!\n");
caretaker.Undo();

Console.WriteLine("\n\nClient: Once more!\n");
caretaker.Undo();

Console.WriteLine();
#endregion

