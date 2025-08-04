using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public  static ScoreManager Instance; // シングルトンインスタンス

    public int score = 0; // 現在のスコア
    public TextMeshProUGUI scoreText; // スコア表示用のTextMeshProUGUIコンポーネント
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Instance = this; // シングルトンインスタンスの設定
    }

    public void AddScore(int amount)
    {
        score += amount; // スコアを加算
        UpdateScoreText(); // スコア表示を更新
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString(); // スコアをテキストに設定
        }
    }
}
