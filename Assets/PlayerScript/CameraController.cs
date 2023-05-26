using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{

    public class CameraController : MonoBehaviour
    {


        [Range(0.1f, 10f)]
        //�J�������x�A���l���傫���قǂ�蒼���I�ȑ��삪�\.
        public float lookSensitivity = 6f;
        [Range(0.1f, 1f)]
        //���l���傫���قǃJ�������������������Ɍ����܂ł̎��Ԃ������Ȃ�.
        public float lookSmooth = 0.1f;

        public Vector2 MinMaxAngle = new Vector2(-65, 65);

        private float yRot;
        private float xRot;

        private float currentYRot;
        private float currentXRot;

        private float yRotVelocity;
        private float xRotVelocity;

        //leap motion�𓮂������߂ɕK�{
        [SerializeField]
        private Leap.Unity.CapsuleHand right_hand;

        Leap.Hand hand;



        //public Vector3 cube = new Vector3();


        void Update()
        {

            if (hand == null)
            {
                hand = right_hand.GetLeapHand();
            }

            else
            {
                hand = right_hand.GetLeapHand();
                Leap.Vector screenPoint = hand.PalmPosition;

                yRot += screenPoint.x * lookSensitivity; //�}�E�X�̈ړ�.
                xRot -= screenPoint.z * lookSensitivity; //�}�E�X�̈ړ�.



                xRot = Mathf.Clamp(xRot, MinMaxAngle.x, MinMaxAngle.y);//�㉺�̊p�x�ړ��̍ő�A�ŏ�.


                currentXRot = Mathf.SmoothDamp(currentXRot, xRot, ref xRotVelocity, lookSmooth);
                currentYRot = Mathf.SmoothDamp(currentYRot, yRot, ref yRotVelocity, lookSmooth);

                transform.rotation = Quaternion.Euler(currentXRot, currentYRot, 0);
            }
            
        }

        /*
        private Vector3 GetLeapPointOnUnityScreen()
        {
            Vector3 leapPoint = new Vector3(hand.PalmPosition.x, hand.PalmPosition.y, 0);

            return leapPoint;
        }*/



    }
}

/*
void Update()
{

    yRot += Input.GetAxis("Mouse X") * lookSensitivity; //�}�E�X�̈ړ�.
    xRot -= Input.GetAxis("Mouse Y") * lookSensitivity; //�}�E�X�̈ړ�.



    xRot = Mathf.Clamp(xRot, MinMaxAngle.x, MinMaxAngle.y);//�㉺�̊p�x�ړ��̍ő�A�ŏ�.


    currentXRot = Mathf.SmoothDamp(currentXRot, xRot, ref xRotVelocity, lookSmooth);
    currentYRot = Mathf.SmoothDamp(currentYRot, yRot, ref yRotVelocity, lookSmooth);

    transform.rotation = Quaternion.Euler(currentXRot, currentYRot, 0);


}*/