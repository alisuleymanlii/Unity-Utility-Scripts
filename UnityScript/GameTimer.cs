///This code activates the games included in the game scenes for one hour each in 24 hours.

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class OyunSaatManagerScene : MonoBehaviour
{
    public string[] oyunSceneAdlari;       
// Scene names you will add in the Inspector
    public TextMeshProUGUI countdownText;  // Remaining time
    public TextMeshProUGUI nextGameText;   // Next game name

    private int currentHour = -1;
    private bool started = false;

    public void StartGame() // Will be bound to the Start button
    {
        started = true;
        currentHour = DateTime.Now.Hour;
        LoadCurrentScene();
    }

    void Update()
    {
        if (!started) return;

        DateTime now = DateTime.Now;
        int hourNow = now.Hour;

        // Load a new scene if the time has changed
        if(hourNow != currentHour)
        {
            currentHour = hourNow;
            LoadCurrentScene();
        }

        // Remaining time
        int minutesLeft = 59 - now.Minute;
        int secondsLeft = 59 - now.Second;
        countdownText.text = string.Format("{0:00}:{1:00}", minutesLeft, secondsLeft);

        // Növbəti oyun adı
        int nextIndex = (currentHour + 1) % oyunSceneAdlari.Length;
        nextGameText.text = "Növbəti oyun: " + oyunSceneAdlari[nextIndex];
    }

    void LoadCurrentScene()
    {
        if(oyunSceneAdlari.Length == 0) return;

        int sceneIndex = (currentHour % oyunSceneAdlari.Length);

        SceneManager.LoadScene(oyunSceneAdlari[sceneIndex]);
    }
}
