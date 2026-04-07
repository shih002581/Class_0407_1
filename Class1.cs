using System;
using System.Net.Http.Headers;

class Person
{
    public string name;
    public int Id;
    public Person(int id, string name)
    {
        Id = id;
        this.name = name;
    }
    public string GetName()
    {
        return "Person的Name";
    }

    public virtual string Info()
    {
        return "Person的info";
    }
}
class Student : Person
{
    private int Score;
    public Student(int id, string name, int score) : base(id, name)
    {
        Score = score;
    }
    public new string GetName()
    {
        return "學生的Name";
    }
    public override string Info()
    {
        return "學生的Info";
    }
}
