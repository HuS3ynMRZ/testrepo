using System;

public class Class1 : AgeClass
{
	public string? name { get; set; }
	public string? profession { get; set; }

	public Class1(string name, string profession, int age)
	{
		this.age = age;
		this.name = name;
		this.profession = profession;
	}
}