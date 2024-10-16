public class WeaponAttributeTest
{
    public static void Main()
    {
        var type = typeof(Weapon);
        var attributes = type.GetCustomAttributes(typeof(WeaponAttribute), false);

        foreach (WeaponAttribute attribute in attributes)
        {
            Console.WriteLine($"Author: {attribute.Author}");
            Console.WriteLine($"Revision: {attribute.Revision}");
            Console.WriteLine($"Class description: {attribute.Description}");
            Console.WriteLine($"Reviewers: {string.Join(", ", attribute.Reviewers)}");
        }
    }
}
