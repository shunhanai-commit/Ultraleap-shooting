using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovelevel1 : MonoBehaviour
{
    public GameObject enemy;
    private float time;
    private float vecX;
    private float vecY;
    private int count;

    [Range(0.1f, 30f)]
    //�J�������x�A���l���傫���قǂ�蒼���I�ȑ��삪�\.
    public float moveVelocity = 6f;

    Vector3 movePosition;  //�A�I�u�W�F�N�g�̖ړI�n��ۑ�

    void Start()
    {
        movePosition = moveRandomPosition();  //�A���s���A�I�u�W�F�N�g�̖ړI�n��ݒ�
    }

    void Update()
    {
        count += 1;

        if (movePosition == enemy.transform.position)  //�Aplayer�I�u�W�F�N�g���ړI�n�ɓ��B����ƁA
        {
            movePosition = moveRandomPosition();  //�A�ړI�n���Đݒ�
        }
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, movePosition, moveVelocity * Time.deltaTime);


    }

    private Vector3 moveRandomPosition()  // �ړI�n�𐶐��Ax��y�̃|�W�V�����������_���ɒl���擾 
    {
        Vector3 randomPosi = new Vector3(Random.Range(-10f, 30f), Random.Range(-10f, 20f), 20f);
        return randomPosi;
    }
}
