using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelNumText : MonoBehaviour
{
    public Text Text;
    public Game Game;
    void Start()
    {
        Text.text = "level " + (Game.LevelIndex + 1).ToString();
    }

    
}
