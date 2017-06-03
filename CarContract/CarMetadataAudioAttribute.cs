using System;
using System.ComponentModel.Composition;

namespace CarContract
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=true)]
    public class CarMetadataAudioAttribute : Attribute
    {
        public CarMetadataAudioAttribute(AudioSystem audio)
        {
            this.Audio = audio;
        }
        public AudioSystem Audio { get; set; }
    }
}
