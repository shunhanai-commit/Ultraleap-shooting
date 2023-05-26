using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{

    public GameObject particleObject;
    public int MaxHP = 100;  //HP
    public int hitPoint;
    private Vector3 objposition;
    public GameObject player;

    private PlayerHP hp;

    public GameObject effect;

    public AudioClip explosionSE;

    public GameObject cannon;

    public GameObject machinegun;

    //HP�\��
    int score = 0;
    public Text scoreText;
    public Slider slider;


    void Start()
    {
        slider.value = 1;
        hitPoint = MaxHP;

        //hp = player.GetComponent<PlayerHP>();
        //player = GameObject.Find("PlayerBody");
    }

    // Update is called once per frame
    void Update()
    {
        hp = player.GetComponent<PlayerHP>();
        //HP��0�ɂȂ����Ƃ��ɓG��j�󂷂�
        if (hitPoint <= 0)
        {
            //�����̃G�t�F�N�g
            objposition = GameObject.Find("Cube").transform.position;
            Instantiate(particleObject, objposition, Quaternion.identity);

            //������
            AudioSource.PlayClipAtPoint(explosionSE, new Vector3(0,0,-1));

            effect.SetActive(true);

            StartCoroutine(DelayCoroutine());

            //����������{�Ԃ��̔F��
            if (cannon.activeSelf == false)
            {
                FadeManager.Instance.LoadScene("TitleScene",3.0f);
            }
            else
            {
                if (hp.hitPoint == 100)
                {
                    FadeManager.Instance.LoadScene("Perfect", 3.0f);
                }
                else if (hp.hitPoint >= 70)
                {
                    FadeManager.Instance.LoadScene("Rank A", 3.0f);
                }
                else
                {
                    FadeManager.Instance.LoadScene("Rank B", 3.0f);
                }
            }


            //�q�b�g�|�C���g�̍Đ�
            hitPoint = MaxHP;

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
        // 3�b�ԑ҂�
        yield return new WaitForSeconds(3f);
    }

}