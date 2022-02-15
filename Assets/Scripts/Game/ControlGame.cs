using Interfaces;
using UI;

public class ControlGame : IClean
{
    private readonly Player _player;
    private readonly GameUI _ui;
    private readonly GameUpdates _gameUpdates;
    
    public ControlGame(Player player, GameUI ui, GameUpdates gameUpdates)
    {
        _player = player;
        _ui = ui;
        _gameUpdates = gameUpdates;
    }

    public void StartGame()
    {
        _gameUpdates.ResumeUpdate();
    }

    public void Clean()
    {
        
    }

}
