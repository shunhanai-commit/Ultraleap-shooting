using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectforplayer : MonoBehaviour
{

    public int damage;          //�����������ʖ��̃_���[�W��
    private GameObject enemy;   //�G�I�u�W�F�N�g
    private PlayerHP hp;              //HP�N���X
    public AudioClip blood;

    void Start()
    {
        enemy = GameObject.Find("Player");   //�v���C���[�����擾
        hp = enemy.GetComponent<PlayerHP>();      //HP�����擾
    }

    void OnCollisionEnter(Collision col)
    {

        //�Ԃ������I�u�W�F�N�g��Tag��Shell�Ƃ������O�������Ă������Ȃ�΁i�����j.
        if (col.gameObject.tag == "EnemyShell")
        {

            //HP�N���X��Damage�֐����Ăяo��
            hp.Damage(damage);

            //�_���[�W��
            AudioSource.PlayClipAtPoint(blood, transform.position);

            //�Ԃ����Ă����I�u�W�F�N�g��j�󂷂�.
            
            Destroy(col.gameObject);
        }
    }

    private void Update()
    {
        // transform.Rotate(0, 0, -0.1f);
    }

}
