using System;

public interface IUpdate
{
    event Action<IUpdate> UpdateRemoveRequested;
    void GameUpdate(float deltaTime);
}