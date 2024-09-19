using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultMove : MonoBehaviour
{
    private Vector3 firstPos;
    // Start is called before the first frame update
    void Start()
    {
        firstPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        this.transform.position += new Vector3(0, 0, -5f * Time.deltaTime);
        if(Player.isDead)
        {
            this.transform.position = firstPos;
        }
    }


}
