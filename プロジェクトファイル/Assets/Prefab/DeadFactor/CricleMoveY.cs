using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CricleMoveY : MonoBehaviour
{
    private int cricleSpeed;                //�I�u�W�F�N�g�̃X�s�[�h
    private int radius;               //�~��`�����a
    private Vector3 defPosition;//defPosition��Vector3�Œ�`����B
    float x;
    float y;
   

    // Use this for initialization
    void Start()
    {
        cricleSpeed = 2;
        radius = 5;

        defPosition = transform.position;    //defPosition�������̂���ʒu�ɐݒ肷��B
    }

    // Update is called once per frame
    void Update()
    {
        x = radius * Mathf.Sin(Time.time * cricleSpeed);      //X���̐ݒ�
        y = radius * Mathf.Cos(Time.time * cricleSpeed);      //Z���̐ݒ�

        this.transform.position = new Vector3(x + defPosition.x, y + defPosition.y, defPosition.z);  //�����̂���ʒu������W�𓮂����B

    }
}
