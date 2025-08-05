using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
   public Shell shell; // Shellクラスのインスタンスを参照するための変数

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Shell.Score = 0; // スコアをリセット
            SceneManager.LoadScene("TetileScene");//リザルトシーンでEnterキーまたはマウスの左クリックを押したらタイトルシーンに移動
        }
    }
}
