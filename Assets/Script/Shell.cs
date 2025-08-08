using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shell : MonoBehaviour
{
    //public string shellName = "Shell"; // 弾の名前
    public string MeteoTag = "Meteo"; // 小惑星のタグ

    public static int Score = 0; // スコアを保持する静的変数

    public TextMeshProUGUI score;// スコアを表示するためのTextMeshProUGUIコンポーネント

    [SerializeField, Header("1個分のスコア")]
    private int pulusScore = 100; // 1個の小惑星を破壊したときに加算されるスコア

    private AudioSource conflictaudioSource; // AudioSourceコンポーネントを入れるための変数
    public AudioClip conflictSound; // 小惑星に衝突したときの音を入れるための変数
    // Start is called before the first frame update
    void Start()
    {
        conflictaudioSource = GetComponent<AudioSource>(); // AudioSourceコンポーネントを取得
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
            conflictaudioSource.PlayOneShot(conflictSound); // 小惑星に衝突したときの音を再生
            Score += pulusScore; // スコアを加算

            Destroy(other.gameObject); // 小惑星を削除
            Destroy(gameObject,conflictSound.length); // 弾を削除
        }
    }
}
