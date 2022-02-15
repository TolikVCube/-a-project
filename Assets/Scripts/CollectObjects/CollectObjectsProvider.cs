using System;
using System.Collections.Generic;
using UnityEngine;

public class CollectObjectsProvider : IUpdate
{
    public event Action<IUpdate> UpdateRemoveRequested;
    
    private readonly Cube _playerCube;
    private readonly PlayerInput _playerInput;
    private readonly Transform _cubesHolder;
    
    private readonly List<Cube> _collectedObjects;
    
    public CollectObjectsProvider(Cube playerCube, PlayerInput playerInput, Transform cubesHolder)
    {
        _playerCube = playerCube;
        _playerInput = playerInput;
        _cubesHolder = cubesHolder;

        // collect.Collected += CollectOnCollected;
        _playerCube.Collected += CollectObjects;
        _collectedObjects= new List<Cube> {_playerCube};
    }

    private void CollectOnCollected(Cube obj)
    {
        throw new NotImplementedException();
    }

    private void CollectObjects(Cube cube)
    {
        // _collectedObjects.Add(cube);
        // cube.transform.SetParent(_cubesHolder);
        Debug.Log($"parent setted {cube.name}");
        
        
    }

    public void GameUpdate(float deltaTime)
    {
        var movement = GetMovement();
        movement.Move(deltaTime);
    }

    private Movement GetMovement()
    {
        return new Movement(_playerInput, _cubesHolder);
    }
}