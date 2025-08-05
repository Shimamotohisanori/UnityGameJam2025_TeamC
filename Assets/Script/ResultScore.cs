using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultScore : MonoBehaviour
{
    public Shell shell; // Shellクラスのインスタンスを参照するための変数

    public int Resultscore; // スコアを保持する変数
    public TextMeshProUGUI ResultText; // スコアを表示するためのTextMeshProUGUIコンポーネント
    // Start is called before the first frame update
    void Start()
    {
        Resultscore = Shell.Score; // Shellクラスの静的変数Scoreからスコアを取得
        ResultText.text = "Score: " + Resultscore; // スコアをテキストに設定
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
