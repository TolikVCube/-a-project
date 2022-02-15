using System;
using Interfaces;

public class Player : IClean, IUpdate
{
    public event Action<IUpdate> UpdateRemoveRequested;
    public event Action Died;
    
    private PlayerInput _playerInput;

    public Player(PlayerInput playerInput)
    {
        _playerInput = playerInput;
    }
    
    public void Clean()
    {
        
    }
    
    public void GameUpdate(float deltaTime)
    {
        _playerInput.Update(deltaTime);
    }
}
