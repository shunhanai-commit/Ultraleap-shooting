using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectmove : MonoBehaviour
{

    private Vector3 targetpos;

    // Start is called before the first frame update
    void Start()
    {
        targetpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 10.0f + targetpos.x, Mathf.Sin(Time.time) * 10.0f + targetpos.y, targetpos.z);
    }
}
