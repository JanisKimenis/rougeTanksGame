
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;



public class CameraCanvasConnector : MonoBehaviour
{
    GameObject UIManager;
    Canvas mainMenuCanvas;


    void Start()
    {
    UIManager = GameObject.Find("UIManager");
    mainMenuCanvas = UIManager.GameObject.Find("StartMenuCanvas");
    mainMenuCanvas.worldCamera = Camera.main;
    mainMenuCanvas.planeDistance = 5f;
    }

}
