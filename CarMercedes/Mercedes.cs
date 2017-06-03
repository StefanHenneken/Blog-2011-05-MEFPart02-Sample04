using System;
using System.ComponentModel.Composition;
using CarContract;

namespace CarMercedes
{
    [CarMetadata(Name="Mercedes", Color=CarColor.Blue, Price=48000)]
    [CarMetadataAudio(AudioSystem.Radio)]
    [Export(typeof(ICarContract))]
    public class Mercedes : ICarContract
    {
        private Mercedes()
        {
            Console.WriteLine("Mercedes constructor.");
        }
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the Mercedes.", name);
        }
    }
}
