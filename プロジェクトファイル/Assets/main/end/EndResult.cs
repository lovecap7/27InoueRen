using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndResult : MonoBehaviour
{
    public GameObject camera;
    public GameObject GameObject1;
    public GameObject GameObject2;
    public GameObject GameObject3;
    public GameObject GameObject4;
    public GameObject GameObject5;
    public GameObject GameObject6;

    public GameObject back;
    public GameObject firstText;
    public GameObject secondText;
    public GameObject thirdText;
    public GameObject finalText;

    public AudioClip handSe;
    

    public GameObject panel;
    public GameObject resultNumText;
    public GameObject titleButton;
    private float TextTimer;
    private GameObject resultObj;
    private TextMeshProUGUI resultText;
    private int allNum = 0;
   

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        camera.transform.position = new Vector3(0, 4, -1);

        GameObject1.SetActive(false);
        GameObject2.SetActive(false);
        GameObject3.SetActive(false);
        GameObject4.SetActive(false);
        GameObject5.SetActive(false);
        GameObject6.SetActive(false);

        back.SetActive(false);
        firstText.SetActive(false);
        secondText.SetActive(false);
        thirdText.SetActive(false);
        finalText.SetActive(false);

        TextTimer = 0f;

        panel.SetActive(false);
        resultNumText.SetActive(false);
        titleButton.SetActive(false);
        allNum = PlayerPrefs.GetInt("AllEatNum", 0);

    }

    // Update is called once per frame
    void Update()
    {

        if (TextTimer > 2f)
        {
            GameObject1.SetActive(true);
            camera.transform.position = new Vector3(4, 4.3f, -1.4f);
        }
        if (TextTimer > 4f)
        {
            GameObject2.SetActive(true);
            camera.transform.position = new Vector3(27f, 4f, -2f);
        }
        if (TextTimer > 6f)
        {
            GameObject3.SetActive(true);
            camera.transform.position = new Vector3(-9.5f, 4.6f, -2.6f);
        }
        if (TextTimer > 8f)
        {
            GameObject4.SetActive(true);
            camera.transform.position = new Vector3(8.6f, 4.5f, -1.6f);
        }
        if (TextTimer > 10f)
        {
            GameObject5.SetActive(true);
            camera.transform.position = new Vector3(-16f, 4.8f, -2f);
        }
        if (TextTimer > 12f)
        {
            GameObject6.SetActive(true);
            camera.transform.position = new Vector3(17f, 4f, -2f);
        }
        if (TextTimer > 14f)
        {
            camera.transform.position = new Vector3(-5f, 4.3f, -1.4f);
        }
        if (TextTimer > 16f)
        {
           back.SetActive(true);
           firstText.SetActive(true);
        }
        if (TextTimer > 18f)
        {
            firstText.SetActive(false);
            secondText.SetActive(true);
        }
        if (TextTimer > 20f)
        {
            secondText.SetActive(false);
            thirdText.SetActive(true);
        }
        if (TextTimer > 22f)
        {
            thirdText.SetActive(false);
            finalText.SetActive(true);
        }
        if (TextTimer > 24f)
        {
            thirdText.SetActive(false);
            finalText.SetActive(true);
        }
        if (TextTimer > 26f)
        {
            finalText.SetActive(false);
            panel.SetActive(true);
        }
        if (TextTimer > 28f)
        {
            resultNumText.SetActive(true);
            resultObj = GameObject.Find("Canvas/Panel/ResultNumText");
            resultText = resultObj.GetComponent<TextMeshProUGUI>();
            resultText.text = allNum.ToString();
        }
        if (TextTimer > 30f)
        {
            titleButton.SetActive(true);
            return;
        }
        TextTimer += Time.deltaTime;
       
    }
}
