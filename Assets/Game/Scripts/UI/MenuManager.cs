using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    Button versusAiStartMenuButton;
    Canvas mainMenuCanvas;
    Canvas vsAiMenuCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Start()
    {
        versusAiStartMenuButton = GameObject.Find("ReturnToMMButton").GetComponent<Button>();
        mainMenuCanvas = GameObject.Find("StartMenuCanvas").GetComponent<Canvas>();
        vsAiMenuCanvas = GameObject.Find("VersusAICanvas").GetComponent<Canvas>();
        versusAiStartMenuButton.onClick.AddListener(() => BackToMainMenu(vsAiMenuCanvas));
    }
    void BackToMainMenu(Canvas aCanvas)
    {
        mainMenuCanvas.enabled = true;
        aCanvas.enabled = false;
    }
}
