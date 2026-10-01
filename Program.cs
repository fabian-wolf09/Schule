public class Person
{
	public string name;
	public int age;

	public Person()
    {
        name = "";
        age = 0;
    }
    public void print()
    {
        Console.WriteLine("Type: " + this.GetType().Name);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}
public class Schüler : Person
{
}
public class Lehrer : Person
{
}
public class Klasse
{
    public List<Person> members;
    public string name;

    public Klasse()
    {
        members = new List<Person>();
        name = "";
    }
    public void print()
    {
        Console.WriteLine("Class: " + name);
        foreach (var member in members)
        {
            member.print();
            Console.WriteLine();
        }
    }
    public Lehrer addTeacher(string name, int age)
    {
        Lehrer teacher = new Lehrer();
        teacher.name = name;
        teacher.age = age;
        members.Add(teacher);
        return teacher;
    }
    public Schüler addStudent(string name, int age)
    {
        Schüler student = new Schüler();
        student.name = name;
        student.age = age;
        members.Add(student);
        return student;
    }

}
public class Abteilung
{
    public List<Klasse> classes;
    public string name;

    public Abteilung()
    {
        name = "";
        classes = new List<Klasse>();
    }
    public void print()
    {
        Console.WriteLine("Department: " + name);
        foreach (var klasse in classes)
        {
            klasse.print();
            Console.WriteLine();
        }
    }
    public Klasse addClass(string name)
    {
        Klasse klasse = new Klasse();
        klasse.name = name;
        classes.Add(klasse);
        return klasse;
    }
}
public class Schule
{
    public List<Abteilung> departments;
    public string name;

    public Schule()
    {
        name = "";
        departments = new List<Abteilung>();
    }
    public void listall()
    {
        foreach (var department in departments)
        {
            department.print();
            Console.WriteLine();
        }
    }
    public Abteilung addDepartment(string name)
    {
        Abteilung department = new Abteilung();
        department.name = name;
        departments.Add(department);
        return department;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Schule school = new Schule();
        Abteilung department = school.addDepartment("Informatik");
        Klasse klasse = department.addClass("4BHITS");
        Lehrer teacher = klasse.addTeacher("Bliem", 1000);
        Schüler student = klasse.addStudent("Fabian", 17);
        Schüler student2 = klasse.addStudent("Laurin", 17);
        Schüler student3 = klasse.addStudent("Manuel", 18);
        school.listall();
    }
}