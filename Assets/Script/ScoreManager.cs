using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public  static ScoreManager Instance; // �V���O���g���C���X�^���X

    public int score = 0; // ���݂̃X�R�A
    public TextMeshProUGUI scoreText; // �X�R�A�\���p��TextMeshProUGUI�R���|�[�l���g
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
        Instance = this; // �V���O���g���C���X�^���X�̐ݒ�
    }

    public void AddScore(int amount)
    {
        score += amount; // �X�R�A�����Z
        UpdateScoreText(); // �X�R�A�\�����X�V
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString(); // �X�R�A���e�L�X�g�ɐݒ�
        }
    }
}
