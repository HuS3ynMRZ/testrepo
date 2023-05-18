using System;

public class Class1 : Age
{
    public string name;
    public string position;

    public Class1(int age, string name, string position) : base(age)
    {
        this.name = name;
        this.position = position;
    }

    public string ShowInformation()
    {
        string info = "Name:" + name + "\n Position: "+ position;

        return info;
    }
}