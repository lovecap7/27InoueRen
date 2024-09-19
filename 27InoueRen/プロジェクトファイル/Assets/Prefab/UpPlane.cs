using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpPlane : MonoBehaviour
{
    private float upDownSpeed;
    private Vector3 vecMoveSpeed;
    private Vector3 myPos;
    // Start is called before the first frame update
    void Start()
    {
        upDownSpeed = 5f;
        vecMoveSpeed = new Vector3(0, upDownSpeed, 0);

    }

    // Update is called once per frame
    void Update()
    {
        myPos = this.transform.position;
        this.transform.position += vecMoveSpeed * Time.deltaTime;
        if (myPos.y > 100)
        {
            this.transform.position = new Vector3(myPos.x, -10f, myPos.z);
        }
    }
}
