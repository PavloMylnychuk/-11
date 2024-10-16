namespace TrafficLightSimulation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var signals = Console.ReadLine().Split(' ');
            var n = int.Parse(Console.ReadLine());
            var trafficLights = new List<TrafficLight>();

            foreach (var signal in signals)
            {
                trafficLights.Add(new TrafficLight(signal));
            }

            for (int i = 0; i < n; i++)
            {
                foreach (var light in trafficLights)
                {
                    light.Change();
                    Console.WriteLine(light.CurrentSignal);
                }
            }
        }
    }
}
