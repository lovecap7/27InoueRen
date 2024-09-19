using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallHambarger : MonoBehaviour
{
    private Vector3 myPos;
   
    // Start is called before the first frame update
    void Start()
    {
        myPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(-20f * Time.deltaTime, 200f * Time.deltaTime, 20f * Time.deltaTime);
        if (this.transform.position.y < -100)
        {
            this.transform.position = myPos;
        }
        this.transform.position += new Vector3(0f, -20f * Time.deltaTime, 0f);
    }
}
