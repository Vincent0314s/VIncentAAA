using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    private static GameControl _i;
    public static GameControl i {
        get {
            if (_i == null) {
                _i = FindObjectOfType<GameControl>();
            }
            return _i;
        }
    }

    public Text HPText;
    public Text scoreText;
    public Text timeText;
    Canon turret;

    [HideInInspector]
    public int totalScore;
    float currentTime = 30f;

    private void Awake()
    {
        totalScore = 0;
        PlayerPrefs.DeleteAll();
        turret = FindObjectOfType<Canon>();
    }

    void Update()
    {
        if (currentTime >0 && turret.currentHP > 0)
        {
            currentTime -= Time.deltaTime;
        }
        else {
            PlayerPrefs.SetInt("Score", totalScore);
            SceneManager.LoadScene(1);

        }

        HPText.text = "HP: " + turret.currentHP.ToString();
        scoreText.text = "Score: " + totalScore.ToString();
        timeText.text = "Time: " + currentTime.ToString("f1");
    }
}
