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

    //HP表示
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
        //敵が常にプレーヤーを向くように
        //transform.LookAt(player.transform);

        //HPが0になったときに敵を破壊する
        if (hitPoint <= 0)
        {

            StartCoroutine(DelayCoroutine());
            //ゲームオーバー画面の表示
            SceneManager.LoadScene("Gameover");

            //ヒットポイントの再生
            hitPoint = MaxHP;
            slider.value = 1;

        }

    }

    //ダメージを受け取ってHPを減らす関数
    public void Damage(int damage)
    {
        //受け取ったダメージ分HPを減らす
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

        // 3秒間待つ
        yield return new WaitForSeconds(3f);

        // 3秒後に原点にワープ
        transform.position = Vector3.zero;
    }

}