using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    public GameObject maincamera;
    public GameObject subcamera;

    
    void Start()
    {
        maincamera.SetActive(true);
        subcamera.SetActive(false);
    }

    // Update is called once per frame

    public void Camerachange1()
    {
        //受け取ったダメージ分HPを減らす
        maincamera.SetActive(false);
        subcamera.SetActive(true);
    }

    public void Camerachange2()
    {
        //受け取ったダメージ分HPを減らす
        maincamera.SetActive(true);
        subcamera.SetActive(false);
    }

}
