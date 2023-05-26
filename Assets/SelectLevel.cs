using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap;
using UnityEngine.SceneManagement;
using Image = UnityEngine.UI.Image;

public class SelectLevel : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;
    public GameObject practice;
    public GameObject change;

    public GameObject Title;
    public GameObject Howtoplay;

    public GameObject lv1;

    public AudioClip selectsound;
    AudioSource audiosource;

    Vector3 objposition;

    


    //leap motionを動かすために必須
    [SerializeField]
    private Leap.Unity.CapsuleHand right_hand;

    Leap.Hand hand;

    [Range(0.1f, 10f)]
    //カメラ感度、数値が大きいほどより直感的な操作が可能.
    public float lookSensitivity = 6f;

    private float yRot;
    private float xRot;


    void Start()
    {
       
    }

    // Update is called once per frame
    private void Update()
    {
        if (hand == null)
        {
            hand = right_hand.GetLeapHand();
        }
        else
        {
            Vector screenPoint = hand.PalmPosition;

            objposition = this.transform.position;

            if (objposition.x > -8f & objposition.x < 8f)
            {
                objposition.x += screenPoint.x * lookSensitivity;
            }
            else
            {
                if (objposition.x < 0)
                {
                    objposition.x = -7f;
                }
                else
                {
                    objposition.x = 7f;
                }
            }

            if (objposition.y > -5f & objposition.y < 5f)
            {
                objposition.y += screenPoint.z * lookSensitivity;
            }
            else
            {
                if (objposition.y < 0)
                {
                    objposition.y = -4f;
                }
                else
                {
                    objposition.y = 4f;
                }
            }

            objposition.z = 8;

            this.transform.position = objposition;
        }

    }


    void OnTriggerStay(Collider col)
    {

        //レベル1への画面遷移
        if (col.gameObject.tag == "lv1")
        {
            

            if ((hand = right_hand.GetLeapHand()) != null)
            {

                if (hand.GrabStrength > 0.75) //手を握った時
                {
                    AudioSource.PlayClipAtPoint(selectsound, new Vector3(0, 0, 0));
                    level1.SetActive(true);
                    FadeManager.Instance.LoadScene("Level1Shooting",3.0f);
                }
            }
        }


        //レベル2への画面遷移
        if (col.gameObject.tag == "lv2")
        {
            if ((hand = right_hand.GetLeapHand()) != null)
            {

                if (hand.GrabStrength > 0.75) //手を握った時
                {
                    AudioSource.PlayClipAtPoint(selectsound, new Vector3(0, 0, 0));
                    level2.SetActive(true);
                    FadeManager.Instance.LoadScene("Level2Shooting",3.0f);
                }
            }
        }

            //リトライ→タイトルへ
        if (col.gameObject.tag == "Retry")
        {

            if ((hand = right_hand.GetLeapHand()) != null)
            {

                if (hand.GrabStrength > 0.75) //手を握った時
                {
                    AudioSource.PlayClipAtPoint(selectsound, new Vector3(0, 0, 0));
                    FadeManager.Instance.LoadScene("TitleScene",3.0f);
                }
            }
        }

        //操作説明は別のsceneで記述
        if (col.gameObject.tag == "howtoplay")
        {
            if ((hand = right_hand.GetLeapHand()) != null)
            {
                if (hand.GrabStrength > 0.75) //手を握った時
                {
                    AudioSource.PlayClipAtPoint(selectsound, new Vector3(0, 0, 0));
                    practice.SetActive(true);
                    FadeManager.Instance.LoadScene("Explanation",3.0f);
                }
            }
        }

        //操作説明は別のsceneで記述
        if (col.gameObject.tag == "secret")
        {

            if ((hand = right_hand.GetLeapHand()) != null)
            {
                
                if (hand.GrabStrength > 0.75) //手を握った時
                {
                    AudioSource.PlayClipAtPoint(selectsound, new Vector3(0, 0, 0));
                    FadeManager.Instance.LoadScene("SecretShooting", 3.0f);
                }
            }
        }

        if (col.gameObject.tag == "change")
        {
            if ((hand = right_hand.GetLeapHand()) != null)
            {

                if (hand.GrabStrength > 0.75) //手を握った時
                {
                    AudioSource.PlayClipAtPoint(selectsound, new Vector3(0, 0, 0));
                    if (lv1.activeSelf == true)
                    {
                        FadeManager.Instance.LoadScene("UraTitle", 3.0f);
                    }
                    else
                    {
                        FadeManager.Instance.LoadScene("TitleScene", 3.0f);
                    }
                }
            }
        }
    }




    IEnumerator DelayCoroutine()
    {
        transform.position = Vector3.one;

        // 3秒間待つ
        yield return new WaitForSeconds(3f);

        // 3秒後に原点にワープ
        transform.position = Vector3.zero;
    }


}
