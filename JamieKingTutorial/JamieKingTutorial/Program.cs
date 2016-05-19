using System;

class Person
{
    public string FirstName;
    public string LastName;
    public string MiddleName;
    public int Age;
}

class MyClass
{
    static void Main()
    {
        Person myTeacher = new Person
        {
            FirstName = "Jamie",
            LastName = "King",
            MiddleName = "Blobber",
            Age = 55
        };
        Person aStudent = new Person
        {
            FirstName = "Chris",
            LastName = "Bobson",
        };

        Console.WriteLine(myTeacher.FirstName);
        Console.WriteLine(myTeacher.Age);
    }
}