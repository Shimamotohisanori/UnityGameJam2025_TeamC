using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField, Header("�v���C���[�̎c�@")]
    public int life = 5;//�v���C���[�̃��C�t�����邽�߂̕ϐ�

    public TextMeshProUGUI lifeText;//���C�t��\�����邽�߂�TextMeshProUGUI�R���|�[�l���g

    public GameObject asteroid_mod_01_lowPrefab;//���f����Prefab�����邽�߂̕ϐ�

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

            life--;//���C�t��1���炷
            lifeText.text = "Life: " + life;//���C�t��\������
            if (life < 1)
            {
                Destroy(gameObject);//�v���C���[�����f���ɓ���������v���C���[���폜
            }
        }
    }

}
