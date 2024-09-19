using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject particleObject;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(-20f * Time.deltaTime, 200f * Time.deltaTime, 20f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
        {
            EatCount.eatNum++;

            Instantiate(particleObject, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
       
    }
}
