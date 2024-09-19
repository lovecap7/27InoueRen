using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
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

        this.transform.position += new Vector3(0, 0, -20f * Time.deltaTime);
        this.transform.Rotate(0, 30f * Time.deltaTime, 0); // (���[�J����)X���𒆐S��1����]
        if (Player.isDead)
        {
            this.transform.position = firstPos;
        }
    }
}
