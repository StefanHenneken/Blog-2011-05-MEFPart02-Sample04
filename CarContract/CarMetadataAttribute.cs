using System;
using System.ComponentModel.Composition;

namespace CarContract
{
    [MetadataAttribute]
    public class CarMetadataAttribute : Attribute
    {
        public string Name { get; set; }
        public CarColor Color { get; set; }
        public uint Price { get; set; }
    }
}
