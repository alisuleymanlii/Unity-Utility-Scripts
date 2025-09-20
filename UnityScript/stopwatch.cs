//STOPWATCH

using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class stopwatch : MonoBehaviour
{
    public TextMeshProUGUI stopwatchText;

    private float elapsedTime = 0f;
    private bool isRunning = false;

    public Button reset;
    public Button start;

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateStopwatchText();
        }

        if (isRunning)
        {
            reset.interactable = false;
            start.interactable = false;
        }
        else
        {
            reset.interactable = true;
            start.interactable = true;
        }
    }

    public void StartStopwatch()
    {
        isRunning = true;
    }

    public void StopStopwatch()
    {
        isRunning = false;
    }

    public void ResetStopwatch()
    {
        isRunning = false;
        elapsedTime = 0f;
        UpdateStopwatchText();
    }

    private void UpdateStopwatchText()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        int milliseconds = Mathf.FloorToInt((elapsedTime * 1000) % 1000);

        stopwatchText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
}
