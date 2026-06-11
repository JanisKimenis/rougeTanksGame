using System;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public gameState currentGameState = 0;



    public enum gameState
    {
        inMainMenu,
        inCountdown,
        inBattle,
        inUpgrades

    }


}
