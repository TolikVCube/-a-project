using System.Collections.Generic;
using UnityEngine;

public class ObjectsCollector
{
    public List<Cube> CollectedObjects { get; }

    private readonly Transform _cubesHolder;

    public ObjectsCollector(Transform cubesHolder, Cube playerCube)
    {
        _cubesHolder = cubesHolder;
        
        CollectedObjects = new List<Cube>() {playerCube};
    }

    public void CollectObjects(Cube cube)
    {
        CollectedObjects.Add(cube);
        SetObjectParent(cube);

    }

    private void SetObjectParent(Cube cube)
    {
        cube.transform.SetParent(_cubesHolder);
    }
}