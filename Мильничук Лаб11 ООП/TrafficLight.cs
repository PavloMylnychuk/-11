namespace TrafficLightSimulation
{
    using System;
    using System.Collections.Generic;

    public class TrafficLight
    {
        private string[] signals = { "Red", "Green", "Yellow" };
        private int currentIndex;

        public TrafficLight(string initialSignal)
        {
            currentIndex = Array.IndexOf(signals, initialSignal);
        }

        public void Change()
        {
            currentIndex = (currentIndex + 1) % signals.Length;
        }

        public string CurrentSignal => signals[currentIndex];
    }
}
