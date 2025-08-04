using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shell : MonoBehaviour
{
    //public string shellName = "Shell"; // 弾の名前
    public string MeteoTag = "Meteo"; // 小惑星のタグ

    private int Score = 0; // スコアを管理するための変数

    public TextMeshProUGUI score;// スコアを表示するためのTextMeshProUGUIコンポーネント
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(MeteoTag)) // 小惑星に衝突した場合
        {
            Score += 100; // スコアを加算
            score.text = "Score: " + Score; // スコアを表示更新
            Destroy(other.gameObject); // 小惑星を削除
            Destroy(gameObject); // 弾を削除
        }
    }
}
