using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectforShield : MonoBehaviour
{
    public AudioClip shieldSE;
    /*
    public int damage;          //�����������ʖ��̃_���[�W��
    private GameObject enemy;   //�G�I�u�W�F�N�g
    private PlayerHP hp;              //HP�N���X

    void Start()
    {
        enemy = GameObject.Find("Player");   //�v���C���[�����擾
        hp = enemy.GetComponent<PlayerHP>();      //HP�����擾
    }
    */

    void OnCollisionEnter(Collision col)
    {

        //�Ԃ������I�u�W�F�N�g��Tag��Shell�Ƃ������O�������Ă������Ȃ�΁i�����j.
        if (col.gameObject.tag == "EnemyShell")
        {

            //HP�N���X��Damage�֐����Ăяo��
            //hp.Damage(damage);

            //�Ԃ����Ă����I�u�W�F�N�g��j�󂷂�.
            //Destroy(gameObject);
            Destroy(col.gameObject);
            AudioSource.PlayClipAtPoint(shieldSE, new Vector3(0, 0, -1));
        }
    }

}
