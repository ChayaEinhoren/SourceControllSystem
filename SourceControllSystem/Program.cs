
using SourceControllSystem;
using SourceControllSystem.Composite;
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



