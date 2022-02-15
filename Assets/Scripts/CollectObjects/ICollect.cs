using System;

public interface ICollect
{
    public event Action<Cube> Collected;
    void CollectObject(Cube cube);
}