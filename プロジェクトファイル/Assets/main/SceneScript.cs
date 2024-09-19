using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void StageSelectScene()
    {
        SceneManager.LoadScene("StageSelectScene");
    }

    public void ClearScene()
    {
        SceneManager.LoadScene("clearScene");
    }

    public void ReStart()
    {
        //SceneManager.LoadScene("TutorialScene");
        int stageNum = PlayerPrefs.GetInt("StageNum");
        switch (stageNum)
        {
            case 0:
                TutorialScene();
                break;
            case 1:
                Stage1();
                break;
            case 2:
                Stage2();
                break;
            case 3:
                Stage3();
                break;
            case 4:
                Stage4();
                break;
            case 5:
                StageEx();
                break;
            default:
                StageSelectScene();
                break;
        }
    }

    public void TutorialScene()
    {
        SceneManager.LoadScene("TutorialScene");
        PlayerPrefs.SetInt("StageNum", 0);
        PlayerPrefs.Save();
    }

    public void Stage1()
    {
        SceneManager.LoadScene("Stage1Scene");
        PlayerPrefs.SetInt("StageNum", 1);
        PlayerPrefs.Save();
    }

    public void Stage2()
    {
        SceneManager.LoadScene("Stage2Scene");
        PlayerPrefs.SetInt("StageNum", 2);
        PlayerPrefs.Save();
    }

    public void Stage3()
    {
        SceneManager.LoadScene("Stage3Scene");
        PlayerPrefs.SetInt("StageNum", 3);
        PlayerPrefs.Save();
    }

    public void Stage4()
    {
        SceneManager.LoadScene("Stage4Scene");
        PlayerPrefs.SetInt("StageNum", 4);
        PlayerPrefs.Save();
    }

    public void StageEx()
    {
        SceneManager.LoadScene("StageExScene");
        PlayerPrefs.SetInt("StageNum", 5);
        PlayerPrefs.Save();
    }
}
