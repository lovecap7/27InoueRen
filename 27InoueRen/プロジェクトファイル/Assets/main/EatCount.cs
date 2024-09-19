using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshProの名前空間をインポート
using UnityEngine.SceneManagement;

public class EatCount : MonoBehaviour
{
    public static int eatNum = 0;
    public int allEatNum = 0;
    private GameObject eatCountObj;
    private TextMeshProUGUI eatCountText;
    private Player playerScript;

    private float beforeNum;
    public AudioClip eatSe;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        eatNum = 0;
        allEatNum = PlayerPrefs.GetInt("AllEatNum", 0);
        beforeNum = 0;
        eatCountObj = GameObject.Find("Canvas/EatCount/EatCountText");
        eatCountText = eatCountObj.GetComponent<TextMeshProUGUI>();
        playerScript = new Player();

        audioSource = GetComponent<AudioSource>();

       
    }

    // Update is called once per frame
    void Update()
    {
        eatCountText.text = "X" + eatNum.ToString();
        if(eatNum > beforeNum )
        {
            audioSource.PlayOneShot(eatSe);
            beforeNum = eatNum;
        }
        

        if (Player.isClear)
        {
            PlayerPrefs.SetInt("EatNum", eatNum);
            PlayerPrefs.Save();
            allEatNum += eatNum;
            PlayerPrefs.SetInt("AllEatNum", allEatNum);
            PlayerPrefs.Save();
            SceneManager.LoadScene("clearScene");
        }
        if (Player.isEndClear)
        {
            allEatNum += eatNum;
            PlayerPrefs.SetInt("AllEatNum", allEatNum);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("CLEAR", 1);
            PlayerPrefs.Save();
            SceneManager.LoadScene("EndScene");
        }
    }
}
