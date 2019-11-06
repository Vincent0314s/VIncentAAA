using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{

    public Text scoreRecord;

    void Start()
    {
        scoreRecord.text = "Score:" + PlayerPrefs.GetInt("Score");
        //scoreRecord.text = "NO" + "Score:" + PlayerPrefs.GetInt("Score").ToString();
    }
}
