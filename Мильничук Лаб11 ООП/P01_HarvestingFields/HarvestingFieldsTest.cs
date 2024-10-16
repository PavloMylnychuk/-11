namespace P01_HarvestingFields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            HarvestingFields fields = new HarvestingFields();

            string command;
            while ((command = Console.ReadLine()) != "HARVEST")
            {
                Type type = typeof(HarvestingFields);
                FieldInfo[] fieldInfo = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);

                foreach (var field in fieldInfo)
                {
                    if ((command == "private" && field.IsPrivate) ||
                        (command == "protected" && field.IsFamily) ||
                        (command == "public" && field.IsPublic) ||
                        (command == "all"))
                    {
                        Console.WriteLine($"{(field.IsPublic ? "public" : field.IsFamily ? "protected" : "private")} {field.FieldType.Name} {field.Name}");
                    }
                }
            }
        }
    }
}
