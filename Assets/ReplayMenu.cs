using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RecordingEvent
{
    float timeStamp;
    Button target;
    string myAction;

    public RecordingEvent(Button button, string action)
    {
        timeStamp = Time.time;
        target = button;
        myAction = action;
    }

    public override string ToString()
    {
        return "" + timeStamp + " " + target + " " + myAction;
    }

}

public class Recording
{
    List<RecordingEvent> recordingEvents = new List<RecordingEvent>();

    float startTime;

    public Recording()
    {
        startTime = Time.time;
    }

    public void AddEvent(Button button, string action)
    {
        recordingEvents.Add(new RecordingEvent(button, action));
    }

    public override string ToString()
    {
        if (recordingEvents.Count > 0)
        {
            string recordingString = "";

            foreach (RecordingEvent recordingEvent in recordingEvents)
            {
                recordingString += " | " + recordingEvent;
            }

            return recordingString;
        }
        else
        {
            return "recording is empty";
        }
    }

}

public class ReplayMenu : MonoBehaviour
{
    public Button startButton;
    public Button stopButton;
    public Button playButton;
    public Button clearButton;

    Recording currentRecording;

    public void StartButton()
    {
        currentRecording = new Recording();

        startButton.gameObject.SetActive(false);
        stopButton.gameObject.SetActive(true);
        playButton.gameObject.SetActive(false);
        clearButton.gameObject.SetActive(false);
    }

    public void StopButton()
    {
        Debug.Log(currentRecording);

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

    public void TrackEvent(Button button, string action)
    {
        if (currentRecording != null)
        {
            currentRecording.AddEvent(button, action);
        }
    }

}
