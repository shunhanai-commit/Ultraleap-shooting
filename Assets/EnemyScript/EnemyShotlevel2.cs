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

        // �i�|�C���g�j
        // �U�O�t���[�����ƂɖC�e�𔭎˂���
        if (count % 150 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            // �e���͎��R�ɐݒ�
            shellRb.AddForce(transform.forward * 1000);



            // ���ˉ����o��
            //AudioSource.PlayClipAtPoint(sound, transform.position);

            // �T�b��ɖC�e��j�󂷂�
            Destroy(shell, 5.0f);
        }
    }
}