public class Person
{
	public string name;
	public int age;

	public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void print()
    {
        Console.WriteLine("Type: " + this.GetType().Name);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}


public class Schüler : Person {
    public Schüler(string name, int age) : base(name, age)
    {
    }
}
public class Lehrer : Person {
    public Lehrer(string name, int age) : base(name, age)
    {
    }
}


public class Klasse
{
    public List<Schüler> students;
    public Lehrer kv;
    public string name;

    public Klasse(string name)
    {
        this.name = name;
        students = new List<Schüler>();
        kv = null;
    }

    public void print()
    {
        Console.WriteLine("Class: " + name);
        Console.WriteLine("KV: " + kv.name);
        foreach (var student in students)
        {
            Console.WriteLine("Schüler: ");
            student.print();
            Console.WriteLine();
        }
    }

    public void addKV(Lehrer kv)
    {
        this.kv = kv;
    }
    
    public void addStudent(Schüler student)
    {
        students.Add(student);
    }

}
public class Abteilung
{
    public List<Klasse> classes;
    public string name;

    public Abteilung(string name)
    {
        this.name = name;
        classes = new List<Klasse>();
    }

    public void print()
    {
        Console.WriteLine("Department: " + name);
        foreach (var cls in classes)
        {
            cls.print();
            Console.WriteLine();
        }
    }
    public void addClass(Klasse cls)
    {
        classes.Add(cls);
    }
}
public class Schule
{
    public List<Abteilung> departments;
    public string name;

    public Schule(string name)
    {
        this.name = name;
        departments = new List<Abteilung>();
    }
    public void listall()
    {
        foreach (var department in departments)
        {
            department.print();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    public Abteilung addDepartment(Abteilung department)
    {
        departments.Add(department);
        return department;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Abteilung department1 = new Abteilung("Informatik");

        Klasse class1 = new Klasse("4BHITS");
        Lehrer teacher = new Lehrer("Herr Einböck", 40);

        department1.addClass(class1);
        class1.addKV(teacher);
        
        department1.print();
    }
}