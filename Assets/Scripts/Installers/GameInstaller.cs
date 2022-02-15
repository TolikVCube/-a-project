using System.Collections.Generic;
using Interfaces;
using UnityEngine;

public class GameInstaller : MonoBehaviour
{
    [Header("PrefabsToSpawn")]
    [SerializeField] private Camera _cameraPrefab;
    [SerializeField] private GameUpdates _gameUpdatesPrefab;
    [SerializeField] private Cube _cubePrefab;
    [SerializeField] private Transform _cubesHolder;

    [SerializeField] private Transform _cubesHolderPosition;
    
    [Header("Installers")]
    [SerializeField] private UIInstaller _uiInstaller;
    [SerializeField] private EnvironmentInstaller _environmentInstaller;
    
    private void Start() => InstallGame();
    
    private void InstallGame()
    {
        Scores.Score score = new Scores.Score();
        PlayerInput playerInput = new PlayerInput();
        
        var mainCamera = Instantiate(_cameraPrefab);
        var cubesHolder = Instantiate(_cubesHolder);
        cubesHolder.transform.position = _cubesHolderPosition.transform.position;
        
        var ui = _uiInstaller.Install(score, mainCamera);
        var level = _environmentInstaller.Install();
        var player = CreatePlayer(playerInput);
        var playerCube = CreatePlayerCube(cubesHolder);

        var cleanUp = new List<IClean>()
        {
            player, ui, level, _gameUpdatesPrefab
        };
        
        var collectObjectsProvider = new CollectObjectsProvider(playerCube, playerInput, cubesHolder);
        var game = new ControlGame(player, ui, _gameUpdatesPrefab);
        game.StartGame();
        _gameUpdatesPrefab.AddToUpdateList(collectObjectsProvider);
        
        DisableInstaller();
    }

    private void DisableInstaller()
    {
        Destroy(this.gameObject);
    }

    private Player CreatePlayer(PlayerInput playerInput)
    {
        var player = new Player(playerInput);

        _gameUpdatesPrefab.AddToUpdateList(player);
        return player;
    }

    private Cube CreatePlayerCube(Transform transform)
    {
        var playerCube = Instantiate(_cubePrefab, transform);

        return playerCube;
    }
}