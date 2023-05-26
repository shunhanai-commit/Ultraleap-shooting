using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectforShield : MonoBehaviour
{
    public AudioClip shieldSE;
    /*
    public int damage;          //当たった部位毎のダメージ量
    private GameObject enemy;   //敵オブジェクト
    private PlayerHP hp;              //HPクラス

    void Start()
    {
        enemy = GameObject.Find("Player");   //プレイヤー情報を取得
        hp = enemy.GetComponent<PlayerHP>();      //HP情報を取得
    }
    */

    void OnCollisionEnter(Collision col)
    {

        //ぶつかったオブジェクトのTagにShellという名前が書いてあったならば（条件）.
        if (col.gameObject.tag == "EnemyShell")
        {

            //HPクラスのDamage関数を呼び出す
            //hp.Damage(damage);

            //ぶつかってきたオブジェクトを破壊する.
            //Destroy(gameObject);
            Destroy(col.gameObject);
            AudioSource.PlayClipAtPoint(shieldSE, new Vector3(0, 0, -1));
        }
    }

}
