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
        //�G����Ƀv���[���[�������悤��
        transform.LookAt(player.transform);
    }
}
