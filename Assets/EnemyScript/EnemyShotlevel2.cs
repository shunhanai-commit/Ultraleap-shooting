using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotlevel2 : MonoBehaviour
{
    public GameObject shellPrefab;
    public GameObject player;
    public AudioClip sound;
    private int count;

    void Update()
    {

        transform.LookAt(player.transform);

        count += 1;

        // iƒ|ƒCƒ“ƒgj
        // ‚U‚OƒtƒŒ[ƒ€‚²‚Æ‚É–C’e‚ğ”­Ë‚·‚é
        if (count % 150 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            // ’e‘¬‚Í©—R‚Éİ’è
            shellRb.AddForce(transform.forward * 1000);



            // ”­Ë‰¹‚ğo‚·
            //AudioSource.PlayClipAtPoint(sound, transform.position);

            // ‚T•bŒã‚É–C’e‚ğ”j‰ó‚·‚é
            Destroy(shell, 5.0f);
        }
    }
}