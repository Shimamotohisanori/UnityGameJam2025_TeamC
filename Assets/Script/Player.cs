using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField,Header("移動速度")]//これをすることによってunity画面でも速度の編集が可能
    private float moveSpeed;//移動速度を入れるための変数

    public GameObject ShellPrefab;//弾のPrefabを入れるための変数
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))//Wキーを押している間上に動く
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))//Sキーを押している間下に動く
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))//Aキーを押している間後ろに動く
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))//Dキーを押している間前に動く
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))//スペースキーを押したら弾を出す
        {
            GameObject shell = Instantiate(ShellPrefab, transform.position, Quaternion.identity);//弾のPrefabを生成
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();//弾のRigidbodyを取得
            shellRb.AddForce(transform.forward * 500);//弾の移動速度
            Destroy(shell, 4);//4秒後に弾を削除
        }
    }
}
