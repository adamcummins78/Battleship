using System;

public abstract class Ship
{
    public string Name { get; set; }
    public int Width { get; set; }
    public int Hits { get; set; }
    public bool IsSunk
    {
        get
        {
            return Hits >= Width;
        }
    }
}
