using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField, Header("プレイヤーの残機")]
    public int life = 5;//プレイヤーのライフを入れるための変数

    public TextMeshProUGUI lifeText;//ライフを表示するためのTextMeshProUGUIコンポーネント

    public GameObject asteroid_mod_01_lowPrefab;//小惑星のPrefabを入れるための変数

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
        if (other.gameObject.CompareTag("Meteo"))
        {

            life--;//ライフを1減らす
            lifeText.text = "Life: " + life;//ライフを表示する
            if (life < 1)
            {
                Destroy(gameObject);//プレイヤーが小惑星に当たったらプレイヤーを削除
            }
        }
    }

}
