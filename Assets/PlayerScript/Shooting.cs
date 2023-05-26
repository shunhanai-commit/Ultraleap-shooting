using Leap;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float shotSpeed;
    public int shotCount = 30;
    public Text zanndannsuu;
    private float shotInterval;


    //leap motion‚ğ“®‚©‚·‚½‚ß‚É•K{
    [SerializeField]
    private Leap.Unity.CapsuleHand right_hand;

    Leap.Hand hand;


    //ËŒ‚‰¹
    public AudioClip bulletSE;

    void Start()
    {
        zanndannsuu.text = "" + shotCount;
    }

    void Update()
    {
        if((hand = right_hand.GetLeapHand()) != null)
        {
            if (hand.GrabStrength <= 0.75)
            {
                shotInterval += 1;

                if (shotInterval % 10 == 0 && shotCount > 0)
                {
                    shotCount -= 1;

                    zanndannsuu.text = "" + shotCount;

                    GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                    Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                    bulletRb.AddForce(transform.forward * shotSpeed);

                    //ËŒ‚‰¹
                    AudioSource.PlayClipAtPoint(bulletSE, transform.position);

                    //ËŒ‚‚³‚ê‚Ä‚©‚ç3•bŒã‚Ée’e‚ÌƒIƒuƒWƒFƒNƒg‚ğ”j‰ó‚·‚é.

                    Destroy(bullet, 3.0f);
                }

            }

            else
            {
                shotCount = 100;
            }

        }
    }
}