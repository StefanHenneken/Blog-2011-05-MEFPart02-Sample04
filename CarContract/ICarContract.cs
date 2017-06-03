using System;

namespace CarContract
{
    public interface ICarContract
    {
        string StartEngine(string name);
    }

    public enum CarColor
    {
        Unkown,
        Black,
        Red,
        Blue,
        White
    }

    public enum AudioSystem
    {
        Without,
        Radio,
        CD,
        MP3
    }
}
