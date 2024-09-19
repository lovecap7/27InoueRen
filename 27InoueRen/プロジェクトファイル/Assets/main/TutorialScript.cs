using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshPro�̖��O��Ԃ��C���|�[�g

public class TutorialScript : MonoBehaviour
{
    private GameObject tutorialObj;
    private TextMeshProUGUI tutorialText;

    private GameObject player;
    private Player playerScript;

    // Start is called before the first frame update
    void Start()
    {
        tutorialObj = GameObject.Find("Canvas/TutorialText");
        tutorialText = tutorialObj.GetComponent<TextMeshProUGUI>();
        player = GameObject.Find("Player");
        playerScript = new Player();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z < -200)
        {
            tutorialText.text = "�`���[�g���A��";
        }
        if (-150 < player.transform.position.z && player.transform.position.z < 50)
        {
            tutorialText.text = "A�L�[�ō��ɁAD�L�[�ŉE�Ɉړ�\n���L�[���\";
        }
        if (30 < player.transform.position.z)
        {
            tutorialText.text = "space�L�[�܂���\n�E�N���b�N�ŃW�����v�I�I";
        }
        if(Player.isDead)
        {
            tutorialText.text = "���A�����ĂȂ��������ǃX�e�[�W���痎������A�G��J�x�ɂԂ���ƃQ�[���I�[�o�[����";
        }
    }
}
