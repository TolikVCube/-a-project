using UnityEngine;

public class Movement
{
    private readonly PlayerInput _playerInput;
    private readonly Transform _cubesHolder;
    
    public Movement(PlayerInput playerInput, Transform cubesHolder)
    {
        _playerInput = playerInput;
        _cubesHolder = cubesHolder;
    }

    public void Move(float deltaTime)
    {
        _cubesHolder.transform.position += new Vector3(_playerInput.XPosition, 0f, 1f) * deltaTime;
    }
}
