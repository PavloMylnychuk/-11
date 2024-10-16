using System;

[AttributeUsage(AttributeTargets.Class)]
public class WeaponAttribute : Attribute
{
    public string Author { get; }
    public int Revision { get; }
    public string Description { get; }
    public string[] Reviewers { get; }

    public WeaponAttribute(string author, int revision, string description, params string[] reviewers)
    {
        Author = author;
        Revision = revision;
        Description = description;
        Reviewers = reviewers;
    }
}

[Weapon("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Petro", "Stefan")]
public class Weapon
{
    // Поля та методи для зброї
}
