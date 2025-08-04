using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField,Header("移動速度")]//これをすることによってunity画面でも速度の編集が可能
    private float moveSpeed;//移動速度を入れるための変数

    public GameObject ShellPrefab;//弾のPrefabを入れるための変数

    public GameObject asteroid_mod_01_lowPrefab;//小惑星のPrefabを入れるための変数
    Rigidbody rb;//Rigidbodyを入れるための変数
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();//Rigidbodyを取得
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.W))//Wキーを押している間上に動く
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))//Sキーを押している間下に動く
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))//Aキーを押している間後ろに動く
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))//Dキーを押している間前に動く
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))//スペースキーを押したら弾を出す
        {
            GameObject shell = Instantiate(ShellPrefab, transform.position, Quaternion.identity);//弾のPrefabを生成
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();//弾のRigidbodyを取得
            shellRb.AddForce(transform.forward * 500);//弾の移動速度
            Destroy(shell, 4);//4秒後に弾を削除
        }

        if(transform.position.y < -14)//プレイヤーが下に落ちたら
        {
            transform.position = new Vector3(0, 0, 10);//プレイヤーの位置をリセット
        }
        if(transform.position.y > 14)//プレイヤーが上に行きすぎたら
        {
            transform.position = new Vector3(0, 0, 10);//プレイヤーの位置をリセット
        }
        if (transform.position.x < -26)//プレイヤーが左に行きすぎたら
        {
            transform.position = new Vector3(0, 0, 10);//プレイヤーの位置をリセット
        }
        if (transform.position.x > 26)//プレイヤーが右に行きすぎたら
        {
            transform.position = new Vector3(0, 0, 10);//プレイヤーの位置をリセット
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("asteroid_mod_01_low"))
        {
            Destroy(gameObject);//プレイヤーが小惑星に当たったらプレイヤーを削除
        }
    }
}
