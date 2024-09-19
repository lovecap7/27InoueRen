using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private GameObject player;
    private Vector3 vector = new Vector3(0,10f, -15f);
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + vector;
    }
}
