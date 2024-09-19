using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataReset : MonoBehaviour
{
    public GameObject warning;
    public GameObject result;
    public GameObject clearEffect;
    private int saveEndClear;
    // Start is called before the first frame update
    void Start()
    {
        warning.SetActive(false);
        result.SetActive(false);
        clearEffect.SetActive(false);
        saveEndClear = PlayerPrefs.GetInt("CLEAR", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (saveEndClear != 0)
        {
            clearEffect.SetActive(true);
        }
        else
        {
            clearEffect.SetActive(false);
        }
    }

    public void ResetButton()
    {
        warning.SetActive(true);
    }
    public void YesButton()
    {
        PlayerPrefs.SetInt("EatNum", 0);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("AllEatNum",0);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("CLEAR", 0);
        PlayerPrefs.Save();
        result.SetActive(true);
    }

    public void NoButton()
    {
        warning.SetActive(false);
    }

   
}
