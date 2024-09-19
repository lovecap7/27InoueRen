using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Player : MonoBehaviour
{
    private float moveSpeed;
    private float runSpeed;
    private float jumpPower;
   // private float gravityPower;
    private Rigidbody rb;

    bool isJump;
    bool isDash;
    bool isStop;
    public static bool isDead;
    public static bool isCheckPoint;
    public static bool isClear;
    public static bool isEndClear;
    public static bool isPause;

    private GameObject pausePanel;
    private Animator anim;

    public AudioClip jumpSe;
    public AudioClip checkPointSe;
    public AudioClip lvUpSe;
    AudioSource audioSource;

    public Image staminaBer;
    public Image staminaBerMax;
    public static float staminaValue;
    public static float staminaValueMax;
    private float staminaTime;
    private float upEatNum;

    public GameObject upParticleObject;
    public TextMeshProUGUI lvText;
    private int staminaLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        moveSpeed = 11f;
        runSpeed = 15f;
        jumpPower = 1500f;
        //gravityPower = -1000f;

        isJump = true;
        isDash = true;
        isStop = false;
        isDead = false;
        isCheckPoint = false;
        isClear = false;
        isEndClear = false;
        isPause = false;

        pausePanel = GameObject.Find("Canvas/PausePanel");
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        anim = null;

        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        staminaValueMax = 3f;
        staminaValue = staminaValueMax;
        staminaTime = 0.025f;
        upEatNum = 30;
        staminaBer.transform.localScale = new Vector3(1f, staminaValue, 1f);
        staminaLevel = 1;


    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;
        }

        PlayerMove();

        if (Input.GetKeyDown(KeyCode.Space) && isJump)
        {
            isJump = false;
            audioSource.PlayOneShot(jumpSe);
            PlayerJump();
        }

        if(Input.GetMouseButton(1))
        {
            isStop = true;
        }
        else
        {
            isStop = false;
        }
        //Gravity();


        if (Input.GetMouseButton(0))
        {
            isDash = true ;
           
        }
        else
        {
            isDash = false;
           
        }

        if (isStop)
        {

            runSpeed = 0;
            staminaValue -= Time.deltaTime * 0.25f;
        }
        else if (isDash)
        {
           
            runSpeed = 30;
            staminaValue -= Time.deltaTime;
        }
        else
        {
           
            runSpeed = 15f;
            staminaValue += Time.deltaTime * staminaTime;
        }

        if (staminaValue < 0f)
        {
            runSpeed = 15f;
            staminaValue = 0f;
        }
        if (staminaValue >= staminaValueMax)
        {
            staminaValue = staminaValueMax;
        }

        staminaBer.transform.localScale = new Vector3(1f, staminaValue, 1f);
        if (EatCount.eatNum >= upEatNum)
        {
            audioSource.PlayOneShot(lvUpSe);
            staminaLevel++;
            staminaTime += 0.1f;
            lvText.text = "Lv." + staminaLevel.ToString();
            Instantiate(upParticleObject, this.transform.position, Quaternion.identity);
            staminaValue = staminaValueMax;
            
            upEatNum += 30;
        }
       






        if (this.transform.position.y < -5)
        {
            isDead = true;
            staminaValue = staminaValueMax;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnPausePanel();
        }


        if (isPause)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
        }
    }

    void PlayerMove()
    {

        if (Input.GetAxis("Horizontal") == 1 || Input.GetAxis("Horizontal") == -1)
        {
            moveSpeed++;
        }
        else
        {
            moveSpeed = 11f;
        }
        if (moveSpeed > 15f)
        {
            moveSpeed = 15f;
        }
        //Debug.Log(moveSpeed);

        //垂直方向と水平方向の入力を取得し、それぞれの移動速度をかける。
        float laneMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float runMove = runSpeed * Time.deltaTime;

        //現在のX,Zベクトルに上の処理で取得した値を渡す。
        Vector3 movedir = new Vector3(laneMove, 0, runMove);

        //現在地に上で取得をした値を足して移動する。
        this.transform.position += movedir;

    }

    void PlayerJump()
    {
        rb.AddForce(transform.up * jumpPower, ForceMode.Impulse);
        anim.SetBool("isJump", true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "CheckPoint")
        {
            isJump = true;
            anim.SetBool("isJump", false);
        }
       
        if (collision.gameObject.tag == "CheckPoint")
        {
            isCheckPoint = true;
            audioSource.PlayOneShot(checkPointSe);
        }
        if (collision.gameObject.tag == "Goal")
        {
            isClear = true;
        }
        if (collision.gameObject.tag == "EndGoal")
        {
            isEndClear = true;
        }
        if (collision.gameObject.tag == "Block")
        {
            isDead = true;
            staminaValue = staminaValueMax;
        }
    }

    //private void OnCollisionStay(Collision collision)
    //{
       
    //}

    public void OnPausePanel()
    {
        if (!isPause)
        {
            isPause = true;
        }
        else
        {
            isPause = false;
        }

    }
}

    
