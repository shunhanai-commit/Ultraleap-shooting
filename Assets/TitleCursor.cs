using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap;


//�^�C�g����ʂł̃J�[�\������

public class TitleCursor : MonoBehaviour
{

    //leap motion�𓮂������߂ɕK�{
    [SerializeField]
    private Leap.Unity.CapsuleHand right_hand;

    //RectTransform rect;

    [Range(0.1f, 10f)]
    //�J�������x�A���l���傫���قǂ�蒼���I�ȑ��삪�\.
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
        yRot += screenPoint.x * lookSensitivity; //�}�E�X�̈ړ�.
        xRot -= screenPoint.z * lookSensitivity; //�}�E�X�̈ړ�.
        */
        a.position += new Vector3(screenPoint.x * lookSensitivity, screenPoint.y * lookSensitivity, 0);
    }
}
