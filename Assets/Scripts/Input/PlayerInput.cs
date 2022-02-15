using UnityEngine;

public class PlayerInput
{
    public float XPosition;

    private const string _xPosition = "Mouse X";
    
    public void Update(float deltaTime)
    {
        XPosition = Input.GetAxis(_xPosition);
    }
}
