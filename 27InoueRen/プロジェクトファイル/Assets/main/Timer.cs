using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshProの名前空間をインポート

public class Timer : MonoBehaviour
{
    float second;
    float minutu;
    private GameObject TimerObj;
    private TextMeshProUGUI TimerText;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        TimerObj = GameObject.Find("Canvas/Time/TimerText");
        TimerText = TimerObj.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        second += Time.deltaTime;
        minutu = second % 60;

        TimerText.text = second.ToString("f2");
    }
}
