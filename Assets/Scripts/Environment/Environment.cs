using Interfaces;
using UnityEngine;

public class Environment : IClean
{
    private readonly Light _light;

    public Environment(Light light)
    {
        _light = light;
    }

    public void Clean()
    {
        
    }
}