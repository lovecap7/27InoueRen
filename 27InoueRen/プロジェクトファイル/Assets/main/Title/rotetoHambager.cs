using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotetoHambager : MonoBehaviour
{
    private float time;
    private float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        time = 500;
        speed = -0.1f;
        Time.timeScale = 1;

       
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, speed, 0); // (ƒ[ƒJƒ‹‚Ì)X²‚ğ’†S‚É1‹‰ñ“]
        time++;
        speed = time * -0.1f * Time.deltaTime;

       
    }
}
