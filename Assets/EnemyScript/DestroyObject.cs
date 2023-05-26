using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public int damage;          //�����������ʖ��̃_���[�W��
    public GameObject enemy;   //�G�I�u�W�F�N�g
    private HP hp;              //HP�N���X
    public AudioClip blood;

    void Start()
    {
        //enemy = GameObject.Find("Enemy");   //�G�����擾
        hp = enemy.GetComponent<HP>();      //HP�����擾
    }

    void OnCollisionEnter(Collision col)
    {

        //�Ԃ������I�u�W�F�N�g��Tag��Shell�Ƃ������O�������Ă������Ȃ�΁i�����j.
        if (col.gameObject.tag == "Shell")
        {

            //HP�N���X��Damage�֐����Ăяo��
            hp.Damage(damage);

            //�_���[�W��
            AudioSource.PlayClipAtPoint(blood, new Vector3(0,0,0));

            //�Ԃ����Ă����I�u�W�F�N�g��j�󂷂�.
            //Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }

    private void Update()
    {
       // transform.Rotate(0, 0, -0.1f);
    }




}
