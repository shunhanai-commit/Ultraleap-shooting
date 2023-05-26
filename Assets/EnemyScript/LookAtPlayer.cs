using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("LookCube");
    }

    // Update is called once per frame
    void Update()
    {
        //敵が常にプレーヤーを向くように
        transform.LookAt(player.transform);
    }
}
