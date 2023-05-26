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
    //カメラ感度、数値が大きいほどより直感的な操作が可能.
    public float moveVelocity = 6f;

    Vector3 movePosition;  //②オブジェクトの目的地を保存

    void Start()
    {
        movePosition = moveRandomPosition();  //②実行時、オブジェクトの目的地を設定
    }

    void Update()
    {
        count += 1;

        if (movePosition == enemy.transform.position)  //②playerオブジェクトが目的地に到達すると、
        {
            movePosition = moveRandomPosition();  //②目的地を再設定
        }
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, movePosition, moveVelocity * Time.deltaTime);


    }

    private Vector3 moveRandomPosition()  // 目的地を生成、xとyのポジションをランダムに値を取得 
    {
        Vector3 randomPosi = new Vector3(Random.Range(-10f, 30f), Random.Range(-10f, 20f), 20f);
        return randomPosi;
    }
}
