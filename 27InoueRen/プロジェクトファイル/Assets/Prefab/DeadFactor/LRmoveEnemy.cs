using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRmoveEnemy : MonoBehaviour
{
    private float moveSpeed;
    private Vector3 vecMoveSpeed;
    private Vector3 myPos;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10f;
        vecMoveSpeed = new Vector3(moveSpeed, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        myPos = this.transform.position;
        this.transform.position += vecMoveSpeed * Time.deltaTime;
        if(myPos.x > 20)
        {
            vecMoveSpeed.x = -moveSpeed;
        }
        if (myPos.x < -20)
        {
            vecMoveSpeed.x = moveSpeed;
        }
    }
}
