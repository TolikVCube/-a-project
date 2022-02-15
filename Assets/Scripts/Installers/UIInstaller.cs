using Score;
using UI;
using UnityEngine;

public sealed class UIInstaller : MonoBehaviour
{
    [SerializeField] private Canvas _canvasPrefab;
    [SerializeField] private ScorePanel _scorePanelPrefab;

    public GameUI Install(Scores.Score score, Camera camera)
    {
        return CreateUI(score, camera);
    }

    private GameUI CreateUI(Scores.Score score, Camera camera)
    {
        var canvas = Instantiate(_canvasPrefab);

        // var scorePanel = Instantiate(_scorePanelPrefab, canvas.transform);
        // scorePanel.Init(score);

        var ui = new GameUI(canvas, camera, score);
        return ui;
    }
}
