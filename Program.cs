using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using CarContract;

namespace CarHost
{
    class Program
    {
        [ImportMany(typeof(ICarContract))]
        private IEnumerable<Lazy<ICarContract, ICarMetadata>> CarParts { get; set; }
       
        static void Main(string[] args)
        {
            new Program().Run();
        }
        void Run()
        {          
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            foreach (Lazy<ICarContract, ICarMetadata> car in CarParts)
            {
                Console.WriteLine("Name: " + car.Metadata.Name);
                Console.WriteLine("Price: " + car.Metadata.Price.ToString());
                Console.WriteLine("Color: " + car.Metadata.Color.ToString());
                foreach (AudioSystem audio in car.Metadata.Audio)
                    Console.WriteLine("Audio: " + audio);
                Console.WriteLine("");
            }
            // invokes the method of all imports
            foreach (Lazy<ICarContract> car in CarParts)
                Console.WriteLine(car.Value.StartEngine("Sebastian"));
            container.Dispose();
        }
    }
}
