using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup canvasGroup; 
    private static bool isGameStarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        // show the start screen small change
        CanvasGroupDisplayer.Show(canvasGroup);
    }

    public void OnStartButtonClicked()
    {
        // hide start screen
        // remember oh wait we started
        CanvasGroupDisplayer.Hide(canvasGroup);
        isGameStarted = true;
        
    }

    public static bool IsGameStarted()
    {
        return isGameStarted;
    }
}
