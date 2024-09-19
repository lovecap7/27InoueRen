using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
   
    private GameObject gameoverPanel;
    private GameObject player;
    private GameObject deadEffect;
    private GameObject checkPoint;
    private Vector3 addY;
    private Vector3 playerPos;
    private float effectTimer;
    // Start is called before the first frame update
    void Start()
    {
        gameoverPanel = GameObject.Find("Canvas/GameOverPanel");
        player = GameObject.Find("Player");
        deadEffect = GameObject.Find("DeadEffect");
        checkPoint = GameObject.Find("CheckPoint");
        addY = new Vector3(0, 2, 0);
        gameoverPanel.SetActive(false);
        deadEffect.SetActive(false);
        effectTimer = 0f;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(effectTimer > 30f)
        {
            gameoverPanel.SetActive(true);
            return;
        }
        if (Player.isDead)
        {
            effectTimer++;

            playerPos = player.transform.position;
            deadEffect.transform.position = playerPos;
            player.SetActive(false);
            deadEffect.SetActive(true);
        }



    }
    public void Retry()
    {
        Player.staminaValue = Player.staminaValueMax;
        if (Player.isCheckPoint)
        {
            Time.timeScale = 1;
            player.transform.position = checkPoint.transform.position + addY;
            player.SetActive(true);
            Player.isDead = false;
            gameoverPanel.SetActive(false);
            deadEffect.SetActive(false);
            Player.isPause = false;
            effectTimer = 0f;
        }
        else
        {
            Time.timeScale = 1;
            player.transform.position = new Vector3(0, 5, 0);
            player.SetActive(true);
            Player.isDead = false;
            gameoverPanel.SetActive(false);
            deadEffect.SetActive(false);
            Player.isPause = false;
            effectTimer = 0f;       
        }
    }
}
