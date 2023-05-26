using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap;


//タイトル画面でのカーソル操作

public class TitleCursor : MonoBehaviour
{

    //leap motionを動かすために必須
    [SerializeField]
    private Leap.Unity.CapsuleHand right_hand;

    //RectTransform rect;

    [Range(0.1f, 10f)]
    //カメラ感度、数値が大きいほどより直感的な操作が可能.
    public float lookSensitivity = 6f;

    private float yRot;
    private float xRot;

    public RectTransform a;

    void Start()
    {
        //rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Leap.Hand hand = right_hand.GetLeapHand();
        Leap.Vector screenPoint = hand.PalmPosition;
        /*
        yRot += screenPoint.x * lookSensitivity; //マウスの移動.
        xRot -= screenPoint.z * lookSensitivity; //マウスの移動.
        */
        a.position += new Vector3(screenPoint.x * lookSensitivity, screenPoint.y * lookSensitivity, 0);
    }
}
