
using SourceControllSystem;
using SourceControllSystem.Composite;
using SourceControllSystem.Momento;
using SourceControllSystem.State;

#region
Branch b1 = new Branch();
Branch b2 = new Branch();
Document d1 = new Document();
Document d2 = new Document();
Folder f1 = new Folder();
Folder f2 = new Folder();
b1.AddChild(d1);
b1.AddChild(f1);
b1.AddChild(d1);
b2.AddChild(f2);
b2.AddChild(d2);

Branch h = (Branch)b1.CreateBranch();
Console.WriteLine(h.GetChildren());
#endregion


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

