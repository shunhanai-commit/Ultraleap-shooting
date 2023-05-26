using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{

    public GameObject particleObject;
    public int MaxHP = 100;  //HP
    public int hitPoint;
    private Vector3 objposition;
    private GameObject player;

    public AudioClip explosionSE;

    //HP�\��
    int score = 0;
    public Text scoreText;
    public Slider slider;


    void Start()
    {
        slider.value = 1;
        hitPoint = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        //�G����Ƀv���[���[�������悤��
        //transform.LookAt(player.transform);

        //HP��0�ɂȂ����Ƃ��ɓG��j�󂷂�
        if (hitPoint <= 0)
        {

            StartCoroutine(DelayCoroutine());
            //�Q�[���I�[�o�[��ʂ̕\��
            SceneManager.LoadScene("Gameover");

            //�q�b�g�|�C���g�̍Đ�
            hitPoint = MaxHP;
            slider.value = 1;

        }

    }

    //�_���[�W���󂯎����HP�����炷�֐�
    public void Damage(int damage)
    {
        //�󂯎�����_���[�W��HP�����炷
        hitPoint -= damage;

        slider.value = (float)hitPoint / (float)MaxHP;
    }

    public void AddScore()
    {
        score += 10;
    }

    IEnumerator DelayCoroutine()
    {
        transform.position = Vector3.one;

        // 3�b�ԑ҂�
        yield return new WaitForSeconds(3f);

        // 3�b��Ɍ��_�Ƀ��[�v
        transform.position = Vector3.zero;
    }

}