using System;
using UnityEngine;

public class Cube : MonoBehaviour, ICollect
{
    public event Action<Cube> Collected;

    private bool _collected = false;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Cube collect))
        {
            // collect.CollectObject(collect);
        }
    }

    public void CollectObject(Cube cube)
    {
        print($"collected with {cube.name}");
        Collected?.Invoke(cube);   
    }
}
