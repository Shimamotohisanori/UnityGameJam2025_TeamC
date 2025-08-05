using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField,Header("移動速度")]//これをすることによってunity画面でも速度の編集が可能
    private float moveSpeed;//移動速度を入れるための変数

    public GameObject ShellPrefab;//弾のPrefabを入れるための変数

    [SerializeField, Header("弾の移動速度")]
    private float shellSpeed = 700f; // 弾の移動速度を入れるための変数

    [SerializeField, Header("弾の削除時間")]
    private float shellDestroyTime = 3f; // 弾の削除時間を入れるための変数

    private float time = 0; // 時間をカウントするための変数

    [SerializeField,Header("連射間隔")]
    private float timeinterval = 0.5f; // 連射間隔を入れるための変数

    private AudioSource audioSource; // AudioSourceコンポーネントを入れるための変数
    public AudioClip shotSound; // 弾を撃ったときの音を入れるための変数
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // AudioSourceコンポーネントを取得
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; // 時間をカウント

        if (Input.GetKey(KeyCode.UpArrow))//上矢印キーを押している間上に動く
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))//下矢印キーを押している間下に動く
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))//左矢印キーを押している間後ろに動く
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))//右矢印キーを押している間前に動く
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        //if (Input.GetKey(KeyCode.W))//Wキーを押している間上に動く
        //{
        //    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //}
        //if(Input.GetKey(KeyCode.S))//Sキーを押している間下に動く
        //{
        //    transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        //}
        //if(Input.GetKey(KeyCode.A))//Aキーを押している間後ろに動く
        //{
        //    transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        //}
        //if(Input.GetKey(KeyCode.D))//Dキーを押している間前に動く
        //{
        //    transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        //}

        if (time > timeinterval)
        {
            if (Input.GetKey(KeyCode.Space))//スペースキーを押したら弾を出す
            {
                audioSource.PlayOneShot(shotSound); // 弾を撃ったときの音を再生
                time = 0; // 時間をリセット
                GameObject shell = Instantiate(ShellPrefab, transform.position, Quaternion.identity);//弾のPrefabを生成
                Rigidbody shellRb = shell.GetComponent<Rigidbody>();//弾のRigidbodyを取得
                shellRb.AddForce(transform.forward * shellSpeed);//弾の移動速度
                Destroy(shell, shellDestroyTime);//3秒後に弾を削除
            }
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

   
}
