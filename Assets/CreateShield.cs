using Leap;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShield : MonoBehaviour
{
    public GameObject Shield;
    public GameObject Shooting;


    public AudioClip shieldsound;
    public AudioClip gunsound;

    AudioSource audiosource;

    //leap motion�𓮂������߂ɕK�{
    [SerializeField]
    private Leap.Unity.CapsuleHand left_hand;

    Leap.Hand hand;

    // Start is called before the first frame update
    void Start()
    {
        Shield.SetActive(true);
        Shooting.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        hand = left_hand.GetLeapHand();


        if (hand != null)
        {
            
            if (hand.GrabStrength < 0.75) //����J������
            {
                /*
                if(Shield.activeSelf == true)
                {
                    audiosource.PlayOneShot(gunsound);
                }
                */
                Shield.SetActive(false);
                Shooting.SetActive(true);
            }

            else
            {
                /*
                if (Shooting.activeSelf == true)
                {
                    audiosource.PlayOneShot(shieldsound);
                }
                */
                Shield.SetActive(true);
                Shooting.SetActive(false);
                
            }

        }
    }
}
