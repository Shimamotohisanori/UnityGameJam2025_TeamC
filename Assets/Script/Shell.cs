using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shell : MonoBehaviour
{
    //public string shellName = "Shell"; // �e�̖��O
    public string MeteoTag = "Meteo"; // ���f���̃^�O

    private int Score = 0; // �X�R�A���Ǘ����邽�߂̕ϐ�

    public TextMeshProUGUI score;// �X�R�A��\�����邽�߂�TextMeshProUGUI�R���|�[�l���g
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
        if (other.CompareTag(MeteoTag)) // ���f���ɏՓ˂����ꍇ
        {
            Score += 100; // �X�R�A�����Z
            score.text = "Score: " + Score; // �X�R�A��\���X�V
            Destroy(other.gameObject); // ���f�����폜
            Destroy(gameObject); // �e���폜
        }
    }
}
