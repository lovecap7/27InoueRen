using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighRotateSword : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, -60f * Time.deltaTime); // (ローカルの)X軸を中心に1°回転
    }
}
