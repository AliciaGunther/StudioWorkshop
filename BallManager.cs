using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�{�[���������̃I�u�W�F�N�g�ɏՓ�
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "OutArea")
        {
            //�A�E�g�G���A�ɏՓ�
            //�Q�[���}�l�[�W�����擾
            GameObject gameManager = GameObject.Find("GameManager");
            //���g���C
            gameManager.GetComponent<GameManager>().PushRetryButton();
        }
    }

    //�{�[���������̃g���K�[�ɏՓ�
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "ClearArea")
        {
            //�N���A�G���A�ɓ�����
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<GameManager>().StageClear();
        }
    }
    //�e�X�g�̂��߂ɍŌ�ɂ����Ȃ����P�Ԃ񂗂̂�����������
}
