using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shell : MonoBehaviour
{
    //public string shellName = "Shell"; // 弾の名前
    public string MeteoTag = "Meteo"; // 小惑星のタグ

    private static int Score = 0; // スコアを保持する静的変数

    public TextMeshProUGUI score;// スコアを表示するためのTextMeshProUGUIコンポーネント

    [SerializeField, Header("1個分のスコア")]
    private int pulusScore = 100; // 1個の小惑星を破壊したときに加算されるスコア

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + Score; // スコアを表示更新
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(MeteoTag)) // 小惑星に衝突した場合
        {
            Score += pulusScore; // スコアを加算
            
            Destroy(other.gameObject); // 小惑星を削除
            Destroy(gameObject); // 弾を削除
        }
    }
}
