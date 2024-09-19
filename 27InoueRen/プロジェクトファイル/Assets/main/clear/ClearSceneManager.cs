using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClearSceneManager : MonoBehaviour
{
    public GameObject panel;
    private float canClickTimer;
    private bool canClickFlag;
    private GameObject resultObj;
    private TextMeshProUGUI resultText;
    private int allNum = 0;
    private int addNum = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        canClickTimer = 0f;
        canClickFlag = false;
        panel.SetActive(false);
        addNum = PlayerPrefs.GetInt("EatNum",0);
        allNum = PlayerPrefs.GetInt("AllEatNum",0);

    }

    // Update is called once per frame
    void Update()
    {
        
        if(canClickTimer > 3f)
        {
            canClickFlag = true;
        }

        if (canClickFlag)
        {
            panel.SetActive(true);
            resultObj = GameObject.Find("Canvas/Panel/Result/ResultText");
            resultText = resultObj.GetComponent<TextMeshProUGUI>();
            resultText.text = "食べたハンバーガー\n" + addNum.ToString() +"\n今まで食べたハンバーガー\n" + allNum.ToString();
            return;
        }

        canClickTimer += Time.deltaTime;
        Debug.Log(canClickTimer);
    }
}
