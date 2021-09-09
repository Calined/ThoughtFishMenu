using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayMenu : MonoBehaviour
{
    public Button startButton;
    public Button stopButton;
    public Button playButton;
    public Button clearButton;


    public void StartButton()
    {
        startButton.gameObject.SetActive(false);
        stopButton.gameObject.SetActive(true);
        playButton.gameObject.SetActive(false);
        clearButton.gameObject.SetActive(false);
    }

    public void StopButton()
    {
        startButton.gameObject.SetActive(true);
        stopButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(true);
        clearButton.gameObject.SetActive(true);
    }

    public void PlayButton()
    {
        startButton.gameObject.SetActive(false);
        stopButton.gameObject.SetActive(true);
        playButton.gameObject.SetActive(false);
        clearButton.gameObject.SetActive(false);
    }

    public void ClearButton()
    {
        startButton.gameObject.SetActive(true);
        stopButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
        clearButton.gameObject.SetActive(false);
    }

}
