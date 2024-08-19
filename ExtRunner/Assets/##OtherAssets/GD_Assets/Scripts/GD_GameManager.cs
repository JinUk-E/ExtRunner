using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GD_GameManager : AtSceneSingleton<GD_GameManager>
{
    public delegate void OnPlay(bool isPlaying);
    public OnPlay onPlay;
    
    public float gameSpeed = 1f;
    
    public bool isPlaying = false;
    public GameObject StartButton;
    
    public void StartGame()
    {
        StartButton.SetActive(false);
        isPlaying = true;
        onPlay?.Invoke(isPlaying);
    }
    
    public void GameOver()
    {
        isPlaying = false;
        StartButton.SetActive(true);
        onPlay?.Invoke(isPlaying);
    }
}
