using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshProの名前空間をインポート

public class TutorialScript : MonoBehaviour
{
    private GameObject tutorialObj;
    private TextMeshProUGUI tutorialText;

    private GameObject player;
    private Player playerScript;

    // Start is called before the first frame update
    void Start()
    {
        tutorialObj = GameObject.Find("Canvas/TutorialText");
        tutorialText = tutorialObj.GetComponent<TextMeshProUGUI>();
        player = GameObject.Find("Player");
        playerScript = new Player();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z < -200)
        {
            tutorialText.text = "チュートリアル";
        }
        if (-150 < player.transform.position.z && player.transform.position.z < 50)
        {
            tutorialText.text = "Aキーで左に、Dキーで右に移動\n矢印キーも可能";
        }
        if (30 < player.transform.position.z)
        {
            tutorialText.text = "spaceキーまたは\n右クリックでジャンプ！！";
        }
        if(Player.isDead)
        {
            tutorialText.text = "あ、言ってなかったけどステージから落ちたり、敵やカベにぶつかるとゲームオーバーだよ";
        }
    }
}
