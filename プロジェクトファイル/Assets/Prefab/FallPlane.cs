using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlane : MonoBehaviour
{
    private Vector3 myPos;
    private bool isFall;
    // Start is called before the first frame update
    void Start()
    {
        myPos = this.transform.position;
        isFall = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < -5)
        {
           isFall = false;
            this.transform.position = myPos;
           
        }
        if(isFall)
        {
            this.transform.position += new Vector3(0f, -5f * Time.deltaTime, 0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isFall = true;
        }
    }
}
