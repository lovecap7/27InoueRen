using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public GameObject image7;
    public GameObject nextButton;
    public GameObject backButton;
    private int imageNum;
    // Start is called before the first frame update
    void Start()
    {
        image1.SetActive(true);
        nextButton.SetActive(true);
        image2.SetActive(false);
        image3.SetActive(false);
        image4.SetActive(false);
        image5.SetActive(false);
        image6.SetActive(false);
        image7.SetActive(false);
        backButton.SetActive(false);
        imageNum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(imageNum < 1)
        {
            imageNum = 1;
        }
        if (imageNum > 8)
        {
            imageNum = 8;
        }


        switch (imageNum)
        {
            case 1:
                backButton.SetActive(false);
                image1.SetActive(true);
                image2.SetActive(false);
                image3.SetActive(false);
                image4.SetActive(false);
                image5.SetActive(false);
                image6.SetActive(false);
                image7.SetActive(false);
                break;
            case 2:
                backButton.SetActive(true);
                image1.SetActive(false);
                image2.SetActive(true);
                image3.SetActive(false);
                image4.SetActive(false);
                image5.SetActive(false);
                image6.SetActive(false);
                image7.SetActive(false);
                break;
            case 3:
                image1.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(true);
                image4.SetActive(false);
                image5.SetActive(false);
                image6.SetActive(false);
                image7.SetActive(false);
                break;
            case 4:
                image1.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(false);
                image4.SetActive(true);
                image5.SetActive(false);
                image6.SetActive(false);
                image7.SetActive(false);
                break;
            case 5:
                image1.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(false);
                image4.SetActive(false);
                image5.SetActive(true);
                image6.SetActive(false);
                image7.SetActive(false);
                break;
            case 6:
                image1.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(false);
                image4.SetActive(false);
                image5.SetActive(false);
                image6.SetActive(true);
                image7.SetActive(false);
                break;
            case 7:
                image1.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(false);
                image4.SetActive(false);
                image5.SetActive(false);
                image6.SetActive(false);
                image7.SetActive(true);
                break;
            case 8:
                SceneManager.LoadScene("StageSelectScene");
                break;
        }
    }

    public void OnButtonNext()
    {
        imageNum++;
    }
    public void OnButtonBack()
    {
        imageNum--;
    }

}
