using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    Button ReturnToMMButton;
    Canvas mainMenuCanvas;
    Canvas vsAiMenuCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Start()
    {
        ReturnToMMButton = GameObject.Find("ReturnToMMButton").GetComponent<Button>();
        mainMenuCanvas = GameObject.Find("StartMenuCanvas").GetComponent<Canvas>();
        vsAiMenuCanvas = GameObject.Find("VersusAICanvas").GetComponent<Canvas>();
        ReturnToMMButton.onClick.AddListener(() => SwitchCanvas(vsAiMenuCanvas, mainMenuCanvas));
    }
    void SwitchCanvas(Canvas aCanvas, Canvas bCanvas)
    {
        aCanvas.enabled = false;
        bCanvas.enabled = true;
    }
}
