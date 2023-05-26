using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCube : MonoBehaviour
{
    private GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("LookCube");
    }

    // Update is called once per frame
    void Update()
    {
        //“G‚ªí‚ÉƒvƒŒ[ƒ„[‚ğŒü‚­‚æ‚¤‚É
        transform.LookAt(cube.transform);
    }
}
