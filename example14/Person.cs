


class Person
{
    public string name = "Undefined";
    public int age;
    public Person() :  this("Неизвестно")
    { }
    public Person(string name ) : this(name, 18)
    { }
    public Person(string name, int age) 
    {
        this.name = name;
        this.age = age;
    }
    public void Print()
    {
        Console.WriteLine($"Person: {name}  Age: {age}");
    }
}