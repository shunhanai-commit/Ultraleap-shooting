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
        //�󂯎�����_���[�W��HP�����炷
        maincamera.SetActive(false);
        subcamera.SetActive(true);
    }

    public void Camerachange2()
    {
        //�󂯎�����_���[�W��HP�����炷
        maincamera.SetActive(true);
        subcamera.SetActive(false);
    }

}
