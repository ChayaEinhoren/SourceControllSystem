
using SourceControllSystem;
using SourceControllSystem.Composite;
using SourceControllSystem.Momento;
using SourceControllSystem.Observer;
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

User u1 = new User();
Draft dr1 = new Draft();
Task1 t1 = new Task1();
Console.WriteLine(t1.GetState());
dr1.ChangeState(t1);
u1.Update(t1);



#region
Originator originator = new Originator("Chaya Einhoren && Racheli Weiner");
CareTaker caretaker = new CareTaker(originator);

caretaker.Backup();
originator.DoSomething();

Console.WriteLine();
caretaker.ShowHistory();

Console.WriteLine("\nlet's rollback!\n");
caretaker.Undo();

Console.WriteLine("\n\nand again!\n");
caretaker.Undo();

Console.WriteLine();
#endregion

