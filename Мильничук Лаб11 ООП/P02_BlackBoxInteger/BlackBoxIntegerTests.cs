namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var blackBox = Activator.CreateInstance(typeof(BlackBoxInteger), true);
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var split = command.Split('_');
                var methodName = split[0];
                var value = int.Parse(split[1]);

                var methodInfo = typeof(BlackBoxInteger).GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
                methodInfo.Invoke(blackBox, new object[] { value });

                var getValueMethod = typeof(BlackBoxInteger).GetMethod("GetValue", BindingFlags.NonPublic | BindingFlags.Instance);
                Console.WriteLine(getValueMethod.Invoke(blackBox, null));
            }
        }
    }
}
