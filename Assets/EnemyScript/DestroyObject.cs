using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public int damage;          //当たった部位毎のダメージ量
    public GameObject enemy;   //敵オブジェクト
    private HP hp;              //HPクラス
    public AudioClip blood;

    void Start()
    {
        //enemy = GameObject.Find("Enemy");   //敵情報を取得
        hp = enemy.GetComponent<HP>();      //HP情報を取得
    }

    void OnCollisionEnter(Collision col)
    {

        //ぶつかったオブジェクトのTagにShellという名前が書いてあったならば（条件）.
        if (col.gameObject.tag == "Shell")
        {

            //HPクラスのDamage関数を呼び出す
            hp.Damage(damage);

            //ダメージ音
            AudioSource.PlayClipAtPoint(blood, new Vector3(0,0,0));

            //ぶつかってきたオブジェクトを破壊する.
            //Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }

    private void Update()
    {
       // transform.Rotate(0, 0, -0.1f);
    }




}
