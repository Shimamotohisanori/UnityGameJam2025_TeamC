using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    [SerializeField, Header("プレイヤーの残機")]
    public int life = 5;//プレイヤーのライフを入れるための変数

    public TextMeshProUGUI lifeText;//ライフを表示するためのTextMeshProUGUIコンポーネント

    public GameObject asteroid_mod_01_lowPrefab;//小惑星のPrefabを入れるための変数

    private AudioSource missaudioSource; // AudioSourceコンポーネントを入れるための変数
    public AudioClip missSound; // 機体が隕石に当たったときの音を入れるための変数
    // Start is called before the first frame update
    void Start()
    {
        missaudioSource = GetComponent<AudioSource>(); // AudioSourceコンポーネントを取得
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Meteo"))
        {
            missaudioSource.PlayOneShot(missSound); // 機体が隕石に当たったときの音を再生
            life--;//ライフを1減らす
            lifeText.text = "Life: " + life;//ライフを表示する
            if (life < 1)
            { 
                SceneManager.LoadScene("ResultScene");//ライフが0以下になったらリザルトシーンに移動
                Destroy(gameObject);//プレイヤーが小惑星に当たったらプレイヤーを削除
            }
        }
    }

}
