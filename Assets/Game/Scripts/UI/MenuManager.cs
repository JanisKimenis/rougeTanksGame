using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{   


    //Main/first menu
    GameObject mainMenuCanvasObject;
    Canvas mainMenuCanvas;
    GameObject BGPanelGameObject;
    GameObject BackButtonGameObject;
    Button BackButton;
    GameObject PlayButtonGameObject;
    Button PlayButton;
    GameObject VersusAIButtonGameObject;
    Button VersusAIButton;
    GameObject VersusFriendsButtonGameObject;
    Button VersusFriendsButton;
    GameObject StoryModeGameObject;
    GameObject WIPOverlayGameObject;
    GameObject SettingsButtonGameObject;
    Button SettingsButton;
    GameObject ExitButtonGameObject;
    Button ExitButton;

    //Settings Overlay
    GameObject SettingsOverlay;
    GameObject SettingsExitButtonGameObject;
    Button SettingsExitButton;

    //Versus AI Menu
    GameObject VersusAICanvasGameObject;
    Canvas VSAIMenuCanvas;
    GameObject ReturnToMMButtonGameObject;
    Button ReturnToMMButton;
    GameObject EasyDifficultyButtonGameObject;
    Button EasyDifficultyButton;
    GameObject MediumDifficultyButtonGameObject;
    Button MediumDifficultyButton;
    GameObject HardDifficultyButtonGameObject;
    Button HardDifficultyButton;
    GameObject PlayerBattleBotType1ButtonGameObject;
    Button PlayerBattleBotType1Button;
    GameObject PlayerBattleBotType2ButtonGameObject;
    Button PlayerBattleBotType2Button;
    GameObject PlayerBattleBotType3ButtonGameObject;
    Button PlayerBattleBotType3Button;
    GameObject PlayerBattleBotType4ButtonGameObject;
    Button PlayerBattleBotType4Button;
    GameObject StartBattleButtonGameObject;
    Button StartBattleButton;

    void Start()
    {
        //Main/First menu
        mainMenuCanvasObject = GameObject.Find("StartMenuCanvas"); 
        mainMenuCanvas = mainMenuCanvasObject.GetComponent<Canvas>();

        BGPanelGameObject = mainMenuCanvasObject.transform.Find("BGPanel").gameObject;
        BackButtonGameObject = BGPanelGameObject.transform.Find("BackButton").gameObject;
        BackButton = BackButtonGameObject.GetComponent<Button>();
        PlayButtonGameObject = BGPanelGameObject.transform.Find("PlayButton").gameObject;
        PlayButton = PlayButtonGameObject.GetComponent<Button>();
        VersusAIButtonGameObject = BGPanelGameObject.transform.Find("VersusAIButton").gameObject;
        VersusAIButton = VersusAIButtonGameObject.GetComponent<Button>();
        WIPOverlayGameObject = BGPanelGameObject.transform.Find("WIPPanel").gameObject;
        StoryModeGameObject = BGPanelGameObject.transform.Find("StoryModeButton").gameObject;
        SettingsButtonGameObject = BGPanelGameObject.transform.Find("SettingsButton").gameObject;
        ExitButtonGameObject = BGPanelGameObject.transform.Find("ExitButton").gameObject;
        ExitButton = ExitButtonGameObject.GetComponent<Button>();
        VersusFriendsButtonGameObject = BGPanelGameObject.transform.Find("VersusFriendsButton").gameObject;
        VersusFriendsButton = VersusFriendsButtonGameObject.GetComponent<Button>();
        SettingsButton = SettingsButtonGameObject.GetComponent<Button>();

        //Settings Overlay
        SettingsOverlay = mainMenuCanvasObject.transform.Find("SettingsOverlay").gameObject;
        SettingsExitButtonGameObject = SettingsOverlay.transform.Find("CloseSettingsButton").gameObject;
        SettingsExitButton = SettingsExitButtonGameObject.GetComponent<Button>();

        //Versus AI Menu
        VersusAICanvasGameObject = GameObject.Find("VersusAICanvas");
        VSAIMenuCanvas = VersusAICanvasGameObject.GetComponent<Canvas>();
        ReturnToMMButtonGameObject = GameObject.Find("ReturnToMMButton");
        ReturnToMMButton = ReturnToMMButtonGameObject.GetComponent<Button>();
        



        
        
        
        
        
        
        
        


        //Event listeners
        //Swap between Play selection buttons and main menu buttons
        PlayButton.onClick.AddListener(() => { VersusFriendsButtonGameObject.SetActive(true); ExitButtonGameObject.SetActive(false); StoryModeGameObject.SetActive(true); WIPOverlayGameObject.SetActive(true); VersusAIButtonGameObject.SetActive(true); BackButtonGameObject.SetActive(true); PlayButtonGameObject.SetActive(false); SettingsButtonGameObject.SetActive(false); BackButtonGameObject.SetActive(true); });
        BackButton.onClick.AddListener(() => { VersusFriendsButtonGameObject.SetActive(false); ExitButtonGameObject.SetActive(true); StoryModeGameObject.SetActive(false); WIPOverlayGameObject.SetActive(false); VersusAIButtonGameObject.SetActive(false); BackButtonGameObject.SetActive(false); PlayButtonGameObject.SetActive(true); SettingsButtonGameObject.SetActive(true); BackButtonGameObject.SetActive(false); });
        
        //Settings open/close (In main menu)
        SettingsExitButton.onClick.AddListener(() => SettingsOverlay.SetActive(false));
        SettingsButton.onClick.AddListener(() => SettingsOverlay.SetActive(true));

        //Exit game
        ExitButton.onClick.AddListener(() => Application.Quit());

        //Switch between main menu and Versus AI menu
        ReturnToMMButton.onClick.AddListener(() => SwitchCanvas(VSAIMenuCanvas, mainMenuCanvas));
        VersusAIButton.onClick.AddListener(() => SwitchCanvas(mainMenuCanvas, VSAIMenuCanvas));
    }
    void SwitchCanvas(Canvas aCanvas, Canvas bCanvas)
    {
        aCanvas.enabled = false;
        bCanvas.enabled = true;
    }
}
