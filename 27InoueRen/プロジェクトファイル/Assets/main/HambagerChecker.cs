using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HambagerChecker : MonoBehaviour
{
    private int allNum = 0;
    public GameObject lock1;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public TextMeshProUGUI countText;
    // Start is called before the first frame update
    void Start()
    {
        allNum = PlayerPrefs.GetInt("AllEatNum", 0);
        countText.text = allNum.ToString();
        if (allNum >= 100)
        {
            lock1.SetActive(false);
        }
        if (allNum >= 250)
        {
            lock2.SetActive(false);
        }
        if (allNum >= 500)
        {
            lock3.SetActive(false);
        }
        if (allNum >= 700)
        {
            lock4.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
